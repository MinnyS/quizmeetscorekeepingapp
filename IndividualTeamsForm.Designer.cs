
namespace QuizMeetScorekeeper
{
    partial class IndividualTeamsForm
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
            System.Windows.Forms.Label teamIDIdentLabel;
            System.Windows.Forms.Label teamNameLabel;
            System.Windows.Forms.Label quizMeetIDIdentLabel;
            System.Windows.Forms.Label churchIDIdentLabel;
            System.Windows.Forms.Label round1BonusPointsLabel;
            System.Windows.Forms.Label round1TeamPointsLabel;
            System.Windows.Forms.Label round2BonusPointsLabel;
            System.Windows.Forms.Label round2TeamPointsLabel;
            System.Windows.Forms.Label totalPointsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualTeamsForm));
            this.teamsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.teamsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.teamIDLabel = new System.Windows.Forms.Label();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.quizMeetComboBox = new System.Windows.Forms.ComboBox();
            this.churchComboBox = new System.Windows.Forms.ComboBox();
            this.round1BonusPointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.round1TeamPointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.round2BonusPointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.round2TeamPointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalPointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateTeamScoreButton = new System.Windows.Forms.Button();
            this.teamScoresCalculationMethodComboBox = new System.Windows.Forms.ComboBox();
            this.quizMeetIDLabel = new System.Windows.Forms.Label();
            this.churchIDLabel = new System.Windows.Forms.Label();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizMeetDataSet = new QuizMeetScorekeeper.QuizMeetDataSet();
            this.teamsTableAdapter = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TeamsTableAdapter();
            this.tableAdapterManager = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TableAdapterManager();
            this.quizzerScoresTableAdapter = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.QuizzerScoresTableAdapter();
            this.quizMeetsTableAdapter = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.QuizMeetsTableAdapter();
            this.churchesTableAdapter = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.ChurchesTableAdapter();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            teamIDIdentLabel = new System.Windows.Forms.Label();
            teamNameLabel = new System.Windows.Forms.Label();
            quizMeetIDIdentLabel = new System.Windows.Forms.Label();
            churchIDIdentLabel = new System.Windows.Forms.Label();
            round1BonusPointsLabel = new System.Windows.Forms.Label();
            round1TeamPointsLabel = new System.Windows.Forms.Label();
            round2BonusPointsLabel = new System.Windows.Forms.Label();
            round2TeamPointsLabel = new System.Windows.Forms.Label();
            totalPointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingNavigator)).BeginInit();
            this.teamsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.round1BonusPointsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.round1TeamPointsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.round2BonusPointsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.round2TeamPointsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPointsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // teamIDIdentLabel
            // 
            teamIDIdentLabel.AutoSize = true;
            teamIDIdentLabel.Location = new System.Drawing.Point(24, 42);
            teamIDIdentLabel.Name = "teamIDIdentLabel";
            teamIDIdentLabel.Size = new System.Drawing.Size(68, 21);
            teamIDIdentLabel.TabIndex = 1;
            teamIDIdentLabel.Text = "Team ID:";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Location = new System.Drawing.Point(24, 85);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new System.Drawing.Size(95, 21);
            teamNameLabel.TabIndex = 3;
            teamNameLabel.Text = "Team &Name:";
            // 
            // quizMeetIDIdentLabel
            // 
            quizMeetIDIdentLabel.AutoSize = true;
            quizMeetIDIdentLabel.Location = new System.Drawing.Point(24, 128);
            quizMeetIDIdentLabel.Name = "quizMeetIDIdentLabel";
            quizMeetIDIdentLabel.Size = new System.Drawing.Size(103, 21);
            quizMeetIDIdentLabel.TabIndex = 5;
            quizMeetIDIdentLabel.Text = "&Quiz Meet ID:";
            // 
            // churchIDIdentLabel
            // 
            churchIDIdentLabel.AutoSize = true;
            churchIDIdentLabel.Location = new System.Drawing.Point(24, 171);
            churchIDIdentLabel.Name = "churchIDIdentLabel";
            churchIDIdentLabel.Size = new System.Drawing.Size(82, 21);
            churchIDIdentLabel.TabIndex = 7;
            churchIDIdentLabel.Text = "&Church ID:";
            // 
            // round1BonusPointsLabel
            // 
            round1BonusPointsLabel.AutoSize = true;
            round1BonusPointsLabel.Location = new System.Drawing.Point(24, 214);
            round1BonusPointsLabel.Name = "round1BonusPointsLabel";
            round1BonusPointsLabel.Size = new System.Drawing.Size(165, 21);
            round1BonusPointsLabel.TabIndex = 9;
            round1BonusPointsLabel.Text = "Round 1 &Bonus Points:";
            // 
            // round1TeamPointsLabel
            // 
            round1TeamPointsLabel.AutoSize = true;
            round1TeamPointsLabel.Location = new System.Drawing.Point(24, 257);
            round1TeamPointsLabel.Name = "round1TeamPointsLabel";
            round1TeamPointsLabel.Size = new System.Drawing.Size(158, 21);
            round1TeamPointsLabel.TabIndex = 11;
            round1TeamPointsLabel.Text = "Round 1 &Team Points:";
            // 
            // round2BonusPointsLabel
            // 
            round2BonusPointsLabel.AutoSize = true;
            round2BonusPointsLabel.Location = new System.Drawing.Point(24, 300);
            round2BonusPointsLabel.Name = "round2BonusPointsLabel";
            round2BonusPointsLabel.Size = new System.Drawing.Size(165, 21);
            round2BonusPointsLabel.TabIndex = 13;
            round2BonusPointsLabel.Text = "Round 2 Bonus &Points:";
            // 
            // round2TeamPointsLabel
            // 
            round2TeamPointsLabel.AutoSize = true;
            round2TeamPointsLabel.Location = new System.Drawing.Point(24, 343);
            round2TeamPointsLabel.Name = "round2TeamPointsLabel";
            round2TeamPointsLabel.Size = new System.Drawing.Size(158, 21);
            round2TeamPointsLabel.TabIndex = 15;
            round2TeamPointsLabel.Text = "Round 2 Team P&oints:";
            // 
            // totalPointsLabel
            // 
            totalPointsLabel.AutoSize = true;
            totalPointsLabel.Location = new System.Drawing.Point(24, 386);
            totalPointsLabel.Name = "totalPointsLabel";
            totalPointsLabel.Size = new System.Drawing.Size(91, 21);
            totalPointsLabel.TabIndex = 17;
            totalPointsLabel.Text = "&Total Points:";
            // 
            // teamsBindingNavigator
            // 
            this.teamsBindingNavigator.AddNewItem = null;
            this.teamsBindingNavigator.BindingSource = this.teamsBindingSource;
            this.teamsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teamsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teamsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.teamsBindingNavigatorSaveItem});
            this.teamsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teamsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teamsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teamsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teamsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teamsBindingNavigator.Name = "teamsBindingNavigator";
            this.teamsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teamsBindingNavigator.Size = new System.Drawing.Size(823, 27);
            this.teamsBindingNavigator.TabIndex = 0;
            this.teamsBindingNavigator.Text = "bindingNavigator1";
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
            // teamsBindingNavigatorSaveItem
            // 
            this.teamsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teamsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teamsBindingNavigatorSaveItem.Image")));
            this.teamsBindingNavigatorSaveItem.Name = "teamsBindingNavigatorSaveItem";
            this.teamsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.teamsBindingNavigatorSaveItem.Text = "Save Data";
            this.teamsBindingNavigatorSaveItem.Click += new System.EventHandler(this.TeamsBindingNavigatorSaveItem_Click);
            // 
            // teamIDLabel
            // 
            this.teamIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "TeamID", true));
            this.teamIDLabel.Location = new System.Drawing.Point(198, 42);
            this.teamIDLabel.Name = "teamIDLabel";
            this.teamIDLabel.Size = new System.Drawing.Size(121, 23);
            this.teamIDLabel.TabIndex = 2;
            this.teamIDLabel.Text = "ID";
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "TeamName", true));
            this.teamNameTextBox.Location = new System.Drawing.Point(198, 79);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(496, 29);
            this.teamNameTextBox.TabIndex = 4;
            // 
            // quizMeetComboBox
            // 
            this.quizMeetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quizMeetComboBox.FormattingEnabled = true;
            this.quizMeetComboBox.Location = new System.Drawing.Point(241, 122);
            this.quizMeetComboBox.Name = "quizMeetComboBox";
            this.quizMeetComboBox.Size = new System.Drawing.Size(453, 29);
            this.quizMeetComboBox.TabIndex = 6;
            this.quizMeetComboBox.SelectedIndexChanged += new System.EventHandler(this.QuizMeetComboBox_SelectedIndexChanged);
            // 
            // churchComboBox
            // 
            this.churchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.churchComboBox.FormattingEnabled = true;
            this.churchComboBox.Location = new System.Drawing.Point(241, 165);
            this.churchComboBox.Name = "churchComboBox";
            this.churchComboBox.Size = new System.Drawing.Size(453, 29);
            this.churchComboBox.TabIndex = 8;
            this.churchComboBox.SelectedIndexChanged += new System.EventHandler(this.ChurchComboBox_SelectedIndexChanged);
            // 
            // round1BonusPointsNumericUpDown
            // 
            this.round1BonusPointsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teamsBindingSource, "Round1BonusPoints", true));
            this.round1BonusPointsNumericUpDown.Location = new System.Drawing.Point(198, 208);
            this.round1BonusPointsNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.round1BonusPointsNumericUpDown.Name = "round1BonusPointsNumericUpDown";
            this.round1BonusPointsNumericUpDown.Size = new System.Drawing.Size(102, 29);
            this.round1BonusPointsNumericUpDown.TabIndex = 10;
            // 
            // round1TeamPointsNumericUpDown
            // 
            this.round1TeamPointsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teamsBindingSource, "Round1TeamPoints", true));
            this.round1TeamPointsNumericUpDown.Location = new System.Drawing.Point(198, 251);
            this.round1TeamPointsNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.round1TeamPointsNumericUpDown.Name = "round1TeamPointsNumericUpDown";
            this.round1TeamPointsNumericUpDown.Size = new System.Drawing.Size(102, 29);
            this.round1TeamPointsNumericUpDown.TabIndex = 12;
            // 
            // round2BonusPointsNumericUpDown
            // 
            this.round2BonusPointsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teamsBindingSource, "Round2BonusPoints", true));
            this.round2BonusPointsNumericUpDown.Location = new System.Drawing.Point(198, 294);
            this.round2BonusPointsNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.round2BonusPointsNumericUpDown.Name = "round2BonusPointsNumericUpDown";
            this.round2BonusPointsNumericUpDown.Size = new System.Drawing.Size(102, 29);
            this.round2BonusPointsNumericUpDown.TabIndex = 14;
            // 
            // round2TeamPointsNumericUpDown
            // 
            this.round2TeamPointsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teamsBindingSource, "Round2TeamPoints", true));
            this.round2TeamPointsNumericUpDown.Location = new System.Drawing.Point(198, 337);
            this.round2TeamPointsNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.round2TeamPointsNumericUpDown.Name = "round2TeamPointsNumericUpDown";
            this.round2TeamPointsNumericUpDown.Size = new System.Drawing.Size(102, 29);
            this.round2TeamPointsNumericUpDown.TabIndex = 16;
            // 
            // totalPointsNumericUpDown
            // 
            this.totalPointsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teamsBindingSource, "TotalPoints", true));
            this.totalPointsNumericUpDown.Location = new System.Drawing.Point(198, 380);
            this.totalPointsNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.totalPointsNumericUpDown.Name = "totalPointsNumericUpDown";
            this.totalPointsNumericUpDown.Size = new System.Drawing.Size(102, 29);
            this.totalPointsNumericUpDown.TabIndex = 18;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(736, 430);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // calculateTeamScoreButton
            // 
            this.calculateTeamScoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateTeamScoreButton.Location = new System.Drawing.Point(516, 430);
            this.calculateTeamScoreButton.Name = "calculateTeamScoreButton";
            this.calculateTeamScoreButton.Size = new System.Drawing.Size(178, 32);
            this.calculateTeamScoreButton.TabIndex = 21;
            this.calculateTeamScoreButton.Text = "&Calculate Team Score";
            this.calculateTeamScoreButton.UseVisualStyleBackColor = true;
            this.calculateTeamScoreButton.Click += new System.EventHandler(this.CalculateTeamScoreButton_Click);
            // 
            // teamScoresCalculationMethodComboBox
            // 
            this.teamScoresCalculationMethodComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.teamScoresCalculationMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamScoresCalculationMethodComboBox.FormattingEnabled = true;
            this.teamScoresCalculationMethodComboBox.Location = new System.Drawing.Point(26, 433);
            this.teamScoresCalculationMethodComboBox.Name = "teamScoresCalculationMethodComboBox";
            this.teamScoresCalculationMethodComboBox.Size = new System.Drawing.Size(484, 29);
            this.teamScoresCalculationMethodComboBox.TabIndex = 22;
            // 
            // quizMeetIDLabel
            // 
            this.quizMeetIDLabel.AutoSize = true;
            this.quizMeetIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "QuizMeetID", true));
            this.quizMeetIDLabel.Location = new System.Drawing.Point(194, 125);
            this.quizMeetIDLabel.Name = "quizMeetIDLabel";
            this.quizMeetIDLabel.Size = new System.Drawing.Size(25, 21);
            this.quizMeetIDLabel.TabIndex = 23;
            this.quizMeetIDLabel.Text = "ID";
            // 
            // churchIDLabel
            // 
            this.churchIDLabel.AutoSize = true;
            this.churchIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "ChurchID", true));
            this.churchIDLabel.Location = new System.Drawing.Point(194, 168);
            this.churchIDLabel.Name = "churchIDLabel";
            this.churchIDLabel.Size = new System.Drawing.Size(25, 21);
            this.churchIDLabel.TabIndex = 24;
            this.churchIDLabel.Text = "ID";
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.quizMeetDataSet;
            this.teamsBindingSource.PositionChanged += new System.EventHandler(this.TeamsBindingSource_PositionChanged);
            // 
            // quizMeetDataSet
            // 
            this.quizMeetDataSet.DataSetName = "QuizMeetDataSet";
            this.quizMeetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChurchesTableAdapter = null;
            this.tableAdapterManager.QuizMeetsTableAdapter = null;
            this.tableAdapterManager.QuizzerScoresTableAdapter = null;
            this.tableAdapterManager.QuizzersTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = this.teamsTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // quizzerScoresTableAdapter
            // 
            this.quizzerScoresTableAdapter.ClearBeforeFill = true;
            // 
            // quizMeetsTableAdapter
            // 
            this.quizMeetsTableAdapter.ClearBeforeFill = true;
            // 
            // churchesTableAdapter
            // 
            this.churchesTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::QuizMeetScorekeeper.Properties.Resources.bindingNavigatorAddNewItem_Image;
            this.bindingNavigatorAddNewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add New Team";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // IndividualTeamsForm
            // 
            this.AcceptButton = this.calculateTeamScoreButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(823, 474);
            this.Controls.Add(this.churchIDLabel);
            this.Controls.Add(this.quizMeetIDLabel);
            this.Controls.Add(this.teamScoresCalculationMethodComboBox);
            this.Controls.Add(this.calculateTeamScoreButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(teamIDIdentLabel);
            this.Controls.Add(this.teamIDLabel);
            this.Controls.Add(teamNameLabel);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(quizMeetIDIdentLabel);
            this.Controls.Add(this.quizMeetComboBox);
            this.Controls.Add(churchIDIdentLabel);
            this.Controls.Add(this.churchComboBox);
            this.Controls.Add(round1BonusPointsLabel);
            this.Controls.Add(this.round1BonusPointsNumericUpDown);
            this.Controls.Add(round1TeamPointsLabel);
            this.Controls.Add(this.round1TeamPointsNumericUpDown);
            this.Controls.Add(round2BonusPointsLabel);
            this.Controls.Add(this.round2BonusPointsNumericUpDown);
            this.Controls.Add(round2TeamPointsLabel);
            this.Controls.Add(this.round2TeamPointsNumericUpDown);
            this.Controls.Add(totalPointsLabel);
            this.Controls.Add(this.totalPointsNumericUpDown);
            this.Controls.Add(this.teamsBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IndividualTeamsForm";
            this.Text = "Edit Individual Teams";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IndividualTeamsForm_FormClosing);
            this.Load += new System.EventHandler(this.IndividualTeamsForm_Load);
            this.Shown += new System.EventHandler(this.IndividualTeamsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingNavigator)).EndInit();
            this.teamsBindingNavigator.ResumeLayout(false);
            this.teamsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.round1BonusPointsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.round1TeamPointsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.round2BonusPointsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.round2TeamPointsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPointsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuizMeetDataSet quizMeetDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private QuizMeetDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private QuizMeetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teamsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton teamsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label teamIDLabel;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.ComboBox quizMeetComboBox;
        private System.Windows.Forms.ComboBox churchComboBox;
        private System.Windows.Forms.NumericUpDown round1BonusPointsNumericUpDown;
        private System.Windows.Forms.NumericUpDown round1TeamPointsNumericUpDown;
        private System.Windows.Forms.NumericUpDown round2BonusPointsNumericUpDown;
        private System.Windows.Forms.NumericUpDown round2TeamPointsNumericUpDown;
        private System.Windows.Forms.NumericUpDown totalPointsNumericUpDown;
        private System.Windows.Forms.Button exitButton;
        private QuizMeetDataSetTableAdapters.QuizzerScoresTableAdapter quizzerScoresTableAdapter;
        private System.Windows.Forms.Button calculateTeamScoreButton;
        private System.Windows.Forms.ComboBox teamScoresCalculationMethodComboBox;
        private System.Windows.Forms.Label quizMeetIDLabel;
        private System.Windows.Forms.Label churchIDLabel;
        private QuizMeetDataSetTableAdapters.QuizMeetsTableAdapter quizMeetsTableAdapter;
        private QuizMeetDataSetTableAdapters.ChurchesTableAdapter churchesTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    }
}