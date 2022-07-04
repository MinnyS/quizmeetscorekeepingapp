using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMeetScorekeeper
{
    public partial class TeamsForm : Form
    {
        //Declare class variables.
        private const string TEAMS_CSV_FILE_NAME = @"\TeamScores.csv"; //Variable to store name of file to which teams data will be outputted.

        //No-argument constructor.
        public TeamsForm()
        {
            InitializeComponent();
        }

        //Helper method to load data into table.
        private void LoadTables()
        {
            // TODO: This line of code loads data into the 'quizMeetDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.FillByAllInformationWithNames(this.quizMeetDataSet.Teams);
            // TODO: This line of code loads data into the 'quizMeetDataSet.QuizzerScores' table. You can move, or remove it, as needed.
            this.quizzerScoresTableAdapter.FillByQuizzerScoresForTeamScores(this.quizMeetDataSet.QuizzerScores);
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

        //Event handler for Save Item button's Click event.
        private void TeamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveAllChanges();
        }

        //Event handler for form's Load event.
        private void TeamsForm_Load(object sender, EventArgs e)
        {
            //Load data into table.
            LoadTables(); 

            //Set team scores calculation method ComboBox's elements to list of team scores calculation methods.
            teamScoresCalculationMethodComboBox.DataSource = Quiz.GetAllTeamScoresCalculationMethodsArray();
        }

        //Event handler for Exit button's Click event.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close form.
        }

        //Event handler for Edit Individually button's Click event.
        private void EditIndividuallyButton_Click(object sender, EventArgs e)
        {
            //Save changes to database.
            SaveAllChanges();

            //Display IndividualTeamsForm, opened to current position.
            DisplayIndividualTeamsForm(teamsBindingSource.Position);

            //Reload table.
            LoadTables();
        }

        //Event handler for form's FormClosing event.
        private void TeamsForm_FormClosing(object sender, FormClosingEventArgs e)
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

        //Event handler for Calculate Team Scores button's Click event.
        private void CalculateTeamScoresButton_Click(object sender, EventArgs e)
        {
            //Declare variables.
            int[] teamQuizzersPointsPerRound; //Array to store team's total quizzers points per round.
            
            //If user selected total points using quizzer scores database method
            if((string) teamScoresCalculationMethodComboBox.SelectedItem == Quiz.TOTAL_POINTS_USING_QUIZZER_SCORES_DATABASE_METHOD)
            {
                //Calculate and set total team points for each team.
                foreach (DataRow teamRow in this.quizMeetDataSet.Teams)
                {
                    teamQuizzersPointsPerRound = ReturnTeamQuizzersPointsForRound(teamRow);
                    
                    //Set total team points field.
                    teamRow.SetField<int>(Quiz.TOTAL_TEAM_POINTS, CalculateTotalTeamPoints(teamQuizzersPointsPerRound, teamRow));
                }
            }
            else if((string) teamScoresCalculationMethodComboBox.SelectedItem == Quiz.TOTAL_POINTS_USING_ONLY_TEAMS_DATABASE_METHOD) //if user selected total points using only team database method
            {
                //Initialize array to store team quizzers points per round.
                teamQuizzersPointsPerRound = new int[2];

                //Calculate and set total team points for each team.
                foreach(DataRow teamRow in this.quizMeetDataSet.Teams)
                {
                    //Initialize array elements to total team quizzers' points for each round.
                    teamQuizzersPointsPerRound[0] = teamRow.Field<int>(Quiz.ROUND_1_TEAM_QUIZZERS_POINTS); //Round 1 team quizzers' points.
                    teamQuizzersPointsPerRound[1] = teamRow.Field<int>(Quiz.ROUND_2_TEAM_QUIZZERS_POINTS); //Round 2 team quizzers' points.

                    //Set total team points field.
                    teamRow.SetField<int>(Quiz.TOTAL_TEAM_POINTS, CalculateTotalTeamPoints(teamQuizzersPointsPerRound, teamRow));
                }
            }
            else //if no valid team scores calculation method was selected
            {
                MainForm.DisplayErrorMessageWithOKButton("Please select a team scores calculation method before calculating team scores."); //Display error message.
                teamScoresCalculationMethodComboBox.Focus(); //Send focus to team scores calculation method ComboBox.
            }
        }

        //Helper method to calculate and set team scores by using quizzer scores database.
        private int[] ReturnTeamQuizzersPointsForRound(DataRow teamRow)
        {
            //Declare and initialize array to store team quizzers points per round.
            int[] teamQuizzersPointsPerRound = new int[2];

            //Initialize array elements to team's quizzers' points for Round 1.
            teamQuizzersPointsPerRound[0] = CalculateQuizzersPointsForRound(
                teamRow.Field<int>(Quiz.TEAM_ID), Quiz.ROUND_1_POINTS,
                this.quizMeetDataSet.QuizzerScores
            );

            //Set team's quizzer's points for Round 1 field.
            teamRow.SetField<int>(Quiz.ROUND_1_TEAM_QUIZZERS_POINTS, teamQuizzersPointsPerRound[0]);

            //Initialize array elements to team's quizzers' points for Round 2.
            teamQuizzersPointsPerRound[1] = CalculateQuizzersPointsForRound(
                teamRow.Field<int>(Quiz.TEAM_ID), Quiz.ROUND_2_POINTS,
                this.quizMeetDataSet.QuizzerScores
            );

            //Set team's quizzer's points for Round 1 field.
            teamRow.SetField<int>(Quiz.ROUND_2_TEAM_QUIZZERS_POINTS, teamQuizzersPointsPerRound[1]);
            
            //Return team quizzers points per round array.
            return teamQuizzersPointsPerRound;

        }

        //Helper method to return total team points based on array of team quizzers' points per round and team DataRow.
        private int CalculateTotalTeamPoints(int[] teamQuizzersPointsPerRound, DataRow teamRow)
        {
            //Declare variables.
            int totalTeamQuizzersPoints; //Variable to store total team points.
            int totalBonusPoints; //Variable to store total bonus points.
            int totalTeamPoints; //Variable to store total team points.
            int[] bonusPointsPerRound = new int[teamQuizzersPointsPerRound.Length]; //Array to store bonus points per round.

            //Initialize array elements to bonus points per round.
            bonusPointsPerRound[0] = teamRow.Field<int>(Quiz.ROUND_1_TEAM_BONUS_POINTS);
            bonusPointsPerRound[1] = teamRow.Field<int>(Quiz.ROUND_2_TEAM_BONUS_POINTS);
            
            //Calculate total bonus points.
            totalBonusPoints = MainForm.CalculateSumOfArrayElements(bonusPointsPerRound);

            //Calculate total team quizzer's points.
            totalTeamQuizzersPoints = MainForm.CalculateSumOfArrayElements(teamQuizzersPointsPerRound);

            //Calculate total team points.
            totalTeamPoints = totalBonusPoints + totalTeamQuizzersPoints;

            //Return total team points.
            return totalTeamPoints;
        }

        //Helper method to return this team's quizzers' total points for specific round.
        public static int CalculateQuizzersPointsForRound(int teamID, string columnName, DataTable dataTable)
        {
            //Declare and initialize variables.
            int totalQuizzersPointsForRound = 0; //Accumulator variable to store total points earned by quizzers for this round.
            List<int> quizzersPointsForRound = MainForm.GetValuesFromColumnInTableWhereFieldMatches<int>(
                teamID, Quiz.TEAM_ID,
                columnName, dataTable
            ); //List to store quizzers' points for this round.

            //Sum up quizzers' points for round.
            foreach(int quizzerScore in quizzersPointsForRound)
            {
                totalQuizzersPointsForRound += quizzerScore;
            }

            //Return sum of quizzers' points for round.
            return totalQuizzersPointsForRound;
        }

        //Event handler for Add New Item button's Click event.
        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //Open IndividualTeams form, adding new item.
            DisplayIndividualTeamsForm(-1);

            //Reload data into tables.
            LoadTables();
        }

        //Helper method to display individual teams form, passing in position for binding source.
        private void DisplayIndividualTeamsForm(int position)
        {
            //Display IndividualTeamsForm.
            IndividualTeamsForm editIndividualTeamsForm = new IndividualTeamsForm(position); //Create new IndividualTeamsForm.
            editIndividualTeamsForm.ShowDialog(); //Display IndividualTeamsForm.

        }

        private void GenerateCSVFileButton_Click(object sender, EventArgs e)
        {
            //Save and reload information.
            SaveAllChanges(); //Save all changes to database.
            LoadTables(); //Reload tables.

            MainForm.ExportDataTableAsCSVFile(this.quizMeetDataSet.Teams, TEAMS_CSV_FILE_NAME);
            Process.Start(TEAMS_CSV_FILE_NAME); //Open file.
        }
    }
}
