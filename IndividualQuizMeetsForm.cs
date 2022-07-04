using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMeetScorekeeper
{
    public partial class IndividualQuizMeetsForm : Form
    {
        //Declare class variables.
        private int startBindingSourcePosition = 0; //Binding source position for start.
        bool dataBoundControlsLoaded = false; //Variable to store value indicating whether data bound controls are loaded.

        //No-argument constructor.
        public IndividualQuizMeetsForm()
        {
            InitializeComponent();
        }

        //Single-argument constructor.
        public IndividualQuizMeetsForm(int position) : this()
        {
            startBindingSourcePosition = position; //Set start binding source position variable to parameter value.
        }

        //Helper method to save all changes to database.
        private void SaveAllChanges()
        {
            try
            {
                this.Validate();
                this.quizMeetsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.quizMeetDataSet);
            }
            catch (Exception e)
            {
                //Display error message.
                MainForm.DisplayExceptionErrorMessage(e);
            }
        }

        //Helper method to load data into table.
        private void LoadTable()
        {
            // TODO: This line of code loads data into the 'quizMeetDataSet.QuizMeets' table. You can move, or remove it, as needed.
            this.quizMeetsTableAdapter.Fill(this.quizMeetDataSet.QuizMeets);
        }

        //Event handler for Exit button's Click event.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close form.
        }

        //Event handler for BindingNavigator Save Item button's Click event.
        private void QuizMeetsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveAllChanges(); //Save changes to database.
        }

        //When form loads, load data into table.
        private void IndividualQuizMeetsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizMeetDataSet.Quizzers' table. You can move, or remove it, as needed.
            this.quizMeetsTableAdapter.Fill(this.quizMeetDataSet.QuizMeets);
            
            //Load table.
            LoadTable();

            //If starting position is valid
            if (startBindingSourcePosition > -1 && startBindingSourcePosition < this.quizMeetDataSet.QuizMeets.Rows.Count)
            {
                quizMeetsBindingSource.Position = startBindingSourcePosition; //Set position to starting position.
            }
            else if (startBindingSourcePosition == -1) //if value is -1
            {
                quizMeetsBindingSource.Position = -1; //Set binding source position so user is creating new entry.
                bindingNavigatorAddNewItem.PerformClick(); //Trigger New Item button's Click event.
            }

            // TODO: This line of code loads data into the 'quizMeetDataSet.Churches' table. You can move, or remove it, as needed.
            this.churchesTableAdapter.Fill(this.quizMeetDataSet.Churches);

            //Set church name ComboBox's data source.
            hostChurchComboBox.DataSource = MainForm.GetListOfValuesFromColumnInTablePrecededByItem(this.quizMeetDataSet.Churches, Quiz.CHURCH_NAME, Quiz.NO_CHURCH);
        }

        //When form is closing
        private void IndividualQuizMeetsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ask user if they want to save database changes.
            DialogResult dialogResult = MessageBox.Show(
                                            "Would you like to save any changes before exiting?",
                                            MainForm.APP_NAME, MessageBoxButtons.YesNoCancel,
                                            MessageBoxIcon.Warning
                                        ); //Initialize variable to user selection.

            //If user selected Yes
            if (dialogResult == DialogResult.Yes)
            {
                SaveAllChanges(); //Save changes to database.
            }
            else if (dialogResult == DialogResult.Cancel) //If user selected Cancel
            {
                e.Cancel = true; //Prevent form from closing.
            }
        }

        //Event handler for Name TextBox Enter event.
        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            nameTextBox.SelectAll(); //Select all text in Name TextBox.
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //Insert new quiz meet.
            quizMeetsTableAdapter.Insert(
                "quiz " + (quizMeetsBindingSource.Position + 1).ToString(),
                DateTime.Today, -1, string.Empty, "Genesis", 15, 15, 20, 20, 5, 5
            );

            //Reload table.
            LoadTable();

            //Set position to new quiz meet.
            quizMeetsBindingSource.Position = this.quizMeetDataSet.QuizMeets.Rows.Count;
        }

        private void IndividualQuizMeetsForm_Shown(object sender, EventArgs e)
        {
            //Set data bound controls loaded variable to true.
            dataBoundControlsLoaded = true;

            //Update church ComboBox selection.
            MainForm.UpdateComboBoxSelection(hostChurchIDLabel.Text, hostChurchComboBox, this.quizMeetDataSet.Churches, Quiz.CHURCH_NAME);
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //Update church ComboBox selection.
            MainForm.UpdateComboBoxSelection(hostChurchIDLabel.Text, hostChurchComboBox, this.quizMeetDataSet.Churches, Quiz.CHURCH_NAME);
        }

        private void QuizMeetsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //If data bound controls loaded
            if (dataBoundControlsLoaded)
            {
                //Update church ComboBox selection.
                MainForm.UpdateComboBoxSelection(hostChurchIDLabel.Text, hostChurchComboBox, this.quizMeetDataSet.Churches, Quiz.CHURCH_NAME);
            }
        }

        private void HostChurchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If data bound controls loaded
            if (dataBoundControlsLoaded)
            {
                UpdateHostChurchIDBoundControl(); //Update host church ID Label based on ComboBox selection.

                //If no item was selected in team ComboBox
                if (hostChurchComboBox.SelectedIndex == -1)
                {
                    hostChurchComboBox.SelectedIndex = 0; //Set host church ComboBox's selection to first element.
                }
            }
        }

        //Helper method to update host church ID Label bound control when church ComboBox's selected index is changed.
        private void UpdateHostChurchIDBoundControl()
        {
            //Declare variable to store team ID.
            int hostChurchID;

            //If user selected no church option
            if (hostChurchComboBox.SelectedIndex == -1 || hostChurchComboBox.SelectedItem.ToString() == Quiz.NO_CHURCH)
            {
                hostChurchID = -1; //Set churchID to negative number.
            }
            else //if user selected a church
            {
                //Set variable to primary key from row with ComboBox selection.
                hostChurchID = MainForm.ReturnPrimaryKeyFromRowWithComboBoxSelection(
                    hostChurchComboBox, this.quizMeetDataSet.Churches, Quiz.CHURCH_NAME
                );
            }

            //Set Text property of bound control to church ID.
            hostChurchIDLabel.Text = hostChurchID.ToString();
        }
    }
}
