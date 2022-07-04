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
    public partial class IndividualTeamsForm : Form
    {
        //Declare class variables.
        private int startBindingSourcePosition = 0; //Binding source position for start.
        bool dataBoundControlsLoaded = false; //Variable to store value indicating whether data bound controls are loaded.
        private NumericUpDown[] dataBoundNumericUpDownControls; //Array to store data bound NumericUpDown controls.

        //No-argument constructor.
        public IndividualTeamsForm()
        {
            InitializeComponent();
        }

        //One-argument constructor which takes binding source starting position.
        public IndividualTeamsForm(int startingPosition) : this()
        {
            startBindingSourcePosition = startingPosition; //Set start binding source position variable to parameter value.
        }

        //Helper method to load data into tables.
        private void LoadTables()
        {
            // TODO: This line of code loads data into the 'quizMeetDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.quizMeetDataSet.Teams);
            
            // TODO: This line of code loads data into the 'quizMeetDataSet.QuizzerScores' table. You can move, or remove it, as needed.
            this.quizzerScoresTableAdapter.FillByQuizzerScoresForTeamScores(this.quizMeetDataSet.QuizzerScores);

            // TODO: This line of code loads data into the 'quizMeetDataSet.QuizMeets' table. You can move, or remove it, as needed.
            this.quizMeetsTableAdapter.Fill(this.quizMeetDataSet.QuizMeets);

            // TODO: This line of code loads data into the 'quizMeetDataSet.Churches' table. You can move, or remove it, as needed.
            this.churchesTableAdapter.Fill(this.quizMeetDataSet.Churches);
        }

        //Helper method to save all changes to database.
        private void SaveAllChanges()
        {
            try
            {
                this.Validate();
                this.teamsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.quizMeetDataSet);
            }
            catch (Exception e)
            {
                //Display error message.
                MainForm.DisplayExceptionErrorMessage(e);
            }
        }

        private void TeamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveAllChanges();
        }

        private void IndividualTeamsForm_Load(object sender, EventArgs e)
        {
            //Load data into table.
            LoadTables();

            //Initialize data bound NumericUpDownControls array.
            dataBoundNumericUpDownControls = new NumericUpDown[]
            {
                round1BonusPointsNumericUpDown,
                round1TeamPointsNumericUpDown,
                round2BonusPointsNumericUpDown,
                round2TeamPointsNumericUpDown,
                totalPointsNumericUpDown
            };

            //Set team scores calculation method ComboBox's elements to list of team scores calculation methods.
            teamScoresCalculationMethodComboBox.DataSource = Quiz.GetAllTeamScoresCalculationMethodsArray();

            //Populate data bound ComboBoxes.
            PopulateDataBoundComboBoxes();

            //Set binding source position to start binding source position.
            SetBindingSourcePosition(startBindingSourcePosition); 
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close form.
        }

        private void IndividualTeamsForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void CalculateTeamScoreButton_Click(object sender, EventArgs e)
        {
            //Declare variables.
            int teamID; //Variable to store team ID.
            int totalTeamPoints = 0; //Accumulator variable to store total team points.
            int[] teamPointsForEachRound = { 0, 0 }; //Array to store total team quizzers points for each round.
            int[] bonusPointsForEachRound = new int[2]; //Array to store bonus points for each round.
            
            //Initialize variable to team ID.
            int.TryParse(teamIDLabel.Text, out teamID);

            //If team ID is negative.
            if (teamID < 0)
            {
                MainForm.DisplayErrorMessageWithOKButton("Please save this team before attempting to calculate the team score."); //Display error message.
                return; //Exit method.
            }
            
            if((string) teamScoresCalculationMethodComboBox.SelectedItem == Quiz.TOTAL_POINTS_USING_QUIZZER_SCORES_DATABASE_METHOD)
            {
                //Initialize array elements to team's quizzers' total points for each round based on QuizzerScores data.
                teamPointsForEachRound[0] = TeamsForm.CalculateQuizzersPointsForRound(teamID, Quiz.ROUND_1_POINTS, this.quizMeetDataSet.QuizzerScores); //Team's quizzers' points for Round 1.
                teamPointsForEachRound[1] = TeamsForm.CalculateQuizzersPointsForRound(teamID, Quiz.ROUND_2_POINTS, this.quizMeetDataSet.QuizzerScores); //Team's quizzers' points for Round 2.

                //Update team points for each round input fields.
                MainForm.SetNumericUpDownValueAndText(round1TeamPointsNumericUpDown, teamPointsForEachRound[0]); //Set round 1 team points display.
                MainForm.SetNumericUpDownValueAndText(round2TeamPointsNumericUpDown, teamPointsForEachRound[1]); //Set round 2 team points display.
            }
            else if((string) teamScoresCalculationMethodComboBox.SelectedItem == Quiz.TOTAL_POINTS_USING_ONLY_TEAMS_DATABASE_METHOD) {
                //Initialize array elements to team's quizzers' total points for each round based on user entry for team.
                teamPointsForEachRound[0] = (int) round1TeamPointsNumericUpDown.Value;
                teamPointsForEachRound[1] = (int) round2TeamPointsNumericUpDown.Value;
            } else
            {
                MainForm.DisplayErrorMessageWithOKButton("Please select a team scores calculation method before calculating team scores."); //Display error message.
                teamScoresCalculationMethodComboBox.Focus(); //Send focus to team scores calculation method ComboBox.
            }

            //Initialize bonus points for each round array.
            bonusPointsForEachRound[0] = (int)round1BonusPointsNumericUpDown.Value; //Round 1 bonus points.
            bonusPointsForEachRound[1] = (int)round2BonusPointsNumericUpDown.Value; //Round 2 bonus points.

            //Add team points and bonus points for each round to total team points.
            for (int roundIndex = 0; roundIndex < teamPointsForEachRound.Length; ++roundIndex)
            {
                totalTeamPoints += teamPointsForEachRound[roundIndex]; //Add this round's team points.
                totalTeamPoints += bonusPointsForEachRound[roundIndex]; //Add this round's bonus points.
            }

            //Update total team points field.
            MainForm.SetNumericUpDownValueAndText(totalPointsNumericUpDown, totalTeamPoints);
        }
        
        //Helper method to set binding source position.
        private void SetBindingSourcePosition(int position)
        {
            //If starting position is valid
            if (position > -1 && position < this.quizMeetDataSet.QuizzerScores.Rows.Count)
            {
                teamsBindingSource.Position = position; //Set position to starting position.
            }
            else if (position == -1) //if value is -1
            {
                bindingNavigatorAddNewItem.PerformClick(); //Trigger New Item button's Click event.
            }
        }

        //Event handler for Add New Item button's Click event.
        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //Insert row into Teams table.
            teamsTableAdapter.Insert(
                "team " + (this.quizMeetDataSet.Teams.Count + 1).ToString(),
                -1, -1, 0, 0, 0, 0, 0
            ); 
            
            //Reload Teams table.
            this.teamsTableAdapter.Fill(this.quizMeetDataSet.Teams);

            //Switch to new row.
            teamsBindingSource.Position = this.quizMeetDataSet.Teams.Rows.Count;

            //Set total points NumericUpDown to zero.
            MainForm.SetNumericUpDownValueAndText(totalPointsNumericUpDown, 0);
        }

        //Method to populate data bound ComboBoxes (not including scoring methods ComboBox).
        private void PopulateDataBoundComboBoxes()
        {
            //Attempt to set quiz meets ComboBox's data source.
            try
            {
                quizMeetComboBox.DataSource = MainForm.GetValuesFromColumnInTable<string>(this.quizMeetDataSet.QuizMeets, Quiz.QUIZ_MEET_NAME);
            }
            catch (Exception)
            {
                MainForm.DisplayErrorMessageWithOKButton("Quiz meet names could not be accessed from the Quiz Meets table."); //Display error message.
            }

            //Attempt to set church ComboBox's data source.
            try
            {
                //Set church name ComboBox's data source.
                churchComboBox.DataSource = MainForm.GetListOfValuesFromColumnInTablePrecededByItem(this.quizMeetDataSet.Churches, Quiz.CHURCH_NAME, Quiz.NO_CHURCH);
            }
            catch (Exception)
            {
                MainForm.DisplayErrorMessageWithOKButton("Church names could not be accessed from the Churches table."); //Display error message.
            }
        }

        //Helper method to update all data bound ComboBoxes' selections
        private void UpdateDataBoundComboBoxSelections()
        {
            MainForm.UpdateComboBoxSelection(quizMeetIDLabel.Text, quizMeetComboBox, this.quizMeetDataSet.QuizMeets, Quiz.QUIZ_MEET_NAME); //Update quiz meet name ComboBox's selection.
            MainForm.UpdateComboBoxSelection(churchIDLabel.Text, churchComboBox, this.quizMeetDataSet.Churches, Quiz.CHURCH_NAME); //Update church name ComboBox's selection.
        }

        private void TeamsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            UpdateDataBoundComboBoxSelections(); //Update data bound ComboBox selections.
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            UpdateDataBoundComboBoxSelections(); //Update data bound ComboBox selections.
        }

        private void IndividualTeamsForm_Shown(object sender, EventArgs e)
        {
            dataBoundControlsLoaded = true; //Set data bound controls loaded variable to true.
            UpdateDataBoundComboBoxSelections(); //Update data bound ComboBox selections.
        }

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

        private void ChurchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If data bound controls loaded
            if (dataBoundControlsLoaded)
            {
                //Declare variable to store church ID.
                int churchID; //Initialize v

                //If user selected no team option
                if (churchComboBox.SelectedIndex != -1 && churchComboBox.SelectedItem.ToString() == Quiz.NO_CHURCH)
                {
                    churchID = -1; //Set teamID to negative number.
                }
                else //if user selected a team
                {
                    //Initialize variable to primary key from row with ComboBox selection.
                    churchID = MainForm.ReturnPrimaryKeyFromRowWithComboBoxSelection(
                        churchComboBox, this.quizMeetDataSet.Churches, Quiz.CHURCH_NAME
                    );
                }

                //Set Text property of bound control to quiz meet ID.
                churchIDLabel.Text = churchID.ToString();

                //If no item was selected in church ComboBox
                if (churchComboBox.SelectedIndex == -1)
                {
                    churchComboBox.SelectedIndex = 0; //Set church ComboBox's selection to first element.
                }
            }
        }
    }
}
