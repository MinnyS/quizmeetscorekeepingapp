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
    public partial class IndividualQuizzersForm : Form
    {
        //Declare class variables.
        private int startBindingSourcePosition = 0; //Binding source position for start.
        bool dataBoundControlsLoaded = false; //Variable to store value indicating whether data bound controls are loaded.

        //Default constructor.
        public IndividualQuizzersForm()
        {
            InitializeComponent();
        }

        //Single-argument constructor.
        public IndividualQuizzersForm(int position) : this()
        {
            startBindingSourcePosition = position; //Set starting binding source position to parameter value.
        }

        //Helper method to load data into table.
        private void LoadTable()
        {
            // TODO: This line of code loads data into the 'quizMeetDataSet.Quizzers' table. You can move, or remove it, as needed.
            this.quizzersTableAdapter.Fill(this.quizMeetDataSet.Quizzers);
        }

        //Helper method to save all changes to database.
        private void SaveAllChanges()
        {
            try
            {
                this.Validate();
                this.quizzersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.quizMeetDataSet);
            }
            catch (Exception e)
            {
                //Display error message.
                MainForm.DisplayExceptionErrorMessage(e);
            }

        }

        private void QuizzersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveAllChanges();
        }

        private void IndividualQuizzersForm_Load(object sender, EventArgs e)
        {
            LoadTable(); //Load data into quizzers table.
            SetBindingSourcePosition(startBindingSourcePosition); //Set binding source position.

            // TODO: This line of code loads data into the 'quizMeetDataSet.Churches' table. You can move, or remove it, as needed.
            this.churchesTableAdapter.Fill(this.quizMeetDataSet.Churches);

            //Set church name ComboBox's data source.
            churchComboBox.DataSource = MainForm.GetListOfValuesFromColumnInTablePrecededByItem(this.quizMeetDataSet.Churches, Quiz.CHURCH_NAME, Quiz.NO_CHURCH);
        }

        //Helper method to set binding source position.
        private void SetBindingSourcePosition(int position)
        {
            //If starting position is valid
            if (position > -1 && position < this.quizMeetDataSet.Quizzers.Rows.Count)
            {
                quizzersBindingSource.Position = position; //Set position to starting position.
            }
            else if (position == -1) //if value is -1
            {
                bindingNavigatorAddNewItem.PerformClick(); //Trigger New Item button's Click event.
            }
        }

        private void IndividualQuizzersForm_FormClosing(object sender, FormClosingEventArgs e)
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

        //Event handler for Add New Item button's Click event.
        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //Insert new quizzer.
            quizzersTableAdapter.Insert(
                "quizzer " + (quizzersBindingSource.Position + 1).ToString(),
                string.Empty, Quiz.RED_LEVEL, -1, 0, null, string.Empty
            );

            //Reload table.
            LoadTable();

            //Set position to new quizzer.
            quizzersBindingSource.Position = this.quizMeetDataSet.Quizzers.Rows.Count;
        }

        private void QuizzersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //If data bound controls loaded
            if (dataBoundControlsLoaded)
            {
                //Update church ComboBox selection.
                MainForm.UpdateComboBoxSelection(churchIDLabel.Text, churchComboBox, this.quizMeetDataSet.Churches, Quiz.CHURCH_NAME);
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //Update church ComboBox selection.
            MainForm.UpdateComboBoxSelection(churchIDLabel.Text, churchComboBox, this.quizMeetDataSet.Churches, Quiz.CHURCH_NAME);
        }

        private void IndividualQuizzersForm_Shown(object sender, EventArgs e)
        {
            //Set data bound controls loaded variable to true.
            dataBoundControlsLoaded = true; 

            //Update church ComboBox selection.
            MainForm.UpdateComboBoxSelection(churchIDLabel.Text, churchComboBox, this.quizMeetDataSet.Churches, Quiz.CHURCH_NAME);
        }

        private void ChurchesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If data bound controls loaded
            if (dataBoundControlsLoaded)
            {
                UpdateChurchIDBoundControl(); //Update church ID Label based on ComboBox selection.

                //If no item was selected in team ComboBox
                if (churchComboBox.SelectedIndex == -1)
                {
                    churchComboBox.SelectedIndex = 0; //Set church ComboBox's selection to first element.
                }
            }
        }

        //Helper method to update church ID Label bound control when church ComboBox's selected index is changed.
        private void UpdateChurchIDBoundControl()
        {
            //Declare variable to store team ID.
            int churchID;

            //If user selected no church option
            if (churchComboBox.SelectedIndex == -1 || churchComboBox.SelectedItem.ToString() == Quiz.NO_CHURCH)
            {
                churchID = -1; //Set churchID to negative number.
            }
            else //if user selected a church
            {
                //Set variable to primary key from row with ComboBox selection.
                churchID = MainForm.ReturnPrimaryKeyFromRowWithComboBoxSelection(
                    churchComboBox, this.quizMeetDataSet.Churches, Quiz.CHURCH_NAME
                );
            }

            //Set Text property of bound control to church ID.
            churchIDLabel.Text = churchID.ToString();
        }
    }
}
