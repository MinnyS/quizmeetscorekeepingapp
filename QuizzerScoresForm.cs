using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMeetScorekeeper
{
    public partial class QuizzerScoresForm : Form
    {
        //Declare class variables.
        public string QUIZZER_SCORES_CSV_FILE_NAME = @"\QuizzerScores.csv"; //Variable to store name of file to which quizzer scores data will be outputted.
        private string currentQuizLevel = Quiz.ALL_QUIZ_LEVELS; //Variable to store level user wants to view.

        //Declare arrays to store menu items.
        private ToolStripMenuItem[] displayFromQuizLevelMenuItems; //Array to store menu items to display records from specific quiz level.

        //Class constructor.
        public QuizzerScoresForm()
        {
            //Initialize components.
            InitializeComponent();
        }

        //Helper method to load data into table.
        private void LoadTable()
        {
            this.quizzerScoresTableAdapter.FillByQuizLevel(this.quizMeetDataSet.QuizzerScores, currentQuizLevel);
        }

        //Helper method to load table for CSV file export.
        private void LoadTableForCSVFileExport()
        {
            this.quizzerScoresTableAdapter.FillByExportFileInfo(this.quizMeetDataSet.QuizzerScores, currentQuizLevel);
        }

        //Helper method to save all changes to database.
        private void SaveAllChanges()
        {
            try
            {
                this.Validate();
                this.quizzerScoresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.quizMeetDataSet);
            }
            catch (Exception e)
            {
                //Display error message.
                MainForm.DisplayExceptionErrorMessage(e);
            }
        }

        //Event handler for Save Item's Click event.
        private void QuizzerScoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveAllChanges(); //Save changes to database.
            LoadTable(); //Reload table.
        }

        //Event handler for form's Load event.
        private void QuizzerScoresForm_Load(object sender, EventArgs e)
        {
            //Load data into table.
            LoadTable();

            //Populate calculation method ComboBox's options.
            calculationMethodComboBox.DataSource = Quiz.GetUniversalQuizzerScoresCalculationMethodsArray();

            //Initialize variable to array of menu items for selecting quiz level.
            displayFromQuizLevelMenuItems = new ToolStripMenuItem[]
            {
                levelBothLevelsToolStripMenuItem,
                levelRedToolStripMenuItem,
                levelBlueToolStripMenuItem
            };
        }

        //Event handler for form's FormClosing event.
        private void QuizzerScoresForm_FormClosing(object sender, FormClosingEventArgs e)
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

        //Event handler for Exit button's Click event.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close form.
        }

        //Event handler for Edit Individually button's Click event.
        private void EditIndividuallyButton_Click(object sender, EventArgs e)
        {
            //Open individual quizzer scores form to currently selected quizzer score entry.
            OpenIndividualQuizzerScoresForm(quizzerScoresBindingSource.Position);
        }

        #region Calculate Quizzer Scores

        //Event handler for Calculate Scores button's Click event.
        private void CalculateQuizzerScoresButton_Click(object sender, EventArgs e)
        {
            //Declare variable to store calculation method.
            string calculationMethod;
            
            //If calculation method not selected
            if (calculationMethodComboBox.SelectedIndex == -1)
            {
                MainForm.DisplayErrorMessageWithOKButton("Please select a calculation method."); //Display error message.
                calculationMethodComboBox.Focus(); //Send focus to calculation method input field.
                return; //Exit method.
            }

            //Initialize variable to calculation method ComboBox's selection.
            calculationMethod = calculationMethodComboBox.SelectedItem.ToString();

            //Calculate scores
            if (calculationMethod == Quiz.NUMBER_QUESTIONS_CORRECT_METHOD)
            {
                CalculateByQuestionsCorrect(); //Calculate scores based on number of questions correct.
            }
            else if(calculationMethod == Quiz.NUMBER_POINTS_METHOD)
            {
                CalculateByNumberPoints(); //Calculate scores based on number of points.
            }
            else //if calculation method is invalid
            {
                //Display error message.
                MainForm.DisplayErrorMessageWithOKButton("You selected an invalid score calculation method.");

                //Send focus to score calculation method input field.
                calculationMethodComboBox.Focus();

                return; //Exit method.
            }
        }

        //Helper method to calculate score information based on number of questions correct.
        private void CalculateByQuestionsCorrect()
        {
            //Declare variables.
            string quizLevel; //Variable to store quiz level.
            int pointsPerQuestion; //Variable to store points for each question.
            int[] questionsAnsweredCorrectlyPerRound = new int[2]; //Variable to store array of number of questions answered correctly in each round.
            int[] totalQuestionsPerRound; //Variable to store array of total questions per round.
            
            //For each row in QuizzerScores table
            for (int i = 0; i < this.quizMeetDataSet.QuizzerScores.Rows.Count; ++i)
            {
                //Attempt to set variables based on quiz level.
                try
                {
                    SetVariablesBasedOnQuizLevel(i, out quizLevel, out pointsPerQuestion, out totalQuestionsPerRound);
                }
                catch(Exception e)
                {
                    MainForm.DisplayErrorMessageWithOKButton(e.Message); //Display error message.
                    quizzerScoresBindingSource.Position = i; //Send focus to problematic row.
                    return; //Exit loop.
                }

                //Attempt to obtain number of questions answered correctly in round 1.
                try
                {
                    questionsAnsweredCorrectlyPerRound[0] = this.quizMeetDataSet.QuizzerScores.Rows[i].Field<int>(Quiz.ROUND_1_NUM_CORRECT);
                }
                catch (Exception)
                {
                    MainForm.DisplayErrorMessageWithOKButton("Please entered the number of questions answered correctly in round 1 for the quizzer score entry on row " + (i + 1).ToString() + "."); //Display error message.
                    quizzerScoresBindingSource.Position = i; //Send focus to problematic row.
                    return; //Exit loop.
                }

                //Attempt to obtain number of questions answered correctly in round 2.
                try
                {
                    questionsAnsweredCorrectlyPerRound[1] = this.quizMeetDataSet.QuizzerScores.Rows[i].Field<int>(Quiz.ROUND_2_NUM_CORRECT);
                }
                catch (Exception)
                {
                    MainForm.DisplayErrorMessageWithOKButton("Please entered the number of questions answered correctly in round 2 for the quizzer score entry on row " + (i + 1).ToString() + "."); //Display error message.
                    quizzerScoresBindingSource.Position = i; //Send focus to problematic row.
                    return; //Exit loop.
                }

                //If number of questions answered correctly in round 1 exceeds total number of questions in round 1
                if (questionsAnsweredCorrectlyPerRound[0] > totalQuestionsPerRound[0])
                {
                    MainForm.DisplayErrorMessageWithOKButton("The number of questions answered correctly in Round 1 on row " + (i + 1).ToString() + " may not exceed the total number of questions in Round 1 (" + totalQuestionsPerRound[0] + ").");
                    quizzerScoresBindingSource.Position = i; //Send focus to problematic row.
                    return; //Exit loop.
                }

                //If number of questions answered correctly in round 2 exceeds total number of questions in round 2
                if (questionsAnsweredCorrectlyPerRound[1] > totalQuestionsPerRound[1])
                {
                    MainForm.DisplayErrorMessageWithOKButton("The number of questions answered correctly in Round 2 on row " + (i + 1).ToString() + " may not exceed the total number of questions in Round 2 (" + totalQuestionsPerRound[1] + ").");
                    quizzerScoresBindingSource.Position = i; //Send focus to problematic row.
                    return; //Exit loop.
                }

                //Set number of points in each round fields.
                this.quizMeetDataSet.QuizzerScores.Rows[i].SetField<int>(Quiz.ROUND_1_POINTS, pointsPerQuestion * questionsAnsweredCorrectlyPerRound[0]);
                this.quizMeetDataSet.QuizzerScores.Rows[i].SetField<int>(Quiz.ROUND_2_POINTS, pointsPerQuestion * questionsAnsweredCorrectlyPerRound[1]);

                //Calculate and set fields for perfect rounds, percent correct, and score level.
                CalculatePerfectRoundsAndPercentCorrectAndScoreLevel(i, questionsAnsweredCorrectlyPerRound, totalQuestionsPerRound);
            }

            //Save changes and load table.
            SaveAllChanges(); //Save changes to database.
            LoadTable(); //Load table.
        }

        //Helper method to calculate score information based on number of questions correct.
        private void CalculateByNumberPoints()
        {
            //Declare variables.
            string quizLevel; //Variable to store quiz level.
            int pointsPerQuestion; //Variable to store points for each question.
            int[] pointsPerRound = new int[2]; //Array to store points per round.
            int[] questionsAnsweredCorrectlyPerRound = new int[pointsPerRound.Length]; //Variable to store array of number of questions answered correctly in each round.
            int[] totalQuestionsPerRound; //Variable to store array of total questions per round.

            //For each row in QuizzerScores table
            for (int rowIndex = 0; rowIndex < this.quizMeetDataSet.QuizzerScores.Rows.Count; ++rowIndex)
            {
                //Attempt to set variables based on quiz level.
                try
                {
                    SetVariablesBasedOnQuizLevel(rowIndex, out quizLevel, out pointsPerQuestion, out totalQuestionsPerRound);
                }
                catch (Exception e)
                {
                    MainForm.DisplayErrorMessageWithOKButton(e.Message); //Display error message.
                    quizzerScoresBindingSource.Position = rowIndex; //Send focus to problematic row.
                    return; //Exit loop.
                }

                //Attempt to obtain number of points in round 1.
                try
                {
                    pointsPerRound[0] = this.quizMeetDataSet.QuizzerScores.Rows[rowIndex].Field<int>(Quiz.ROUND_1_POINTS);
                }
                catch (Exception)
                {
                    MainForm.DisplayErrorMessageWithOKButton("Please entered the number of points scored in round 1 for the quizzer score entry on row " + (rowIndex + 1).ToString() + "."); //Display error message.
                    quizzerScoresBindingSource.Position = rowIndex; //Send focus to problematic row.
                    return; //Exit loop.
                }

                //Attempt to obtain number of points round 2.
                try
                {
                    pointsPerRound[1] = this.quizMeetDataSet.QuizzerScores.Rows[rowIndex].Field<int>(Quiz.ROUND_2_POINTS);
                }
                catch (Exception)
                {
                    MainForm.DisplayErrorMessageWithOKButton("Please entered the number of points scored in round 2 for the quizzer score entry on row " + (rowIndex + 1).ToString() + "."); //Display error message.
                    quizzerScoresBindingSource.Position = rowIndex; //Send focus to problematic row.
                    return; //Exit loop.
                }

                //If number of points scored in round 1 exceeds the total number of points possible in round 1
                if (pointsPerRound[0] > totalQuestionsPerRound[0] * pointsPerQuestion)
                {
                    MainForm.DisplayErrorMessageWithOKButton("The number of points scored in Round 1 on row " + (rowIndex + 1).ToString() + " may not exceed the total number of points possible in Round 1 (" + (totalQuestionsPerRound[0] * pointsPerQuestion).ToString() + ").");
                    quizzerScoresBindingSource.Position = rowIndex; //Send focus to problematic row.
                    return; //Exit loop.
                }

                //If number of points scored in round 2 exceeds total number of points possible in round 2
                if (pointsPerRound[1] > totalQuestionsPerRound[1] * pointsPerQuestion)
                {
                    MainForm.DisplayErrorMessageWithOKButton("The number of points scored in Round 2 on row " + (rowIndex + 1).ToString() + " may not exceed the total number of points possible in Round 2 (" + (totalQuestionsPerRound[1] * pointsPerQuestion).ToString() + ").");
                    quizzerScoresBindingSource.Position = rowIndex; //Send focus to problematic row.
                    return; //Exit loop.
                }

                //Calculate and store number of questions answered correctly per round. 
                for (int roundIndex = 0; roundIndex < pointsPerRound.Length; ++roundIndex)
                {
                    questionsAnsweredCorrectlyPerRound[roundIndex] = pointsPerRound[roundIndex] / pointsPerQuestion;
                }

                //Set values of Questions Answered Correctly Per Round fields.
                this.quizMeetDataSet.QuizzerScores.Rows[rowIndex].SetField<int>(Quiz.ROUND_1_NUM_CORRECT, questionsAnsweredCorrectlyPerRound[0]);
                this.quizMeetDataSet.QuizzerScores.Rows[rowIndex].SetField<int>(Quiz.ROUND_2_NUM_CORRECT, questionsAnsweredCorrectlyPerRound[1]);

                //Calculate and set perfect rounds, percent correct, and score level.
                CalculatePerfectRoundsAndPercentCorrectAndScoreLevel(rowIndex, questionsAnsweredCorrectlyPerRound, totalQuestionsPerRound);
            }

        }

        //Method to set variables (quiz level, points per question, and total questions per round array) based on quiz level.
        private void SetVariablesBasedOnQuizLevel(int dataRowPosition, out string quizLevel, out int pointsPerQuestion, out int[] totalQuestionsPerRound)
        {
            //Set quiz level variable to quizzer's quiz level.
            quizLevel = this.quizMeetDataSet.QuizzerScores.Rows[dataRowPosition].Field<string>(Quiz.QUIZZER_QUIZ_LEVEL);
            
            //Initialize total questions per round array to 2-element array.
            totalQuestionsPerRound = new int[2];

            //Set points per question variable and total questions per round array based on quiz level.
            if (quizLevel == Quiz.RED_LEVEL)
            {
                pointsPerQuestion = this.quizMeetDataSet.QuizzerScores.Rows[dataRowPosition].Field<int>(Quiz.RED_QUESTION_POINTS);
                totalQuestionsPerRound[0] = this.quizMeetDataSet.QuizzerScores.Rows[dataRowPosition].Field<int>(Quiz.RED_ROUND_1_TOTAL_QUESTIONS);
                totalQuestionsPerRound[1] = this.quizMeetDataSet.QuizzerScores.Rows[dataRowPosition].Field<int>(Quiz.RED_ROUND_2_TOTAL_QUESTIONS);
            }
            else if (quizLevel == Quiz.BLUE_LEVEL)
            {
                pointsPerQuestion = this.quizMeetDataSet.QuizzerScores.Rows[dataRowPosition].Field<int>(Quiz.BLUE_QUESTION_POINTS);
                totalQuestionsPerRound[0] = this.quizMeetDataSet.QuizzerScores.Rows[dataRowPosition].Field<int>(Quiz.BLUE_ROUND_1_TOTAL_QUESTIONS);
                totalQuestionsPerRound[1] = this.quizMeetDataSet.QuizzerScores.Rows[dataRowPosition].Field<int>(Quiz.BLUE_ROUND_2_TOTAL_QUESTIONS);
            }
            else //if quiz level is invalid, throw exception
            {
                throw new NotSupportedException("Quiz level equals " + quizLevel + ".  \nQuiz level must equal " + Quiz.RED_LEVEL + " or " + Quiz.BLUE_LEVEL + ".");
            }
        }

        //Method to calculate and set fields for perfect rounds, percent correct, and score level.
        private void CalculatePerfectRoundsAndPercentCorrectAndScoreLevel(int dataRowPosition, int[] questionsAnsweredCorrectlyPerRound, int[] totalQuestionsPerRound)
        {
            //Declare variables.
            decimal percentCorrect; //Variable to store percent correct.
            int perfectRounds; //Variable to store number of perfect rounds.

            //Initialize variable to number of perfect rounds.
            perfectRounds = Quiz.CalculateNumberOfPerfectRounds(questionsAnsweredCorrectlyPerRound, totalQuestionsPerRound);

            //Set number of perfect rounds field.
            this.quizMeetDataSet.QuizzerScores.Rows[dataRowPosition].SetField<int>(Quiz.PERFECT_ROUNDS, perfectRounds);

            //Initialize variable to percent correct.
            percentCorrect = Quiz.CalculatePercentCorrect(questionsAnsweredCorrectlyPerRound, totalQuestionsPerRound);

            //Set percent correct field.
            this.quizMeetDataSet.QuizzerScores.Rows[dataRowPosition].SetField<decimal>(Quiz.PERCENT_CORRECT, percentCorrect);

            //Set score level field.
            this.quizMeetDataSet.QuizzerScores.Rows[dataRowPosition].SetField<string>(Quiz.SCORE_LEVEL, Quiz.CalculateScoreLevel(percentCorrect, perfectRounds));
        }

        #endregion

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            OpenIndividualQuizzerScoresForm(-1); //Open individual quizzer scores form, indicating new item should be added.
        }

        //Helper method to open individual quizzer scores form.
        private void OpenIndividualQuizzerScoresForm(int quizzerID)
        {
            //Save all changes to database.
            SaveAllChanges();
 
            //Display IndividualQuizzerScoresForm.
            IndividualQuizzerScoresForm editIndividualQuizzerScoresForm = new IndividualQuizzerScoresForm(quizzerID); //Create new IndividualQuizzerScoresForm.
            editIndividualQuizzerScoresForm.ShowDialog(); //Display IndividualQuizzerScoresForm.

            //Reload table.
            LoadTable();
        }

        //Event handler for Generate CSV File button's Click event.
        private void GenerateCSVFileButton_Click(object sender, EventArgs e)
        {
            GenerateQuizzerScoresCSVFile(); //Generate quizzer scores CSV file.
        }

        //Private method to generate and open quizzer scores CSV file.
        private void GenerateQuizzerScoresCSVFile()
        {
            //Save information.
            SaveAllChanges(); //Save all changes to database.

            //Load table with special query omitting unnecessary data.
            LoadTableForCSVFileExport(); //Load table for CSV file export.

            //Export data table as CSV file.
            MainForm.ExportDataTableAsCSVFile(this.quizMeetDataSet.QuizzerScores, QUIZZER_SCORES_CSV_FILE_NAME);
            Process.Start(QUIZZER_SCORES_CSV_FILE_NAME); //Open file.

            //Load table with regular quizzer scores query.
            LoadTable();
        }

        #region Random tool strip menu items' event handlers

        //Event handler for File --> Exit menu item's Click event.
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //Close form.
        }

        //Event handler for File --> Generate CSV File menu item's Click event.
        private void GenerateCSVFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateQuizzerScoresCSVFile(); //Generate quizzer scores CSV file.
        }

        //Event handler for Edit --> Edit Individually menu item's Click event.
        private void EditIndividuallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open individual quizzer scores form to quizzer score entry at current position.
            OpenIndividualQuizzerScoresForm(quizzerScoresBindingSource.Position);
        }

        //Event handler for Edit --> Add Quizzer Score menu item's Click event.
        private void AddQuizzerScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenIndividualQuizzerScoresForm(-1); //Open individual quizzer scores form, indicating new item should be added.
        }

        //Event handler for Calculate --> Questions Correct menu item's Click event.
        private void CalculateQuestionsCorrectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateByQuestionsCorrect(); //Calculate scores based on number of questions correct.
        }

        //Event handler for Calculate --> Number of Points menu item's Click event.
        private void CalculateNumberOfPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateByNumberPoints(); //Calculate scores based on number of points.
        }

        //Helper method to select specific tool strip menu item and deselect other tool strip menu items.
        private void CheckAndUncheckToolStripMenuItems(ToolStripMenuItem selectedMenuItem, ToolStripMenuItem[] allToolStripMenuItems)
        {
            //Deselect other level menu items.
            foreach (ToolStripMenuItem currentMenuItem in displayFromQuizLevelMenuItems)
            {
                //If current menu item is not menu item selected
                if (currentMenuItem != selectedMenuItem)
                {
                    currentMenuItem.Checked = false; //Uncheck current menu item.
                }
                else //if current menu item is menu item selected
                {
                    currentMenuItem.Checked = true; //Check current menu item.
                }
            }
        }

        #endregion

        #region Display Records for Quiz Level

        //Helper method to select menu item, set current level variable, and load table when level menu item clicked.
        private void QuizLevelToolStripMenuItemClicked(ToolStripMenuItem selectedMenuItem, string quizLevel)
        {
            CheckAndUncheckToolStripMenuItems(selectedMenuItem, displayFromQuizLevelMenuItems); //Check selected menu item and uncheck other menu items.
            currentQuizLevel = quizLevel; //Set current level variable.
            LoadTable(); //Load table.
        }

        //Event handler for Level --> Red Level menu item's Click event.
        private void LevelRedToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            QuizLevelToolStripMenuItemClicked(levelRedToolStripMenuItem, Quiz.RED_LEVEL);
        }

        //Event handler for Level --> Blue Level menu item's Click event.
        private void LevelBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuizLevelToolStripMenuItemClicked(levelBlueToolStripMenuItem, Quiz.BLUE_LEVEL);
        }

        //Event handler for Level --> Both Levels menu item's Click event.
        private void LevelBothLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuizLevelToolStripMenuItemClicked(levelBothLevelsToolStripMenuItem, Quiz.ALL_QUIZ_LEVELS);
        }

        #endregion

        #region Score Level Counts

        //Helper method to display number of quizzers who scored specific score level.
        private void DisplayScoreLevelCount(string scoreLevel, int count)
        {
            //Declare and initialize variable to store message to show.
            string message = "Number of ";

            //If current quiz level is not all quiz levels
            if (currentQuizLevel != Quiz.ALL_QUIZ_LEVELS)
            {
                message += currentQuizLevel + " "; //Add current quiz level to message.
            }

            //Add count to message.
            message += String.Format("quizzers who scored {0}:\n{1}", scoreLevel, count.ToString());

            //Display message.
            MessageBox.Show(
                message,
                MainForm.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        //Event handler for Count --> Bronze menu item's Click event.
        private void CountBronzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display number of quizzers in this level who scored Bronze.
            DisplayScoreLevelCount(
                Quiz.BRONZE,
                (int) quizzerScoresTableAdapter.CountScoreLevelExactly(Quiz.BRONZE, currentQuizLevel)
            );
        }

        //Event handler for Count --> Bronze menu item's Click event.
        private void CountSilverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display number of quizzers in this level who scored Silver.
            DisplayScoreLevelCount(
                Quiz.SILVER,
                (int) quizzerScoresTableAdapter.CountScoreLevelExactly(Quiz.SILVER, currentQuizLevel)
            );
        }

        //Event handler for Count --> All Gold menu item's Click event.
        private void CountAllGoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display number of quizzers in this level who scored any kind of gold.
            DisplayScoreLevelCount(
                "any kind of gold",
                (int)quizzerScoresTableAdapter.CountScoreLevelUsingLike(Quiz.GOLD, currentQuizLevel)
            );
        }

        //Event handler for Count --> Gold menu item's Click event.
        private void CountGoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display number of quizzers in this level who scored Silver.
            DisplayScoreLevelCount(
                Quiz.GOLD,
                (int)quizzerScoresTableAdapter.CountScoreLevelExactly(Quiz.GOLD, currentQuizLevel)
            );
        }

        //Event handler for Count --> Gold with One Perfect Round menu item's Click event.
        private void CountGoldWithOnePerfectRoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display number of quizzers in this level who scored Gold with One Perfect Round.
            DisplayScoreLevelCount(
                Quiz.GOLD_ONE_PERFECT_ROUND,
                (int)quizzerScoresTableAdapter.CountScoreLevelExactly(Quiz.GOLD_ONE_PERFECT_ROUND, currentQuizLevel)
            );
        }

        //Event handler for Count --> Gold All-Star menu item's Click event.
        private void CountGoldAllStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display number of quizzers in this level who scored Gold All-Star.
            DisplayScoreLevelCount(
                Quiz.GOLD_ALL_STAR,
                (int)quizzerScoresTableAdapter.CountScoreLevelExactly(Quiz.GOLD_ALL_STAR, currentQuizLevel)
            );
        }

        //Event handler for Count --> Score Level menu item's Click event.
        private void CountScoreLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare and initialize variable to store message to display
            string message = "Number of ";

            //If current quiz level is not all quiz levels
            if(currentQuizLevel != Quiz.ALL_QUIZ_LEVELS)
            {
                message += currentQuizLevel + " "; //Add current quiz level to message.
            }

            //Finish adding header to message.
            message += "Quizzers Per Score Level\n";
            
            //Add bronze count.
            message += String.Format(
                "{0}: {1}\n",
                Quiz.BRONZE,
                quizzerScoresTableAdapter.CountScoreLevelExactly(Quiz.BRONZE, currentQuizLevel).ToString()
            );

            //Add silver count.
            message += String.Format(
                "{0}: {1}\n",
                Quiz.SILVER,
                quizzerScoresTableAdapter.CountScoreLevelExactly(Quiz.SILVER, currentQuizLevel).ToString()
            );

            //Add gold count.
            message += String.Format(
                "{0}: {1}\n",
                Quiz.GOLD,
                quizzerScoresTableAdapter.CountScoreLevelExactly(Quiz.GOLD, currentQuizLevel).ToString()
            );

            //Add gold with one perfect round count.
            message += String.Format(
                "{0}: {1}\n",
                Quiz.GOLD_ONE_PERFECT_ROUND,
                quizzerScoresTableAdapter.CountScoreLevelExactly(Quiz.GOLD_ONE_PERFECT_ROUND, currentQuizLevel).ToString()
            );

            //Add gold all-star count.
            message += String.Format(
                "{0}: {1}",
                Quiz.GOLD_ALL_STAR,
                quizzerScoresTableAdapter.CountScoreLevelExactly(Quiz.GOLD_ALL_STAR, currentQuizLevel).ToString()
            );

            //Display message.
            MessageBox.Show(message, MainForm.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
