using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMeetScorekeeper
{
    public static class Quiz
    {
        #region Constants

        //Declare public constants representing selection text for each individual quizzer scores calculation method.
        public const string NUMBER_QUESTIONS_CORRECT_METHOD = "Calculate by number of questions correct in each round";
        public const string NUMBER_POINTS_METHOD = "Calculate by number of points in each round";
        public const string PERFECT_ROUNDS_METHOD = "Calculate by number of perfect rounds"; //Shortcut method.
        public const string SCORE_LEVEL_METHOD = "Calculate by score level"; //Shortcut method.
        public const string PERCENT_CORRECT_METHOD = "Calculate by percent correct"; //Shortcut method.

        //Declare public constants representing selection text for each team scores calculation method.
        public const string TOTAL_POINTS_USING_QUIZZER_SCORES_DATABASE_METHOD = "Calculate total points using individual quizzers' scores information.";
        public const string TOTAL_POINTS_USING_ONLY_TEAMS_DATABASE_METHOD = "Calculate total points using currently entered information.";

        //Declare public constants representing quizzer score levels.
        public const string BRONZE = "Bronze";
        public const string SILVER = "Silver";
        public const string GOLD = "Gold";
        public const string GOLD_ONE_PERFECT_ROUND = "Gold with One Perfect Round";
        public const string GOLD_ALL_STAR = "Gold All-Star";

        //Declare public constants representing quiz levels.
        public const string RED_LEVEL = "Red Level";
        public const string BLUE_LEVEL = "Blue Level";

        //Declare public constants storing QuizzerScores database table column names.
        public const string QUIZZER_SCORE_ID = "QuizzerScoreID"; //Name of column storing quizzer score entry ID.
        public const string QUIZZER_SCORE_QUIZZER_ID = "QuizzerID"; //Name of column storing quizzer ID. 
        public const string QUIZZER_SCORE_QUIZ_MEET_ID = "QuizMeetID"; //Name of column storing quiz meet ID.
        public const string ROUND_1_NUM_CORRECT = "Round1NumberQuestionsCorrect"; //Name of column storing number of questions answered correctly in Round 1.
        public const string ROUND_1_POINTS = "Round1Points"; //Name of column storing number of points scored in round 1.
        public const string ROUND_2_NUM_CORRECT = "Round2NumberQuestionsCorrect"; //Name of column storing number of questions answered correctly in Round 2.
        public const string ROUND_2_POINTS = "Round2Points"; //Name of column storing number of points scored in round 2.
        public const string PERFECT_ROUNDS = "PerfectRounds"; //Name of column storing number of perfect rounds.
        public const string SCORE_LEVEL = "ScoreLevel"; //Name of column storing score level.
        public const string PERCENT_CORRECT = "PercentCorrect"; //Name of column storing percent correct.
        public const string TOTAL_POINTS = "TotalPoints"; //Name of column storing total points.

        //Declare public constants storing Quizzers database table column names.
        public const string QUIZZER_FULL_NAME = "FullName"; //Name of column storing Quizzer's full name.
        public const string QUIZZER_QUIZ_LEVEL = "QuizLevel"; //Name of column storing Quizzer's quiz level.
        public const string QUIZZER_CHURCH = "ChurchName"; //Name of column storing Quizzer's church's name.

        //Declare public constants storing QuizMeets database table column names.
        public const string QUIZ_MEET_NAME = "Name"; //Name of column storing Quiz Meet name.
        public const string RED_ROUND_1_TOTAL_QUESTIONS = "RedLevelRound1TotalQuestions"; //Name of column storing total number of questions in Red Level Round 1.
        public const string RED_ROUND_2_TOTAL_QUESTIONS = "RedLevelRound2TotalQuestions"; //Name of column storing total number of questions in Red Level Round 2.
        public const string RED_QUESTION_POINTS = "RedLevelPointsPerQuestion"; //Name of column storing number of points per Red Level question.
        public const string BLUE_ROUND_1_TOTAL_QUESTIONS = "BlueLevelRound1TotalQuestions"; //Name of column storing total number of questions in Blue Level Round 1.
        public const string BLUE_ROUND_2_TOTAL_QUESTIONS = "BlueLevelRound2TotalQuestions"; //Name of column storing total number of questions in Blue Level Round 2.
        public const string BLUE_QUESTION_POINTS = "BlueLevelPointsPerQuestion"; //Name of column storing number of points per Blue Level question.

        //Declare public constants storing Teams database table column names.
        public const string TEAM_NAME = "TeamName"; //Name of column storing team's name.
        public const string TEAM_ID = "TeamID"; //Name of column storing team ID.
        public const string ROUND_1_TEAM_BONUS_POINTS = "Round1BonusPoints"; //Name of column storing bonus points for round 1.
        public const string ROUND_2_TEAM_BONUS_POINTS = "Round2BonusPoints"; //Name of column storing bonus points for round 2.
        public const string ROUND_1_TEAM_QUIZZERS_POINTS = "Round1TeamPoints"; //Name of column storing team points for round 1.
        public const string ROUND_2_TEAM_QUIZZERS_POINTS = "Round2TeamPoints"; //Name of column storing team points for round 2.
        public const string TOTAL_TEAM_POINTS = "TotalPoints"; //Name of column storing total team points.

        //Declare public constants storing Church database table column names.
        public const string CHURCH_NAME = "Name"; //Name of column storing church's name.

        //Declare default value public constants.
        public const string NO_TEAM = "no team"; //Value if quizzer isn't on a team.
        public const string NO_CHURCH = "no church"; //Value if quizzer or team isn't associated with a church.

        //Declare current query names public constants.
        public const string ALL_INFO = "all"; //Query by all info.
        public const string ALL_QUIZ_LEVELS = ""; //Get both levels.

        #endregion

        #region Methods

        //Method which returns an array of all calculation methods.
        public static string[] GetAllQuizzerScoresCalculationMethodsArray()
        {
            //Declare and initialize array of calculation methods.
            string[] calculationMethods = new string[]
            {
                NUMBER_QUESTIONS_CORRECT_METHOD,
                NUMBER_POINTS_METHOD,
                PERFECT_ROUNDS_METHOD,
                SCORE_LEVEL_METHOD,
                PERCENT_CORRECT_METHOD
            };

            //Return array of calculation methods.
            return calculationMethods;
        }

        //Method which returns array of only universal calculation methods.
        public static string[] GetUniversalQuizzerScoresCalculationMethodsArray()
        {
            //Declare and initialize array of universal calculation methods.
            string[] calculationMethods = new string[]
            {
                NUMBER_QUESTIONS_CORRECT_METHOD,
                NUMBER_POINTS_METHOD
            };

            //Return array of calculation methods.
            return calculationMethods;
        }

        //Method which returns an array of all team scores calculation methods.
        public static string[] GetAllTeamScoresCalculationMethodsArray()
        {
            //Declare and initialize array to team calculation methods.
            string[] teamCalculationMethods = new string[]
            {
                TOTAL_POINTS_USING_QUIZZER_SCORES_DATABASE_METHOD,
                TOTAL_POINTS_USING_ONLY_TEAMS_DATABASE_METHOD
            };

            //Return team calculation methods.
            return teamCalculationMethods;
        }

        //Method which returns number of perfect rounds.
        public static int CalculateNumberOfPerfectRounds(int[] questionsCorrectInEachRound, int[] totalQuestionsInEachRound)
        {
            //Declare and initialize accumulator variable to store total number of perfect rounds.
            int totalPerfectRounds = 0;

            //For each element in number question correct in round array
            for (int i = 0; i < questionsCorrectInEachRound.Length; ++i)
            {
                //If number questions correct in this round equals total number of questions in this round
                if (questionsCorrectInEachRound[i] == totalQuestionsInEachRound[i])
                {
                    totalPerfectRounds += 1; //Increment total perfect rounds accumulator variable.
                }
            }

            //Return total number of perfect rounds.
            return totalPerfectRounds;
        }

        //Method which returns score level based on percent correct and number of perfect rounds.
        public static string CalculateScoreLevel(decimal percentCorrect, int numberOfPerfectRounds)
        {
            //Declare variable to store score level.
            string scoreLevel = string.Empty;

            //Determine score level; set variable to score level
            if (percentCorrect < 80)
            {
                scoreLevel = BRONZE;
            }
            else if (percentCorrect < 90)
            {
                scoreLevel = SILVER;
            }
            else if (numberOfPerfectRounds == 1)
            {
                scoreLevel = GOLD_ONE_PERFECT_ROUND;
            }
            else if (percentCorrect == 100)
            {
                scoreLevel = GOLD_ALL_STAR;
            }
            else
            {
                scoreLevel = GOLD;
            }

            //Return score level.
            return scoreLevel;
        }

        //Method which returns percent correct.
        public static decimal CalculatePercentCorrect(int[] questionsCorrectInEachRound, int[] totalQuestionsInEachRound)
        {
            //Declare variables.
            decimal percentCorrect; //Variable to store percent correct.
            int totalNumberQuestionsCorrect = 0; //Accumulator variable to store number of questions correct.
            int totalNumberQuestionsInQuiz = 0; //Accumulator variable to store total number of questions in quiz.

            //Sum total number of questions answered correctly and total number of questions in entire quiz.
            for (int i = 0; i < totalQuestionsInEachRound.Length; ++i)
            {
                totalNumberQuestionsCorrect += questionsCorrectInEachRound[i];
                totalNumberQuestionsInQuiz += totalQuestionsInEachRound[i];
            }

            //Calculate percent correct.
            percentCorrect = (decimal) totalNumberQuestionsCorrect / totalNumberQuestionsInQuiz * 100;

            //Return percent correct.
            return percentCorrect;
        }

        //Method which calculates total points based on points per question and number of questions correct in each round.
        public static int CalculateTotalPoints(int pointsPerQuestion, int[] questionsCorrectInEachRound)
        {
            //Declare and initialize variables.
            int totalPoints = 0; //Accumulator variable to store total number of points.

            //For each round
            for (int i = 0; i < questionsCorrectInEachRound.Length; ++i)
            {
                totalPoints += questionsCorrectInEachRound[i] * pointsPerQuestion; //Add points for round to total points.
            }

            //Return total points.
            return totalPoints;
        }

        #endregion

    }
}
