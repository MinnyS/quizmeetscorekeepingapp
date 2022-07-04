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
    public partial class ChurchesForm : Form
    {
        public ChurchesForm()
        {
            InitializeComponent();
        }

        private void ChurchesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveAllChanges();
        }

        //Helper method to load data into table.
        private void LoadTable()
        {
            // TODO: This line of code loads data into the 'quizMeetDataSet.Churches' table. You can move, or remove it, as needed.
            this.churchesTableAdapter.Fill(this.quizMeetDataSet.Churches);
        }

        private void Churches_Load(object sender, EventArgs e)
        {
            LoadTable(); //Load data into table.
        }

        //Event handler for Exit button's Click event.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close form.
        }

        //Helper method to save all changes to database.
        private void SaveAllChanges()
        {
            try
            {
                this.Validate();
                this.churchesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.quizMeetDataSet);
            }
            catch (Exception e)
            {
                //Display error message.
                MainForm.DisplayExceptionErrorMessage(e);
            }
        }

        //When form is closing
        private void ChurchesForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void EditIndividuallyButton_Click(object sender, EventArgs e)
        {
            //Save changes to database.
            SaveAllChanges();

            //Display IndividualChurchesForm.
            IndividualChurchesForm editIndividualChurchesForm = new IndividualChurchesForm(); //Create new IndividualChurchesForm.
            editIndividualChurchesForm.ShowDialog(); //Display IndividualChurchesForm.
            
            //Reload table.
            LoadTable();
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
