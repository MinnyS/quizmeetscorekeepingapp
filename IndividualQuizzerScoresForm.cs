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
    public partial class IndividualQuizzerScoresForm : Form
    {

        //Declare arrays for bound NumericUpDown controls.
        private NumericUpDown[] dataBoundNumericUpDownControls; //Store data bound NumericUpDown controls.

        //Declare class variables.
        private int startBindingSourcePosition = 0; //Binding source position for start.
        bool dataBoundControlsLoaded = false; //Variable to store value indicating whether data bound controls are loaded.

        //No-argument constructor.
        public IndividualQuizzerScoresForm()
        {
            InitializeComponent();
            calculationMethodComboBox.DataSource = Quiz.GetAllQuizzerScoresCalculationMethodsArray(); //Populate calculation method input field.
        }

        //Single-argument constructor which first calls no-argument constructor.
        public IndividualQuizzerScoresForm(int position) : this()
        {
            startBindingSourcePosition = position; //Set start binding source position variable to parameter value.
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

        //Event handler for Exit button Click event.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close form.
        }

        //Event handler for Save Item button Click event.
        private void QuizzerScoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveAllChanges(); //Save changes to database.
        }

        //Event handler for form Load event.
        private void IndividualQuizzerScoresForm_Load(object sender, EventArgs e)
        {
            //Initialize variable to array of data bound NumericUpDown controls.
            dataBoundNumericUpDownControls = new NumericUpDown[]
            {
                round1NumberQuestionsCorrectNumericUpDown,
                round1PointsNumericUpDown,
                round2NumberQuestionsCorrectNumericUpDown,
                round2PointsNumericUpDown,
                perfectRoundsNumericUpDown
            };

            //Attempt to load data into tables.
            try
            {
                LoadTables();
            }
            catch(Exception ex)
            {
                MainForm.DisplayErrorMessageWithOKButton("An error has occurred!\n" + ex.Message);
            }

            //Populate data bound ComboBoxes.
            PopulateDataBoundComboBoxes();

            //Set binding source position to start binding source position.
            SetBindingSourcePosition(startBindingSourcePosition);
        }

        //Helper method to set binding source position.
        private void SetBindingSourcePosition(int position)
        {
            //If starting position is valid
            if (position > -1 && position < this.quizMeetDataSet.QuizzerScores.Rows.Count)
            {
                quizzerScoresBindingSource.Position = position; //Set position to starting position.
            }
            else if (position == -1) //if value is -1
            {
                quizzerScoresBindingSource.Position = -1; //Set binding source position so user is creating new entry.
                bindingNavigatorAddNewItem.PerformClick(); //Trigger New Item button's Click event.
                quizzerComboBox.SelectedIndex = -1; //Deselect quizzer name.
                quizMeetComboBox.SelectedIndex = -1; //Deselect quiz meet.
            }
        }

        //Helper method to populate data bound ComboBoxes.
        private void PopulateDataBoundComboBoxes()
        {
            //Attempt to populate team ComboBox.
            try
            {
                teamComboBox.DataSource = MainForm.GetListOfValuesFromColumnInTablePrecededByItem(this.quizMeetDataSet.Teams, Quiz.TEAM_NAME, Quiz.NO_TEAM);
            }
            catch (Exception)
            {
                MainForm.DisplayErrorMessageWithOKButton("Team names could not be accessed from the Teams table."); //Display error message.
            }
            
            //Attempt to set quizzer names ComboBox's data source
            try
            {
                quizzerComboBox.DataSource = MainForm.GetValuesFromColumnInTable<string>(this.quizMeetDataSet.Quizzers, Quiz.QUIZZER_FULL_NAME);
            } catch(Exception)
            {
                MainForm.DisplayErrorMessageWithOKButton("Quizzer names could not be accessed from the Quizzers table."); //Display error message.
            }

            //Attempt to set quiz meets ComboBox's data source.
            try
            {
                quizMeetComboBox.DataSource = MainForm.GetValuesFromColumnInTable<string>(this.quizMeetDataSet.QuizMeets, Quiz.QUIZ_MEET_NAME);
            }
            catch(Exception)
            {
                MainForm.DisplayErrorMessageWithOKButton("Quiz meet names could not be accessed from the Quiz Meets table."); //Display error message.
            }
        }

        //Helper method to load data into tables.
        private void LoadTables()
        {
            // TODO: This line of code loads data into the 'quizMeetDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.quizMeetDataSet.Teams);
            // TODO: This line of code loads data into the 'quizMeetDataSet.QuizMeets' table. You can move, or remove it, as needed.
            this.quizMeetsTableAdapter.Fill(this.quizMeetDataSet.QuizMeets);
            // TODO: This line of code loads data into the 'quizMeetDataSet.Quizzers' table. You can move, or remove it, as needed.
            this.quizzersTableAdapter.FillByAllWithFullName(this.quizMeetDataSet.Quizzers);
            // TODO: This line of code loads data into the 'quizMeetDataSet.QuizzerScores' table. You can move, or remove it, as needed.
            this.quizzerScoresTableAdapter.FillByAllInfo(this.quizMeetDataSet.QuizzerScores);
        }

        //Event handler for form's FormClosing event.
        private void IndividualQuizzerScoresForm_FormClosing(object sender, FormClosingEventArgs e)
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

        //Event handler for quizzer scores' BindingSource PositionChanged event.
        private void QuizzerScoresBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //Update ComboBox selections.
            UpdateDataBoundComboBoxSelections();

            //Set variable to quizzer score id.
            int quizzerScoreId = MainForm.ConvertStringIDToInt(quizzerScoreIDLabel.Text);
            
            //Attempt to set score level ComboBox's selected item.
            if (quizzerScoreId != -1) //if quizzer score entry has been saved
            {

                try
                {
                    //Set variable to quizzer score level from dataset.
                    string quizzerScoreLevel = MainForm.ReturnColumnValueByPrimaryKey<string>(
                            this.quizMeetDataSet.QuizzerScores, quizzerScoreId, "ScoreLevel"
                        );

                    //If quizzer score level isn't empty
                    if (quizzerScoreLevel != "")
                    {
                        scoreLevelComboBox.SelectedItem = quizzerScoreLevel;
                    }
                    else //if quizzer score level is empty
                    {
                        scoreLevelComboBox.SelectedIndex = 0;
                    }
                }
                catch(Exception)
                {
                    scoreLevelComboBox.SelectedIndex = 0; //Select first item in score level ComboBox.
                }
                
            }
            else //if quizzer score entry has not been saved
            {
                scoreLevelComboBox.SelectedIndex = 0; //Select first item in score level ComboBox.
            }
        }

        //Event handler for Delete Item's Click event.
        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            UpdateDataBoundComboBoxSelections(); //Update data bound ComboBox selections.
        }

        //Helper method to update all data bound ComboBoxes' selections
        private void UpdateDataBoundComboBoxSelections()
        {
            MainForm.UpdateComboBoxSelection(quizzerIDLabel.Text, quizzerComboBox, this.quizMeetDataSet.Quizzers, Quiz.QUIZZER_FULL_NAME); //Update quizzer ComboBox's selection.
            MainForm.UpdateComboBoxSelection(quizMeetIDLabel.Text, quizMeetComboBox, this.quizMeetDataSet.QuizMeets, Quiz.QUIZ_MEET_NAME); //Update quiz meet ComboBox's selection.
            MainForm.UpdateComboBoxSelection(teamIDLabel.Text, teamComboBox, this.quizMeetDataSet.Teams, Quiz.TEAM_NAME); //Update team name ComboBox's selection.
        }

        //Event handler for quizzer ComboBox's SelectedIndexChanged event.
        private void QuizzerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If data bound controls loaded
            if (dataBoundControlsLoaded)
            {
                //Set variable to primary key from row with ComboBox selection.
                int quizzerID = MainForm.ReturnPrimaryKeyFromRowWithComboBoxSelection(
                    quizzerComboBox, this.quizMeetDataSet.Quizzers, Quiz.QUIZZER_FULL_NAME
                );

                //Set Text property of bound control to quizzer ID.
                quizzerIDLabel.Text = quizzerID.ToString();
            }   
        }

        //Event handler for quiz meet ComboBox's SelectedIndexChanged event.
        private void QuizMeetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If data bound controls loaded
            if (dataBoundControlsLoaded)
            {
                //Set variable to primary key from row with ComboBox selection.
                int quizMeetID = MainForm.ReturnPrimaryKeyFromRowWithComboBoxSelection(
                    quizMeetComboBox, this.quizMeetDataSet.QuizMeets, Quiz.QUIZ_MEET_NAME
                );

                //Set Text property of bound control to quiz meet ID.
                quizMeetIDLabel.Text = quizMeetID.ToString();
            }  
        }

        //Event handler for team ComboBox's SelectedIndexChanged event.
        private void TeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If data bound controls loaded
            if(dataBoundControlsLoaded)
            {
                UpdateTeamIDBoundControl(); //Update team ID Label based on ComboBox selection.

                //If no item was selected in team ComboBox
                if (teamComboBox.SelectedIndex == -1)
                {
                    teamComboBox.SelectedIndex = 0; //Set team ComboBox's selection to first element.
                }
            }
        }

        //Helper method to update team ID Label bound control when team ComboBox's selected index is changed.
        private void UpdateTeamIDBoundControl()
        {
            //Declare variable to store team ID.
            int teamID; 
            
            //If user selected no team option
            if (teamComboBox.SelectedIndex != -1 && teamComboBox.SelectedItem.ToString() == Quiz.NO_TEAM)
            {
                teamID = -1; //Set teamID to negative number.
            }
            else //if user selected a team
            {
                //Set variable to primary key from row with ComboBox selection.
                teamID = MainForm.ReturnPrimaryKeyFromRowWithComboBoxSelection(
                    teamComboBox, this.quizMeetDataSet.Teams, Quiz.TEAM_NAME
                );
            }

            //Set Text property of bound control to quizzer ID.
            teamIDLabel.Text = teamID.ToString();
        }

        //Event handler for form's Shown event (which comes after form's Load event).
        private void IndividualQuizzerScoresForm_Shown(object sender, EventArgs e)
        {
            dataBoundControlsLoaded = true; //Set data bound controls loaded variable to true.
            UpdateDataBoundComboBoxSelections(); //Update data bound ComboBox selections.
        }
        
        //Event handler for Add New Item's Click event.
        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //Insert row into QuizzerScores table.
            quizzerScoresTableAdapter.Insert(-1, -1, -1, 0, 0, 0, 0, 0, "Undetermined", 0);

            //Reload QuizzerScores table.
            this.quizzerScoresTableAdapter.FillByAllInfo(this.quizMeetDataSet.QuizzerScores);

            //Switch to new row.
            quizzerScoresBindingSource.Position = this.quizMeetDataSet.QuizzerScores.Rows.Count;
        }

        //Event handler for Calculate Quizzer Score button's Click event.
        private void CalculateQuizzerScoreButton_Click(object sender, EventArgs e)
        {
            //Declare variables.
            int[] totalQuestionsInEachRound; //Array to store total number of questions in each rounds for this quizzer's level for this quiz meet.
            int quizzerScoreID; //Variable to store quizzer score ID.
            int quizMeetID; //Variable to store quiz meet ID.
            int quizzerID; //Variable to store quizzer ID.
            string quizLevel; //Variable to store quizzer's quiz level.
            int pointsPerQuestion; //Variable to store number of points for each question.
            string calculationMethod; //Variable to store calculation method.
            decimal percentCorrect; //Variable to store percent correct.

            //If calculation method not selected
            if(calculationMethodComboBox.SelectedIndex == -1)
            {
                MainForm.DisplayErrorMessageWithOKButton("Please select a calculation method."); //Display error message.
                calculationMethodComboBox.Focus(); //Send focus to calculation method input field.
                return; //Exit method.
            }

            //Initialize variable to calculation method ComboBox's selection.
            calculationMethod = calculationMethodComboBox.SelectedItem.ToString();

            //Attempt to initialize variable to quizzer score ID.
            int.TryParse(quizzerScoreIDLabel.Text, out quizzerScoreID);

            //If quizzer score ID is invalid
            if (quizzerScoreID < 0)
            {
                MainForm.DisplayErrorMessageWithOKButton("Please save this quizzer's score entry before calculating their score.");
                return; //Exit method.
            }

            //Attempt to obtain quizzer ID.
            int.TryParse(quizzerIDLabel.Text, out quizzerID);

            //If quizzer ID is negative
            if (quizzerID < 0)
            {
                MainForm.DisplayErrorMessageWithOKButton("The quizzer ID is invalid."); //Display error message.
                quizzerComboBox.Focus(); //Send focus to quizzer input field.
                return; //Exit method.
            }

            //Attempt to obtain quiz meet ID.
            int.TryParse(quizMeetIDLabel.Text, out quizMeetID);

            //If quiz meet ID is negative
            if (quizMeetID < 0)
            {
                MainForm.DisplayErrorMessageWithOKButton("The quiz meet ID is invalid."); //Display error message.
                quizMeetComboBox.Focus(); //Send focus to quiz meet input field.
                return; //Exit method.
            }

            //Attempt to initialize quizzer level variable.
            try
            {
                quizLevel = MainForm.ReturnColumnValueByPrimaryKey<string>(
                    this.quizMeetDataSet.Quizzers, quizzerID, Quiz.QUIZZER_QUIZ_LEVEL
                );
            } catch(Exception)
            {
                MainForm.DisplayErrorMessageWithOKButton("The quizzer's quiz level was inaccessible.");
                return; //Exit method.
            }
            
            try
            {
                //If Red Level quizzer
                if (quizLevel == Quiz.RED_LEVEL)
                {

                    //Initialize array to store number of questions in each round for this quiz meet for Red Level.
                    totalQuestionsInEachRound = new int[]
                    {
                    MainForm.ReturnColumnValueByPrimaryKey<int>(this.quizMeetDataSet.QuizMeets, quizMeetID, Quiz.RED_ROUND_1_TOTAL_QUESTIONS),
                    MainForm.ReturnColumnValueByPrimaryKey<int>(this.quizMeetDataSet.QuizMeets, quizMeetID, Quiz.RED_ROUND_2_TOTAL_QUESTIONS)
                    };

                    //Initialize variable to points per question for Red Level for this quiz.
                    pointsPerQuestion = MainForm.ReturnColumnValueByPrimaryKey<int>(
                        this.quizMeetDataSet.QuizMeets, quizMeetID, Quiz.RED_QUESTION_POINTS
                    );
                }
                else if (quizLevel == Quiz.BLUE_LEVEL) //if Blue Level quizzer
                {
                    //Initialize variable to store number of questions in each round for Blue Level.
                    totalQuestionsInEachRound = new int[]
                    {
                    MainForm.ReturnColumnValueByPrimaryKey<int>(this.quizMeetDataSet.QuizMeets, quizMeetID, Quiz.BLUE_ROUND_1_TOTAL_QUESTIONS),
                    MainForm.ReturnColumnValueByPrimaryKey<int>(this.quizMeetDataSet.QuizMeets, quizMeetID, Quiz.BLUE_ROUND_2_TOTAL_QUESTIONS)
                    };

                    //Initialize variable to points per question for Blue Level.
                    pointsPerQuestion = MainForm.ReturnColumnValueByPrimaryKey<int>(
                        this.quizMeetDataSet.QuizMeets, quizMeetID, Quiz.BLUE_QUESTION_POINTS
                    );
                }
                else //if quizzer level is invalid
                {
                    MainForm.DisplayErrorMessageWithOKButton("The quizzer's quiz level is invalid.");
                    return; //Exit method.
                }
            }
            catch(Exception)
            {
                MainForm.DisplayErrorMessageWithOKButton("The quiz meet's information was inaccesible.");
                return; //Exit method.
            }

            //Attempt to calculate score based on calculation method selected.
            if (calculationMethod == Quiz.PERFECT_ROUNDS_METHOD)
            {
                //If number of perfect rounds is invalid for this method
                if (perfectRoundsNumericUpDown.Value != 2)
                {
                    MainForm.DisplayErrorMessageWithOKButton("To use the perfect rounds method, you must enter \"2\" into the perfect rounds field."); //Display error message.
                    perfectRoundsNumericUpDown.Focus(); //Send focus to perfect rounds input field.
                    return; //Exit method.
                }

                //Set score input fields to perfect score.
                SetScoreInputFieldsForPerfectScore(totalQuestionsInEachRound, pointsPerQuestion);
            }
            else if (calculationMethod == Quiz.SCORE_LEVEL_METHOD)
            {
                //If score level selection is invalid for this calculation method
                if (scoreLevelComboBox.SelectedItem.ToString() != Quiz.GOLD_ALL_STAR)
                {
                    MainForm.DisplayErrorMessageWithOKButton("To use the score level method, you must select \"" + Quiz.GOLD_ALL_STAR + "\" in the score level field."); //Display error message.
                    scoreLevelComboBox.Focus(); //Send focus to score level input field.
                    return; //Exit method.
                }

                //Set score input fields to perfect score.
                SetScoreInputFieldsForPerfectScore(totalQuestionsInEachRound, pointsPerQuestion);
            }
            else if (calculationMethod == Quiz.PERCENT_CORRECT_METHOD)
            {
                //Attempt to set variable to percent correct.
                decimal.TryParse(percentCorrectTextBox.Text, out percentCorrect);

                //If percent correct is invalid or not 100
                if (percentCorrect == -1 || percentCorrect != 100)
                {
                    MainForm.DisplayErrorMessageWithOKButton("To use the percent correct method, you must enter \"100\" in the percent correct field."); //Display error message.
                    percentCorrectTextBox.Focus(); //Send focus to percent correct TextBox.
                    return; //Exit method.
                }

                //Set score input fields to perfect score.
                SetScoreInputFieldsForPerfectScore(totalQuestionsInEachRound, pointsPerQuestion);
            }
            else if(calculationMethod == Quiz.NUMBER_QUESTIONS_CORRECT_METHOD)
            {
                //Declare and initialize array to number of questions correct in each round.
                int[] roundsNumberQuestionsCorrect = new int[2]; //Declare array to store number of questions correct in each round.
                roundsNumberQuestionsCorrect[0] = (int) round1NumberQuestionsCorrectNumericUpDown.Value; //Initialize first element to number questions correct in first round.
                roundsNumberQuestionsCorrect[1] = (int) round2NumberQuestionsCorrectNumericUpDown.Value; //Initialize second element to number questions correct in second round.
            
                //If number of questions correct in round 1 is greater than the number of questions in round 1
                if(roundsNumberQuestionsCorrect[0] > totalQuestionsInEachRound[0])
                {
                    MainForm.DisplayErrorMessageWithOKButton("The number of correct questions in Round 1 cannot exceed the total number of questions in Round 1 (" + totalQuestionsInEachRound[0] + ")."); //Display error message.
                    round1NumberQuestionsCorrectNumericUpDown.Focus(); //Send focus to round 1 number questions correct input fied.
                    return; //Exit method.
                }
                else if(roundsNumberQuestionsCorrect[1] > totalQuestionsInEachRound[1]) //if number of questions correct in round 2 is greater than the number of questions in round 2
                {
                    MainForm.DisplayErrorMessageWithOKButton("The number of correct questions in Round 2 cannot exceed the total number of questions in Round 2 (" + totalQuestionsInEachRound[1] + ")."); //Display error message.
                    round2NumberQuestionsCorrectNumericUpDown.Focus(); //Send focus to round 2 number questions correct input fied.
                    return; //Exit method.
                }

                //Set points for rounds NumericUpDowns.
                MainForm.SetNumericUpDownValueAndText(round1PointsNumericUpDown, roundsNumberQuestionsCorrect[0] * pointsPerQuestion); //Set Round 1 field value.
                MainForm.SetNumericUpDownValueAndText(round2PointsNumericUpDown, roundsNumberQuestionsCorrect[1] * pointsPerQuestion); //Set round 2 field value.

                //Set percent correct and score level fields.
                CalculatePercentCorrectAndScoreLevel(pointsPerQuestion, roundsNumberQuestionsCorrect, totalQuestionsInEachRound);

                //Set number of perfect rounds field.
                MainForm.SetNumericUpDownValueAndText(perfectRoundsNumericUpDown, Quiz.CalculateNumberOfPerfectRounds(roundsNumberQuestionsCorrect, totalQuestionsInEachRound));
            }
            else if(calculationMethod == Quiz.NUMBER_POINTS_METHOD)
            {
                //Declare and initialize array to store number of points entered for each round.
                int[] numberPointsEnteredForEachRound = new int[]
                {
                    (int) round1PointsNumericUpDown.Value,
                    (int) round2PointsNumericUpDown.Value
                };

                //Declare array to store number of questions answered correctly in each round.
                int[] numberQuestionsCorrectForEachRound;
                
                //If number of points entered for round 1 exceeds the total number of possible points for a quizzer for the round
                if(numberPointsEnteredForEachRound[0] > pointsPerQuestion * totalQuestionsInEachRound[0])
                {
                    MainForm.DisplayErrorMessageWithOKButton("The number of points scored by a quizzer in Round 1 may not exceed the total number of possible points for a quizzer in Round 1 (" + totalQuestionsInEachRound[0] * pointsPerQuestion + ").");
                    round1PointsNumericUpDown.Focus(); //Send focus to round 1 points field.
                    return; //Exit method.
                }
                else if (numberPointsEnteredForEachRound[1] > pointsPerQuestion * totalQuestionsInEachRound[1]) //If number of points entered for round 2 exceeds the total number of possible points for a quizzer for the round
                {
                    MainForm.DisplayErrorMessageWithOKButton("The number of points scored by a quizzer in Round 2 may not exceed the total number of possible points for a quizzer in Round 2 (" + totalQuestionsInEachRound[1] * pointsPerQuestion + ").");
                    round2PointsNumericUpDown.Focus(); //Send focus to round 2 points field.
                    return; //Exit method.
                }

                //Initialize array of number of questions answered correctly in each round.
                numberQuestionsCorrectForEachRound = new int[]
                {
                    numberPointsEnteredForEachRound[0] / pointsPerQuestion,
                    numberPointsEnteredForEachRound[1] / pointsPerQuestion
                };

                //Set Number Questions Correct fields.
                MainForm.SetNumericUpDownValueAndText(round1NumberQuestionsCorrectNumericUpDown, numberQuestionsCorrectForEachRound[0]);
                MainForm.SetNumericUpDownValueAndText(round2NumberQuestionsCorrectNumericUpDown, numberQuestionsCorrectForEachRound[1]);

                //Set number of perfect rounds field.
                MainForm.SetNumericUpDownValueAndText(perfectRoundsNumericUpDown, Quiz.CalculateNumberOfPerfectRounds(numberQuestionsCorrectForEachRound, totalQuestionsInEachRound));

                //Set Score Level and Percent Correct fields.
                CalculatePercentCorrectAndScoreLevel(pointsPerQuestion, numberQuestionsCorrectForEachRound, totalQuestionsInEachRound);
            }
            else //if user did not select a valid calculation method.
            {
                //Display error message.
                MainForm.DisplayErrorMessageWithOKButton("You selected an invalid score calculation method.");

                //Send focus to score calculation method input field.
                calculationMethodComboBox.Focus();

                return; //Exit method.
            }
        }

        //Helper method to calculate and display percent correct and score level.
        private void CalculatePercentCorrectAndScoreLevel(int pointsPerQuestion, int[] roundsNumberQuestionsCorrect, int[] totalQuestionsInEachRound)
        {
            //Declare and initialize variable to percent correct.
            decimal percentCorrect = Quiz.CalculatePercentCorrect(roundsNumberQuestionsCorrect, totalQuestionsInEachRound);
            
            //Set percent correct TextBox.
            percentCorrectTextBox.Text = percentCorrect.ToString();

            //Set score level ComboBox selection.
            scoreLevelComboBox.SelectedItem = Quiz.CalculateScoreLevel(percentCorrect, Quiz.CalculateNumberOfPerfectRounds(roundsNumberQuestionsCorrect, totalQuestionsInEachRound));
        
            //Set total points label.
            totalPointsLabel.Text = Quiz.CalculateTotalPoints(pointsPerQuestion, roundsNumberQuestionsCorrect).ToString();
        }

        //Helper method to set score input fields for perfect score.
        private void SetScoreInputFieldsForPerfectScore(int[] totalQuestionsInEachRound, int pointsPerQuestion)
        {
            
            //Set percent correct field and score level field
            percentCorrectTextBox.Text = "100"; //Display percent correct.
            scoreLevelComboBox.SelectedItem = Quiz.GOLD_ALL_STAR; //Display score level.
             
            //Set perfect rounds input field
            MainForm.SetNumericUpDownValueAndText(perfectRoundsNumericUpDown, 2);

            //Set Number of Questions Correct fields for Round 1 and Round 2.
            MainForm.SetNumericUpDownValueAndText(round1NumberQuestionsCorrectNumericUpDown, totalQuestionsInEachRound[0]);
            MainForm.SetNumericUpDownValueAndText(round2NumberQuestionsCorrectNumericUpDown, totalQuestionsInEachRound[1]);

            //Set points per round fields.
            MainForm.SetNumericUpDownValueAndText(round1PointsNumericUpDown, totalQuestionsInEachRound[0] * pointsPerQuestion);
            MainForm.SetNumericUpDownValueAndText(round2PointsNumericUpDown, totalQuestionsInEachRound[1] * pointsPerQuestion);

            //Set total points label.
            totalPointsLabel.Text = Quiz.CalculateTotalPoints(pointsPerQuestion, totalQuestionsInEachRound).ToString();
        }
    }
}
