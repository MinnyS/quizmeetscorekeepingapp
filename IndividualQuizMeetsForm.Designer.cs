
namespace QuizMeetScorekeeper
{
    partial class IndividualQuizMeetsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label quizMeetIDIdentLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label quizYearLabel;
            System.Windows.Forms.Label curriculumStudyLabel;
            System.Windows.Forms.Label hostChurchIDIdentLabel;
            System.Windows.Forms.Label redLevelRound1TotalQuestionsLabel;
            System.Windows.Forms.Label redLevelRound2TotalQuestionsLabel;
            System.Windows.Forms.Label blueLevelRound1TotalQuestionsLabel;
            System.Windows.Forms.Label blueLevelRound2TotalQuestionsLabel;
            System.Windows.Forms.Label redLevelPointsPerQuestionLabel;
            System.Windows.Forms.Label blueLevelPointsPerQuestionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualQuizMeetsForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.quizMeetDataSet = new QuizMeetScorekeeper.QuizMeetDataSet();
            this.quizMeetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizMeetsTableAdapter = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.QuizMeetsTableAdapter();
            this.tableAdapterManager = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TableAdapterManager();
            this.quizMeetsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quizMeetsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.quizMeetIDLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quizYearTextBox = new System.Windows.Forms.TextBox();
            this.curriculumStudyComboBox = new System.Windows.Forms.ComboBox();
            this.redLevelRound1TotalQuestionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.redLevelRound2TotalQuestionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueLevelRound1TotalQuestionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueLevelRound2TotalQuestionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.redLevelPointsPerQuestionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueLevelPointsPerQuestionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hostChurchComboBox = new System.Windows.Forms.ComboBox();
            this.hostChurchIDLabel = new System.Windows.Forms.Label();
            this.churchesTableAdapter = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.ChurchesTableAdapter();
            quizMeetIDIdentLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            quizYearLabel = new System.Windows.Forms.Label();
            curriculumStudyLabel = new System.Windows.Forms.Label();
            hostChurchIDIdentLabel = new System.Windows.Forms.Label();
            redLevelRound1TotalQuestionsLabel = new System.Windows.Forms.Label();
            redLevelRound2TotalQuestionsLabel = new System.Windows.Forms.Label();
            blueLevelRound1TotalQuestionsLabel = new System.Windows.Forms.Label();
            blueLevelRound2TotalQuestionsLabel = new System.Windows.Forms.Label();
            redLevelPointsPerQuestionLabel = new System.Windows.Forms.Label();
            blueLevelPointsPerQuestionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetsBindingNavigator)).BeginInit();
            this.quizMeetsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redLevelRound1TotalQuestionsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLevelRound2TotalQuestionsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLevelRound1TotalQuestionsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLevelRound2TotalQuestionsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLevelPointsPerQuestionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLevelPointsPerQuestionNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // quizMeetIDIdentLabel
            // 
            quizMeetIDIdentLabel.AutoSize = true;
            quizMeetIDIdentLabel.Location = new System.Drawing.Point(29, 45);
            quizMeetIDIdentLabel.Name = "quizMeetIDIdentLabel";
            quizMeetIDIdentLabel.Size = new System.Drawing.Size(103, 21);
            quizMeetIDIdentLabel.TabIndex = 18;
            quizMeetIDIdentLabel.Text = "Quiz Meet ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(29, 91);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 21);
            nameLabel.TabIndex = 20;
            nameLabel.Text = "&Name:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(29, 137);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(45, 21);
            dateLabel.TabIndex = 22;
            dateLabel.Text = "&Date:";
            // 
            // quizYearLabel
            // 
            quizYearLabel.AutoSize = true;
            quizYearLabel.Location = new System.Drawing.Point(26, 229);
            quizYearLabel.Name = "quizYearLabel";
            quizYearLabel.Size = new System.Drawing.Size(79, 21);
            quizYearLabel.TabIndex = 24;
            quizYearLabel.Text = "Quiz &Year:";
            // 
            // curriculumStudyLabel
            // 
            curriculumStudyLabel.AutoSize = true;
            curriculumStudyLabel.Location = new System.Drawing.Point(26, 275);
            curriculumStudyLabel.Name = "curriculumStudyLabel";
            curriculumStudyLabel.Size = new System.Drawing.Size(134, 21);
            curriculumStudyLabel.TabIndex = 26;
            curriculumStudyLabel.Text = "Curriculum &Study:";
            // 
            // hostChurchIDIdentLabel
            // 
            hostChurchIDIdentLabel.AutoSize = true;
            hostChurchIDIdentLabel.Location = new System.Drawing.Point(29, 183);
            hostChurchIDIdentLabel.Name = "hostChurchIDIdentLabel";
            hostChurchIDIdentLabel.Size = new System.Drawing.Size(118, 21);
            hostChurchIDIdentLabel.TabIndex = 27;
            hostChurchIDIdentLabel.Text = "&Host Church ID:";
            // 
            // redLevelRound1TotalQuestionsLabel
            // 
            redLevelRound1TotalQuestionsLabel.AutoSize = true;
            redLevelRound1TotalQuestionsLabel.Location = new System.Drawing.Point(26, 321);
            redLevelRound1TotalQuestionsLabel.Name = "redLevelRound1TotalQuestionsLabel";
            redLevelRound1TotalQuestionsLabel.Size = new System.Drawing.Size(253, 21);
            redLevelRound1TotalQuestionsLabel.TabIndex = 28;
            redLevelRound1TotalQuestionsLabel.Text = "Red Level Round 1 &Total Questions:";
            // 
            // redLevelRound2TotalQuestionsLabel
            // 
            redLevelRound2TotalQuestionsLabel.AutoSize = true;
            redLevelRound2TotalQuestionsLabel.Location = new System.Drawing.Point(26, 367);
            redLevelRound2TotalQuestionsLabel.Name = "redLevelRound2TotalQuestionsLabel";
            redLevelRound2TotalQuestionsLabel.Size = new System.Drawing.Size(253, 21);
            redLevelRound2TotalQuestionsLabel.TabIndex = 29;
            redLevelRound2TotalQuestionsLabel.Text = "Red Level Round 2 T&otal Questions:";
            // 
            // blueLevelRound1TotalQuestionsLabel
            // 
            blueLevelRound1TotalQuestionsLabel.AutoSize = true;
            blueLevelRound1TotalQuestionsLabel.Location = new System.Drawing.Point(26, 413);
            blueLevelRound1TotalQuestionsLabel.Name = "blueLevelRound1TotalQuestionsLabel";
            blueLevelRound1TotalQuestionsLabel.Size = new System.Drawing.Size(256, 21);
            blueLevelRound1TotalQuestionsLabel.TabIndex = 30;
            blueLevelRound1TotalQuestionsLabel.Text = "Blue Level Round 1 To&tal Questions:";
            // 
            // blueLevelRound2TotalQuestionsLabel
            // 
            blueLevelRound2TotalQuestionsLabel.AutoSize = true;
            blueLevelRound2TotalQuestionsLabel.Location = new System.Drawing.Point(26, 459);
            blueLevelRound2TotalQuestionsLabel.Name = "blueLevelRound2TotalQuestionsLabel";
            blueLevelRound2TotalQuestionsLabel.Size = new System.Drawing.Size(256, 21);
            blueLevelRound2TotalQuestionsLabel.TabIndex = 31;
            blueLevelRound2TotalQuestionsLabel.Text = "Blue Level Round 2 Tot&al Questions:";
            // 
            // redLevelPointsPerQuestionLabel
            // 
            redLevelPointsPerQuestionLabel.AutoSize = true;
            redLevelPointsPerQuestionLabel.Location = new System.Drawing.Point(26, 505);
            redLevelPointsPerQuestionLabel.Name = "redLevelPointsPerQuestionLabel";
            redLevelPointsPerQuestionLabel.Size = new System.Drawing.Size(219, 21);
            redLevelPointsPerQuestionLabel.TabIndex = 32;
            redLevelPointsPerQuestionLabel.Text = "Red Level &Points Per Question:";
            // 
            // blueLevelPointsPerQuestionLabel
            // 
            blueLevelPointsPerQuestionLabel.AutoSize = true;
            blueLevelPointsPerQuestionLabel.Location = new System.Drawing.Point(29, 554);
            blueLevelPointsPerQuestionLabel.Name = "blueLevelPointsPerQuestionLabel";
            blueLevelPointsPerQuestionLabel.Size = new System.Drawing.Size(222, 21);
            blueLevelPointsPerQuestionLabel.TabIndex = 33;
            blueLevelPointsPerQuestionLabel.Text = "Blue Level Points P&er Question:";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(554, 602);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // quizMeetDataSet
            // 
            this.quizMeetDataSet.DataSetName = "QuizMeetDataSet";
            this.quizMeetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quizMeetsBindingSource
            // 
            this.quizMeetsBindingSource.DataMember = "QuizMeets";
            this.quizMeetsBindingSource.DataSource = this.quizMeetDataSet;
            this.quizMeetsBindingSource.PositionChanged += new System.EventHandler(this.QuizMeetsBindingSource_PositionChanged);
            // 
            // quizMeetsTableAdapter
            // 
            this.quizMeetsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChurchesTableAdapter = null;
            this.tableAdapterManager.QuizMeetsTableAdapter = this.quizMeetsTableAdapter;
            this.tableAdapterManager.QuizzerScoresTableAdapter = null;
            this.tableAdapterManager.QuizzersTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // quizMeetsBindingNavigator
            // 
            this.quizMeetsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.quizMeetsBindingNavigator.BindingSource = this.quizMeetsBindingSource;
            this.quizMeetsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.quizMeetsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.quizMeetsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.quizMeetsBindingNavigatorSaveItem});
            this.quizMeetsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.quizMeetsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.quizMeetsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.quizMeetsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.quizMeetsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.quizMeetsBindingNavigator.Name = "quizMeetsBindingNavigator";
            this.quizMeetsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.quizMeetsBindingNavigator.Size = new System.Drawing.Size(649, 27);
            this.quizMeetsBindingNavigator.TabIndex = 18;
            this.quizMeetsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // quizMeetsBindingNavigatorSaveItem
            // 
            this.quizMeetsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quizMeetsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("quizMeetsBindingNavigatorSaveItem.Image")));
            this.quizMeetsBindingNavigatorSaveItem.Name = "quizMeetsBindingNavigatorSaveItem";
            this.quizMeetsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.quizMeetsBindingNavigatorSaveItem.Text = "Save Data";
            this.quizMeetsBindingNavigatorSaveItem.Click += new System.EventHandler(this.QuizMeetsBindingNavigatorSaveItem_Click);
            // 
            // quizMeetIDLabel
            // 
            this.quizMeetIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizMeetsBindingSource, "QuizMeetID", true));
            this.quizMeetIDLabel.Location = new System.Drawing.Point(284, 45);
            this.quizMeetIDLabel.Name = "quizMeetIDLabel";
            this.quizMeetIDLabel.Size = new System.Drawing.Size(200, 23);
            this.quizMeetIDLabel.TabIndex = 19;
            this.quizMeetIDLabel.Text = "ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizMeetsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(284, 84);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(318, 29);
            this.nameTextBox.TabIndex = 21;
            this.nameTextBox.Enter += new System.EventHandler(this.NameTextBox_Enter);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.quizMeetsBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(284, 129);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(318, 29);
            this.dateDateTimePicker.TabIndex = 23;
            // 
            // quizYearTextBox
            // 
            this.quizYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizMeetsBindingSource, "QuizYear", true));
            this.quizYearTextBox.Location = new System.Drawing.Point(288, 227);
            this.quizYearTextBox.Name = "quizYearTextBox";
            this.quizYearTextBox.Size = new System.Drawing.Size(314, 29);
            this.quizYearTextBox.TabIndex = 25;
            // 
            // curriculumStudyComboBox
            // 
            this.curriculumStudyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizMeetsBindingSource, "CurriculumStudy", true));
            this.curriculumStudyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.curriculumStudyComboBox.FormattingEnabled = true;
            this.curriculumStudyComboBox.Items.AddRange(new object[] {
            "Genesis",
            "Exodus",
            "Joshua, Judges, and Ruth",
            "I & II Samuel",
            "Matthew",
            "Acts"});
            this.curriculumStudyComboBox.Location = new System.Drawing.Point(288, 272);
            this.curriculumStudyComboBox.Name = "curriculumStudyComboBox";
            this.curriculumStudyComboBox.Size = new System.Drawing.Size(314, 29);
            this.curriculumStudyComboBox.TabIndex = 27;
            // 
            // redLevelRound1TotalQuestionsNumericUpDown
            // 
            this.redLevelRound1TotalQuestionsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.quizMeetsBindingSource, "RedLevelRound1TotalQuestions", true));
            this.redLevelRound1TotalQuestionsNumericUpDown.Location = new System.Drawing.Point(288, 319);
            this.redLevelRound1TotalQuestionsNumericUpDown.Name = "redLevelRound1TotalQuestionsNumericUpDown";
            this.redLevelRound1TotalQuestionsNumericUpDown.Size = new System.Drawing.Size(62, 29);
            this.redLevelRound1TotalQuestionsNumericUpDown.TabIndex = 29;
            // 
            // redLevelRound2TotalQuestionsNumericUpDown
            // 
            this.redLevelRound2TotalQuestionsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.quizMeetsBindingSource, "RedLevelRound2TotalQuestions", true));
            this.redLevelRound2TotalQuestionsNumericUpDown.Location = new System.Drawing.Point(288, 365);
            this.redLevelRound2TotalQuestionsNumericUpDown.Name = "redLevelRound2TotalQuestionsNumericUpDown";
            this.redLevelRound2TotalQuestionsNumericUpDown.Size = new System.Drawing.Size(62, 29);
            this.redLevelRound2TotalQuestionsNumericUpDown.TabIndex = 30;
            // 
            // blueLevelRound1TotalQuestionsNumericUpDown
            // 
            this.blueLevelRound1TotalQuestionsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.quizMeetsBindingSource, "BlueLevelRound1TotalQuestions", true));
            this.blueLevelRound1TotalQuestionsNumericUpDown.Location = new System.Drawing.Point(288, 411);
            this.blueLevelRound1TotalQuestionsNumericUpDown.Name = "blueLevelRound1TotalQuestionsNumericUpDown";
            this.blueLevelRound1TotalQuestionsNumericUpDown.Size = new System.Drawing.Size(62, 29);
            this.blueLevelRound1TotalQuestionsNumericUpDown.TabIndex = 31;
            // 
            // blueLevelRound2TotalQuestionsNumericUpDown
            // 
            this.blueLevelRound2TotalQuestionsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.quizMeetsBindingSource, "BlueLevelRound2TotalQuestions", true));
            this.blueLevelRound2TotalQuestionsNumericUpDown.Location = new System.Drawing.Point(288, 457);
            this.blueLevelRound2TotalQuestionsNumericUpDown.Name = "blueLevelRound2TotalQuestionsNumericUpDown";
            this.blueLevelRound2TotalQuestionsNumericUpDown.Size = new System.Drawing.Size(62, 29);
            this.blueLevelRound2TotalQuestionsNumericUpDown.TabIndex = 32;
            // 
            // redLevelPointsPerQuestionNumericUpDown
            // 
            this.redLevelPointsPerQuestionNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.quizMeetsBindingSource, "RedLevelPointsPerQuestion", true));
            this.redLevelPointsPerQuestionNumericUpDown.Location = new System.Drawing.Point(288, 503);
            this.redLevelPointsPerQuestionNumericUpDown.Name = "redLevelPointsPerQuestionNumericUpDown";
            this.redLevelPointsPerQuestionNumericUpDown.Size = new System.Drawing.Size(62, 29);
            this.redLevelPointsPerQuestionNumericUpDown.TabIndex = 33;
            // 
            // blueLevelPointsPerQuestionNumericUpDown
            // 
            this.blueLevelPointsPerQuestionNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.quizMeetsBindingSource, "BlueLevelPointsPerQuestion", true));
            this.blueLevelPointsPerQuestionNumericUpDown.Location = new System.Drawing.Point(288, 552);
            this.blueLevelPointsPerQuestionNumericUpDown.Name = "blueLevelPointsPerQuestionNumericUpDown";
            this.blueLevelPointsPerQuestionNumericUpDown.Size = new System.Drawing.Size(62, 29);
            this.blueLevelPointsPerQuestionNumericUpDown.TabIndex = 34;
            // 
            // hostChurchComboBox
            // 
            this.hostChurchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hostChurchComboBox.FormattingEnabled = true;
            this.hostChurchComboBox.Location = new System.Drawing.Point(329, 177);
            this.hostChurchComboBox.Name = "hostChurchComboBox";
            this.hostChurchComboBox.Size = new System.Drawing.Size(273, 29);
            this.hostChurchComboBox.TabIndex = 35;
            this.hostChurchComboBox.SelectedIndexChanged += new System.EventHandler(this.HostChurchComboBox_SelectedIndexChanged);
            // 
            // hostChurchIDLabel
            // 
            this.hostChurchIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizMeetsBindingSource, "HostChurchID", true));
            this.hostChurchIDLabel.Location = new System.Drawing.Point(284, 177);
            this.hostChurchIDLabel.Name = "hostChurchIDLabel";
            this.hostChurchIDLabel.Size = new System.Drawing.Size(39, 23);
            this.hostChurchIDLabel.TabIndex = 36;
            this.hostChurchIDLabel.Text = "ID";
            // 
            // churchesTableAdapter
            // 
            this.churchesTableAdapter.ClearBeforeFill = true;
            // 
            // IndividualQuizMeetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(649, 654);
            this.Controls.Add(this.hostChurchIDLabel);
            this.Controls.Add(this.hostChurchComboBox);
            this.Controls.Add(blueLevelPointsPerQuestionLabel);
            this.Controls.Add(this.blueLevelPointsPerQuestionNumericUpDown);
            this.Controls.Add(redLevelPointsPerQuestionLabel);
            this.Controls.Add(this.redLevelPointsPerQuestionNumericUpDown);
            this.Controls.Add(blueLevelRound2TotalQuestionsLabel);
            this.Controls.Add(this.blueLevelRound2TotalQuestionsNumericUpDown);
            this.Controls.Add(blueLevelRound1TotalQuestionsLabel);
            this.Controls.Add(this.blueLevelRound1TotalQuestionsNumericUpDown);
            this.Controls.Add(redLevelRound2TotalQuestionsLabel);
            this.Controls.Add(this.redLevelRound2TotalQuestionsNumericUpDown);
            this.Controls.Add(redLevelRound1TotalQuestionsLabel);
            this.Controls.Add(this.redLevelRound1TotalQuestionsNumericUpDown);
            this.Controls.Add(hostChurchIDIdentLabel);
            this.Controls.Add(quizMeetIDIdentLabel);
            this.Controls.Add(this.quizMeetIDLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(quizYearLabel);
            this.Controls.Add(this.quizYearTextBox);
            this.Controls.Add(curriculumStudyLabel);
            this.Controls.Add(this.curriculumStudyComboBox);
            this.Controls.Add(this.quizMeetsBindingNavigator);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IndividualQuizMeetsForm";
            this.Text = "IndividualQuizMeetsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IndividualQuizMeetsForm_FormClosing);
            this.Load += new System.EventHandler(this.IndividualQuizMeetsForm_Load);
            this.Shown += new System.EventHandler(this.IndividualQuizMeetsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetsBindingNavigator)).EndInit();
            this.quizMeetsBindingNavigator.ResumeLayout(false);
            this.quizMeetsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redLevelRound1TotalQuestionsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLevelRound2TotalQuestionsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLevelRound1TotalQuestionsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLevelRound2TotalQuestionsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLevelPointsPerQuestionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLevelPointsPerQuestionNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private QuizMeetDataSet quizMeetDataSet;
        private System.Windows.Forms.BindingSource quizMeetsBindingSource;
        private QuizMeetDataSetTableAdapters.QuizMeetsTableAdapter quizMeetsTableAdapter;
        private QuizMeetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator quizMeetsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton quizMeetsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label quizMeetIDLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox quizYearTextBox;
        private System.Windows.Forms.ComboBox curriculumStudyComboBox;
        private System.Windows.Forms.NumericUpDown redLevelRound1TotalQuestionsNumericUpDown;
        private System.Windows.Forms.NumericUpDown redLevelRound2TotalQuestionsNumericUpDown;
        private System.Windows.Forms.NumericUpDown blueLevelRound1TotalQuestionsNumericUpDown;
        private System.Windows.Forms.NumericUpDown blueLevelRound2TotalQuestionsNumericUpDown;
        private System.Windows.Forms.NumericUpDown redLevelPointsPerQuestionNumericUpDown;
        private System.Windows.Forms.NumericUpDown blueLevelPointsPerQuestionNumericUpDown;
        private System.Windows.Forms.ComboBox hostChurchComboBox;
        private System.Windows.Forms.Label hostChurchIDLabel;
        private QuizMeetDataSetTableAdapters.ChurchesTableAdapter churchesTableAdapter;
    }
}