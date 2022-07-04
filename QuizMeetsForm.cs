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
    public partial class QuizMeetsForm : Form
    {
        public QuizMeetsForm()
        {
            InitializeComponent();
        }

        //Helper method to load data into table.
        private void LoadTable()
        {
            // TODO: This line of code loads data into the 'quizMeetDataSet.QuizMeets' table. You can move, or remove it, as needed.
            this.quizMeetsTableAdapter.FillByAllWithHostChurchName(this.quizMeetDataSet.QuizMeets);
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

        //Event handler for BindingNavigator Save Item button's Click event.
        private void QuizMeetsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveAllChanges(); //Save changes to database.
        }

        //When form loads, load data into table.
        private void QuizMeetsForm_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        //Event handler for Exit button's Click event.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close form.
        }

        //Event handler for Edit Individually button's Click event.
        private void EditIndividuallyButton_Click(object sender, EventArgs e)
        {
            OpenIndividualQuizMeetsForm(quizMeetsBindingSource.Position); //Open individual quiz meets form to current position.
        }

        //Helper method to open individual quiz meets form to specific position.
        private void OpenIndividualQuizMeetsForm(int position)
        {
            //Save changes to database.
            SaveAllChanges();

            //Display IndividualQuizMeetsForm.
            IndividualQuizMeetsForm editIndividualQuizMeetsForm = new IndividualQuizMeetsForm(position); //Create new IndividualQuizMeetsForm.
            editIndividualQuizMeetsForm.ShowDialog(); //Display IndividualQuizMeetsForm.

            //Reload table when IndividualQuizMeetsForm closed.
            LoadTable();
        }

        //When form is closing
        private void QuizMeetsForm_FormClosing(object sender, FormClosingEventArgs e)
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
        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            OpenIndividualQuizMeetsForm(-1); //Open individal quiz meets form to new quizzer.
        }
    }
}
