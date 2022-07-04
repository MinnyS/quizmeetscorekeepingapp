using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMeetScorekeeper
{
    public partial class MainForm : Form
    {

        public const string APP_NAME = "Quiz Meet Scorekeeper"; //Name of app

        public MainForm()
        {
            InitializeComponent();
        }
        
        #region Event handlers and associated helper methods

        //Event handler for Edit --> Churches menu strip item's Click event.
        private void ChurchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display ChurchesForm.
            ChurchesForm editChurchesForm = new ChurchesForm(); //Create new ChurchesForm.
            editChurchesForm.ShowDialog(); //Display ChurchesForm.
        }

        //Event handler for File --> Exit menu strip item's Click event.
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //Close form.
        }

        private void CreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display credits.
            MessageBox.Show(
                "Bible quizzing images obtained from The Foundry Publishing:\n" +
                "https://www.thefoundrypublishing.com/childrens-quizzing-free-resources.html" +
                "\n\n" +
                "App created, designed, and coded by Heather Sullivan.",
                APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        private void QuizzersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display QuizzersForm.
            QuizzersForm editQuizzersForm = new QuizzersForm(); //Create new QuizzersForm.
            editQuizzersForm.ShowDialog(); //Display QuizzersForm.
        }

        private void TeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayTeamsForm(); //Display teams form.
        }

        private void QuizMeetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display QuizMeetsForm.
            QuizMeetsForm editQuizMeetsForm = new QuizMeetsForm(); //Create new QuizMeetsForm.
            editQuizMeetsForm.ShowDialog(); //Display QuizMeetsForm.
        }

        //Event handler for Edit --> Quizzer Scores menu item's Click event.
        private void QuizzerScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayQuizzerScoresForm(); //Display quizzer scores form.
        }

        //Event handler for Calculate --> Quizzer Scores menu item's Click event.
        private void CalculateQuizzerScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayQuizzerScoresForm(); //Display quizzer scores form.
        }

        //Helper method to display quizzer scores form.
        private void DisplayQuizzerScoresForm()
        {
            //Display QuizzerScoresForm.
            QuizzerScoresForm editQuizzerScoreForm = new QuizzerScoresForm();
            editQuizzerScoreForm.ShowDialog();
        }

        private void DisplayTeamsForm()
        {
            //Display TeamsForm.
            TeamsForm editTeamsForm = new TeamsForm(); //Create new TeamsForm.
            editTeamsForm.ShowDialog(); //Display TeamsForm.
        }

        private void CalculateTeamScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayTeamsForm(); //Display teams form.
        }

        #endregion

        #region Database and calculation helper methods
        
        //Helper method to return list of specific column's values in all rows in specific table.
        public static List<T> GetValuesFromColumnInTable<T>(DataTable dataTable, string columnName)
        {
            //Declare and initialize empty list to store values from table column.
            List<T> list = new List<T>();

            //Add values from table column to list.
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(row.Field<T>(columnName));
            }

            //Return list.
            return list;
        }

        //Helper method to return list of specific column's values in all rows in specific table; first item in list is parameter text.
        public static List<string> GetListOfValuesFromColumnInTablePrecededByItem(DataTable dataTable, string columnName, string firstListItemValue)
        {
            //Create list and add custom list item.
            List<string> list = new List<string>(); //Declare empty list.
            list.Add(firstListItemValue); //Add custom list item.

            //Add values from column in table to list.
            list.AddRange(
                    MainForm.GetValuesFromColumnInTable<string>(dataTable, columnName)
            );

            //Return list.
            return list;
        }

        //Helper method which returns values in specific column for rows whose teamID equals parameter teamID.
        public static List<T> GetValuesFromColumnInTableWhereFieldMatches<T>(int valueToMatch, string columnToMatch, string columnToRetrieve, DataTable dataTable)
        {
            //Declare list variable.
            List<T> list;

            //Query datatable.
            var query = from DataRow row in dataTable.Rows
                        where row.Field<int>(columnToMatch) == valueToMatch
                        select row.Field<T>(columnToRetrieve);

            //Convert query to list.
            list = query.ToList();

            //Return list.
            return list;
        }

        //Helper method to calculate and return sum of array elements
        public static int CalculateSumOfArrayElements(int[] array)
        {
            //Declare and initialize accumulator variable to store sum of array elements.
            int sum = 0;

            //Sum elements in array.
            for (int i = 0; i < array.Length; ++i)
            {
                sum += array[i];
            }

            //Return sum of elements in array.
            return sum;
        }

        //Helper method to convert string ID to int.
        public static int ConvertStringIDToInt(string id)
        {
            int idNumber; //Declare variable to store id number.

            //Attempt to convert id string to int.
            try
            {
                idNumber = int.Parse(id);
            }
            catch (Exception)
            {
                idNumber = -1;
            }

            return idNumber;
        }

        //Return value in specified column for row whose primary key matches parameter.
        public static T ReturnColumnValueByPrimaryKey<T>(DataTable dataTable, int primaryKey, string columnName)
        {
            //Use LINQ to find value in columnName field of row whose primary key matches idNumber
            var query = from DataRow row in dataTable.Rows
                        where row.Field<int>(dataTable.PrimaryKey[0]) == primaryKey
                        select row.Field<T>(columnName);

            List<T> list = query.ToList(); //Convert query results to list.

            return list[0]; //Return first query result.
        }

        //Helper method to return primary key of table row whose column value is ComboBox selection.
        public static int ReturnPrimaryKeyFromRowWithComboBoxSelection(ComboBox comboBox, DataTable dataTable, string columnName)
        {
            //If an element is selected
            if (comboBox.SelectedIndex != -1)
            {
                //Use LINQ to find primary key for row which contains ComboBox selection in specific column.
                var query = from DataRow row in dataTable.Rows
                            where row.Field<string>(columnName) == comboBox.SelectedItem.ToString()
                            select row.Field<int>(dataTable.PrimaryKey[0]);

                List<int> list = query.ToList(); //Convert query results to list.

                return list[0]; //Return first item in list.

            }
            else //if no element is selected
            {
                return -1;
            }
        }

        #endregion

        #region Output to file methods
        
        //Helper method to export data table as CSV file.
        public static void ExportDataTableAsCSVFile(DataTable dataTable, string fileName)
        {
            //If file does exist
            if (File.Exists(fileName))
            {
                File.Delete(fileName); //Delete file.
            }

            try
            {
                using (StreamWriter streamWriter = File.CreateText(fileName))
                {
                    //Write column names to file.
                    WriteColumnNamesToCSVFile(dataTable, streamWriter);

                    //Add line break.
                    streamWriter.WriteLine();

                    //Write rows to file.
                    WriteAllRowsToCSVFile(dataTable, streamWriter);
                }
            }
            catch (Exception ex)
            {
                DisplayExceptionErrorMessage(ex);
            }


        }

        //Helper method to write column names to CSV file.
        public static void WriteColumnNamesToCSVFile(DataTable dataTable, StreamWriter streamWriter)
        {
            //If there are multiple columns in data table
            if (dataTable.Columns.Count > 1)
            {
                //Write all column names except very last.
                for (int columnIndex = 1; columnIndex < dataTable.Columns.Count - 1; ++columnIndex)
                {
                    streamWriter.Write(dataTable.Columns[columnIndex].ColumnName + ", ");
                }

                //Write last column name.
                streamWriter.Write(dataTable.Columns[dataTable.Columns.Count - 1].ColumnName);
            }
            else if (dataTable.Columns.Count == 1) //if there is only 1 column in data table
            {
                //Write only column name to file.
                streamWriter.Write(dataTable.Columns[0].ColumnName);
            }
        }

        //Helper method to write all rows' data to CSV file.
        public static void WriteAllRowsToCSVFile(DataTable dataTable, StreamWriter streamWriter)
        {
            //If there are multiple rows in data table
            if (dataTable.Rows.Count > 1)
            {
                //For each row except last row
                for (int rowPosition = 0; rowPosition < dataTable.Rows.Count - 1; ++rowPosition)
                {
                    WriteSingleRowFieldValuesToCSVFile(rowPosition, dataTable, streamWriter); //Write row field values to file.
                    streamWriter.WriteLine(); //Write new line. 
                }

                //Write row field values for last row.
                WriteSingleRowFieldValuesToCSVFile(dataTable.Rows.Count - 1, dataTable, streamWriter);
            }
            else if (dataTable.Rows.Count == 1) //if there is only 1 row in data table
            {
                //Write single row's field values to file.
                WriteSingleRowFieldValuesToCSVFile(0, dataTable, streamWriter);
            }
        }

        //Helper method to write all of a specific row's field values to CSV file.
        public static void WriteSingleRowFieldValuesToCSVFile(int rowPosition, DataTable dataTable, StreamWriter streamWriter)
        {
            //If there are multiple columns in data table
            if (dataTable.Columns.Count > 1)
            {
                //Write row's column values except very last.
                for (int columnIndex = 1; columnIndex < dataTable.Columns.Count - 1; ++columnIndex)
                {
                    WriteSingleDataRowSingleFieldValueToCSVFile(rowPosition, columnIndex, dataTable, streamWriter);
                }

                //Write last column's field value.
                WriteSingleDataRowSingleFieldValueToCSVFile(rowPosition, dataTable.Columns.Count - 1, dataTable, streamWriter);
            }
            else if (dataTable.Columns.Count == 1) //if there is only 1 column in data table
            {
                //Write row's only column value to file.
                WriteSingleDataRowSingleFieldValueToCSVFile(rowPosition, 0, dataTable, streamWriter);
            }
        }

        //Helper method to write a specific row's specific column's field value to CSV file.
        public static void WriteSingleDataRowSingleFieldValueToCSVFile(int rowPosition, int columnIndex, DataTable dataTable, StreamWriter streamWriter)
        {
            //Set variable to data value in specific column in specific data row.
            Object dataValue = dataTable.Rows[rowPosition].Field<Object>(dataTable.Columns[columnIndex].ColumnName);
            
            //If data value is not null
            if(dataValue != null)
            {
                streamWriter.Write(dataValue.ToString() + ", "); //Write data value to file and prepare for next value.
            }
            else //if data value is null
            {
                streamWriter.Write(", "); //Prepare for next value.
            }
        }

        #endregion

        #region Other helper methods

        //Public helper method to display error message with OK button.
        public static void DisplayErrorMessageWithOKButton(string message)
        {
            MessageBox.Show(message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Helper method to display exception error message.
        public static void DisplayExceptionErrorMessage(Exception ex)
        {
            MainForm.DisplayErrorMessageWithOKButton("An error has occurred!\n" + ex.Message + "\n" + ex.StackTrace);
        }

        //Helper method to set NumericUpDown control's value and text.
        public static void SetNumericUpDownValueAndText(NumericUpDown numericUpDown, int value)
        {
            numericUpDown.Value = value; //Set NumericUpDown control's value to parameter.
            numericUpDown.Text = value.ToString(); //Set NumericUpDown control's text to value.
        }

        //Helper method to set all data bound NumericUpDown controls to value.
        public static void SetAllDataBoundNumericUpDownControls(int value, NumericUpDown[] dataBoundNumericUpDownControls)
        {
            //Set each data bound NumericUpDown's value and text to 0.
            foreach (NumericUpDown dataBoundNumericUpDown in dataBoundNumericUpDownControls)
            {
                MainForm.SetNumericUpDownValueAndText(dataBoundNumericUpDown, 0);
            }
        }


        //Method to update ComboBox selection based on DataTable, column name, and row primary key.
        public static void UpdateComboBoxSelection(string id, ComboBox comboBox, DataTable dataTable, string columnName)
        {

            int idNumber = ConvertStringIDToInt(id); //Declare and initialize variable to id number.

            //If id number is not negative
            if (idNumber >= 0)
            {
                try
                {
                    //Set ComboBox's selection to value of field in specified column of row with specified id in specified table.
                    comboBox.SelectedItem = ReturnColumnValueByPrimaryKey<string>(dataTable, idNumber, columnName);
                }
                catch (Exception ex)
                {
                    comboBox.SelectedIndex = -1; //Deselect items.
                    DisplayExceptionErrorMessage(ex); //Display error message.
                }
            }
            else //if id number is negative
            {
                comboBox.SelectedIndex = -1; //Deselect any ComboBox selection.
            }
        }

        #endregion

    }
}
