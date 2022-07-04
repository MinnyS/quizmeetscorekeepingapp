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
    public partial class QuizzersForm : Form
    {
        //No-argument constructor.
        public QuizzersForm()
        {
            InitializeComponent();
        }

        private void QuizzersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quizzersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizMeetDataSet);
        }

        //Helper method to load data into table.
        private void LoadTable()
        {
            // TODO: This line of code loads data into the 'quizMeetDataSet.Quizzers' table. You can move, or remove it, as needed.
            this.quizzersTableAdapter.FillByAllWithChurchName(this.quizMeetDataSet.Quizzers);
        }

        private void QuizzersForm_Load(object sender, EventArgs e)
        {
            LoadTable(); //Load data into table.
        }

        private void EditIndividuallyButton_Click(object sender, EventArgs e)
        {
            OpenIndividualQuizzersForm(quizzersBindingSource.Position); //Open Individual Quizzers score.
        }

        private void OpenIndividualQuizzersForm(int position)
        {
            //Save changes to database.
            SaveAllChanges();

            //Display IndividualQuizzers form.
            IndividualQuizzersForm editIndividualQuizzersForm = new IndividualQuizzersForm(position); //Create new IndividualQuizzersForm.
            editIndividualQuizzersForm.ShowDialog(); //Display IndividualQuizzersForm.

            //Reload table.
            LoadTable();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void QuizzersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        //Event handler for binding navigator Add New Item button's Click event.
        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            OpenIndividualQuizzersForm(-1); //Open Individual Quizzers form to new item.
        }
    }
}
