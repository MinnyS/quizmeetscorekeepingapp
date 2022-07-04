
namespace QuizMeetScorekeeper
{
    partial class QuizzerScoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizzerScoresForm));
            this.quizzerScoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.quizzerScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizMeetDataSet = new QuizMeetScorekeeper.QuizMeetDataSet();
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
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.quizzerScoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.quizzerScoresDataGridView = new System.Windows.Forms.DataGridView();
            this.editIndividuallyButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateQuizzerScoresButton = new System.Windows.Forms.Button();
            this.calculationMethodComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generateCSVFileButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateCSVFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editIndividuallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuizzerScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateQuestionsCorrectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateNumberOfPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelBothLevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countScoreLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countBronzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countSilverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countAllGoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countGoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countGoldWithOnePerfectRoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countGoldAllStarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizzerScoresTableAdapter = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.QuizzerScoresTableAdapter();
            this.tableAdapterManager = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuizzerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuizzerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuizLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChurchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuizMeetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreLevel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PercentCorrect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quizzerScoresBindingNavigator)).BeginInit();
            this.quizzerScoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizzerScoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizzerScoresDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quizzerScoresBindingNavigator
            // 
            this.quizzerScoresBindingNavigator.AddNewItem = null;
            this.quizzerScoresBindingNavigator.BindingSource = this.quizzerScoresBindingSource;
            this.quizzerScoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.quizzerScoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.quizzerScoresBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.quizzerScoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.quizzerScoresBindingNavigatorSaveItem});
            this.quizzerScoresBindingNavigator.Location = new System.Drawing.Point(323, 1);
            this.quizzerScoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.quizzerScoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.quizzerScoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.quizzerScoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.quizzerScoresBindingNavigator.Name = "quizzerScoresBindingNavigator";
            this.quizzerScoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.quizzerScoresBindingNavigator.Size = new System.Drawing.Size(288, 27);
            this.quizzerScoresBindingNavigator.TabIndex = 0;
            this.quizzerScoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // quizzerScoresBindingSource
            // 
            this.quizzerScoresBindingSource.DataMember = "QuizzerScores";
            this.quizzerScoresBindingSource.DataSource = this.quizMeetDataSet;
            // 
            // quizMeetDataSet
            // 
            this.quizMeetDataSet.DataSetName = "QuizMeetDataSet";
            this.quizMeetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::QuizMeetScorekeeper.Properties.Resources.bindingNavigatorAddNewItem_Image;
            this.bindingNavigatorAddNewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "toolStripButton1";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // quizzerScoresBindingNavigatorSaveItem
            // 
            this.quizzerScoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quizzerScoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("quizzerScoresBindingNavigatorSaveItem.Image")));
            this.quizzerScoresBindingNavigatorSaveItem.Name = "quizzerScoresBindingNavigatorSaveItem";
            this.quizzerScoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.quizzerScoresBindingNavigatorSaveItem.Text = "Save Data";
            this.quizzerScoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.QuizzerScoresBindingNavigatorSaveItem_Click);
            // 
            // quizzerScoresDataGridView
            // 
            this.quizzerScoresDataGridView.AllowUserToAddRows = false;
            this.quizzerScoresDataGridView.AllowUserToOrderColumns = true;
            this.quizzerScoresDataGridView.AutoGenerateColumns = false;
            this.quizzerScoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quizzerScoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.QuizzerFirstName,
            this.QuizzerLastName,
            this.QuizLevel,
            this.ChurchName,
            this.QuizMeetName,
            this.TeamName,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.ScoreLevel,
            this.PercentCorrect,
            this.TotalPoints});
            this.quizzerScoresDataGridView.DataSource = this.quizzerScoresBindingSource;
            this.quizzerScoresDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizzerScoresDataGridView.Location = new System.Drawing.Point(0, 28);
            this.quizzerScoresDataGridView.Name = "quizzerScoresDataGridView";
            this.quizzerScoresDataGridView.Size = new System.Drawing.Size(1394, 508);
            this.quizzerScoresDataGridView.TabIndex = 1;
            // 
            // editIndividuallyButton
            // 
            this.editIndividuallyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editIndividuallyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editIndividuallyButton.Location = new System.Drawing.Point(1114, 24);
            this.editIndividuallyButton.Name = "editIndividuallyButton";
            this.editIndividuallyButton.Size = new System.Drawing.Size(140, 32);
            this.editIndividuallyButton.TabIndex = 17;
            this.editIndividuallyButton.Text = "Edit &Individually";
            this.editIndividuallyButton.UseVisualStyleBackColor = true;
            this.editIndividuallyButton.Click += new System.EventHandler(this.EditIndividuallyButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(1307, 24);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // calculateQuizzerScoresButton
            // 
            this.calculateQuizzerScoresButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateQuizzerScoresButton.Location = new System.Drawing.Point(625, 24);
            this.calculateQuizzerScoresButton.Name = "calculateQuizzerScoresButton";
            this.calculateQuizzerScoresButton.Size = new System.Drawing.Size(207, 32);
            this.calculateQuizzerScoresButton.TabIndex = 18;
            this.calculateQuizzerScoresButton.Text = "Calculate Quizzer Scores";
            this.calculateQuizzerScoresButton.UseVisualStyleBackColor = true;
            this.calculateQuizzerScoresButton.Click += new System.EventHandler(this.CalculateQuizzerScoresButton_Click);
            // 
            // calculationMethodComboBox
            // 
            this.calculationMethodComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculationMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calculationMethodComboBox.FormattingEnabled = true;
            this.calculationMethodComboBox.Location = new System.Drawing.Point(208, 24);
            this.calculationMethodComboBox.Name = "calculationMethodComboBox";
            this.calculationMethodComboBox.Size = new System.Drawing.Size(411, 29);
            this.calculationMethodComboBox.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.generateCSVFileButton);
            this.panel1.Controls.Add(this.editIndividuallyButton);
            this.panel1.Controls.Add(this.calculationMethodComboBox);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.calculateQuizzerScoresButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 68);
            this.panel1.TabIndex = 28;
            // 
            // generateCSVFileButton
            // 
            this.generateCSVFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateCSVFileButton.Location = new System.Drawing.Point(907, 24);
            this.generateCSVFileButton.Name = "generateCSVFileButton";
            this.generateCSVFileButton.Size = new System.Drawing.Size(142, 32);
            this.generateCSVFileButton.TabIndex = 28;
            this.generateCSVFileButton.Text = "&Generate CSV File";
            this.generateCSVFileButton.UseVisualStyleBackColor = true;
            this.generateCSVFileButton.Click += new System.EventHandler(this.GenerateCSVFileButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.levelToolStripMenuItem,
            this.countToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1394, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateCSVFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // generateCSVFileToolStripMenuItem
            // 
            this.generateCSVFileToolStripMenuItem.Name = "generateCSVFileToolStripMenuItem";
            this.generateCSVFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.generateCSVFileToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.generateCSVFileToolStripMenuItem.Text = "&Generate CSV File";
            this.generateCSVFileToolStripMenuItem.Click += new System.EventHandler(this.GenerateCSVFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editIndividuallyToolStripMenuItem,
            this.addQuizzerScoreToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // editIndividuallyToolStripMenuItem
            // 
            this.editIndividuallyToolStripMenuItem.Name = "editIndividuallyToolStripMenuItem";
            this.editIndividuallyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.editIndividuallyToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.editIndividuallyToolStripMenuItem.Text = "Edit &Individually";
            this.editIndividuallyToolStripMenuItem.Click += new System.EventHandler(this.EditIndividuallyToolStripMenuItem_Click);
            // 
            // addQuizzerScoreToolStripMenuItem
            // 
            this.addQuizzerScoreToolStripMenuItem.Name = "addQuizzerScoreToolStripMenuItem";
            this.addQuizzerScoreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addQuizzerScoreToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.addQuizzerScoreToolStripMenuItem.Text = "&Add Quizzer Score";
            this.addQuizzerScoreToolStripMenuItem.Click += new System.EventHandler(this.AddQuizzerScoreToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateQuestionsCorrectToolStripMenuItem,
            this.calculateNumberOfPointsToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            // 
            // calculateQuestionsCorrectToolStripMenuItem
            // 
            this.calculateQuestionsCorrectToolStripMenuItem.Name = "calculateQuestionsCorrectToolStripMenuItem";
            this.calculateQuestionsCorrectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.calculateQuestionsCorrectToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.calculateQuestionsCorrectToolStripMenuItem.Text = "&Questions Correct";
            this.calculateQuestionsCorrectToolStripMenuItem.Click += new System.EventHandler(this.CalculateQuestionsCorrectToolStripMenuItem_Click);
            // 
            // calculateNumberOfPointsToolStripMenuItem
            // 
            this.calculateNumberOfPointsToolStripMenuItem.Name = "calculateNumberOfPointsToolStripMenuItem";
            this.calculateNumberOfPointsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.calculateNumberOfPointsToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.calculateNumberOfPointsToolStripMenuItem.Text = "Number of &Points";
            this.calculateNumberOfPointsToolStripMenuItem.Click += new System.EventHandler(this.CalculateNumberOfPointsToolStripMenuItem_Click);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelBothLevelsToolStripMenuItem,
            this.levelRedToolStripMenuItem,
            this.levelBlueToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.levelToolStripMenuItem.Text = "&Level";
            // 
            // levelBothLevelsToolStripMenuItem
            // 
            this.levelBothLevelsToolStripMenuItem.Checked = true;
            this.levelBothLevelsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.levelBothLevelsToolStripMenuItem.Name = "levelBothLevelsToolStripMenuItem";
            this.levelBothLevelsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.levelBothLevelsToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.levelBothLevelsToolStripMenuItem.Text = "B&oth Levels";
            this.levelBothLevelsToolStripMenuItem.Click += new System.EventHandler(this.LevelBothLevelsToolStripMenuItem_Click);
            // 
            // levelRedToolStripMenuItem
            // 
            this.levelRedToolStripMenuItem.Name = "levelRedToolStripMenuItem";
            this.levelRedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.levelRedToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.levelRedToolStripMenuItem.Text = "&Red Level";
            this.levelRedToolStripMenuItem.Click += new System.EventHandler(this.LevelRedToolStripMenuItem_Click);
            // 
            // levelBlueToolStripMenuItem
            // 
            this.levelBlueToolStripMenuItem.Name = "levelBlueToolStripMenuItem";
            this.levelBlueToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.levelBlueToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.levelBlueToolStripMenuItem.Text = "&Blue Level";
            this.levelBlueToolStripMenuItem.Click += new System.EventHandler(this.LevelBlueToolStripMenuItem_Click);
            // 
            // countToolStripMenuItem
            // 
            this.countToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countScoreLevelToolStripMenuItem});
            this.countToolStripMenuItem.Name = "countToolStripMenuItem";
            this.countToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.countToolStripMenuItem.Text = "Cou&nt";
            // 
            // countScoreLevelToolStripMenuItem
            // 
            this.countScoreLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countBronzeToolStripMenuItem,
            this.countSilverToolStripMenuItem,
            this.countAllGoldToolStripMenuItem,
            this.countGoldToolStripMenuItem,
            this.countGoldWithOnePerfectRoundToolStripMenuItem,
            this.countGoldAllStarToolStripMenuItem});
            this.countScoreLevelToolStripMenuItem.Name = "countScoreLevelToolStripMenuItem";
            this.countScoreLevelToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.countScoreLevelToolStripMenuItem.Text = "&Score Level";
            this.countScoreLevelToolStripMenuItem.Click += new System.EventHandler(this.CountScoreLevelToolStripMenuItem_Click);
            // 
            // countBronzeToolStripMenuItem
            // 
            this.countBronzeToolStripMenuItem.Name = "countBronzeToolStripMenuItem";
            this.countBronzeToolStripMenuItem.Size = new System.Drawing.Size(269, 24);
            this.countBronzeToolStripMenuItem.Text = "&Bronze";
            this.countBronzeToolStripMenuItem.Click += new System.EventHandler(this.CountBronzeToolStripMenuItem_Click);
            // 
            // countSilverToolStripMenuItem
            // 
            this.countSilverToolStripMenuItem.Name = "countSilverToolStripMenuItem";
            this.countSilverToolStripMenuItem.Size = new System.Drawing.Size(269, 24);
            this.countSilverToolStripMenuItem.Text = "&Silver";
            this.countSilverToolStripMenuItem.Click += new System.EventHandler(this.CountSilverToolStripMenuItem_Click);
            // 
            // countAllGoldToolStripMenuItem
            // 
            this.countAllGoldToolStripMenuItem.Name = "countAllGoldToolStripMenuItem";
            this.countAllGoldToolStripMenuItem.Size = new System.Drawing.Size(269, 24);
            this.countAllGoldToolStripMenuItem.Text = "&All Gold";
            this.countAllGoldToolStripMenuItem.Click += new System.EventHandler(this.CountAllGoldToolStripMenuItem_Click);
            // 
            // countGoldToolStripMenuItem
            // 
            this.countGoldToolStripMenuItem.Name = "countGoldToolStripMenuItem";
            this.countGoldToolStripMenuItem.Size = new System.Drawing.Size(269, 24);
            this.countGoldToolStripMenuItem.Text = "&Gold";
            this.countGoldToolStripMenuItem.Click += new System.EventHandler(this.CountGoldToolStripMenuItem_Click);
            // 
            // countGoldWithOnePerfectRoundToolStripMenuItem
            // 
            this.countGoldWithOnePerfectRoundToolStripMenuItem.Name = "countGoldWithOnePerfectRoundToolStripMenuItem";
            this.countGoldWithOnePerfectRoundToolStripMenuItem.Size = new System.Drawing.Size(269, 24);
            this.countGoldWithOnePerfectRoundToolStripMenuItem.Text = "Gold with One Perfect &Round";
            this.countGoldWithOnePerfectRoundToolStripMenuItem.Click += new System.EventHandler(this.CountGoldWithOnePerfectRoundToolStripMenuItem_Click);
            // 
            // countGoldAllStarToolStripMenuItem
            // 
            this.countGoldAllStarToolStripMenuItem.Name = "countGoldAllStarToolStripMenuItem";
            this.countGoldAllStarToolStripMenuItem.Size = new System.Drawing.Size(269, 24);
            this.countGoldAllStarToolStripMenuItem.Text = "Gold All-&Star";
            this.countGoldAllStarToolStripMenuItem.Click += new System.EventHandler(this.CountGoldAllStarToolStripMenuItem_Click);
            // 
            // quizzerScoresTableAdapter
            // 
            this.quizzerScoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChurchesTableAdapter = null;
            this.tableAdapterManager.QuizMeetsTableAdapter = null;
            this.tableAdapterManager.QuizzerScoresTableAdapter = this.quizzerScoresTableAdapter;
            this.tableAdapterManager.QuizzersTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "QuizzerScoreID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // QuizzerFirstName
            // 
            this.QuizzerFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuizzerFirstName.DataPropertyName = "QuizzerFirstName";
            this.QuizzerFirstName.HeaderText = "First Name";
            this.QuizzerFirstName.Name = "QuizzerFirstName";
            this.QuizzerFirstName.ReadOnly = true;
            // 
            // QuizzerLastName
            // 
            this.QuizzerLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuizzerLastName.DataPropertyName = "QuizzerLastName";
            this.QuizzerLastName.HeaderText = "Last Name";
            this.QuizzerLastName.Name = "QuizzerLastName";
            this.QuizzerLastName.ReadOnly = true;
            // 
            // QuizLevel
            // 
            this.QuizLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuizLevel.DataPropertyName = "QuizLevel";
            this.QuizLevel.HeaderText = "Quiz Level";
            this.QuizLevel.Name = "QuizLevel";
            this.QuizLevel.ReadOnly = true;
            // 
            // ChurchName
            // 
            this.ChurchName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChurchName.DataPropertyName = "ChurchName";
            this.ChurchName.HeaderText = "Church Name";
            this.ChurchName.Name = "ChurchName";
            this.ChurchName.ReadOnly = true;
            // 
            // QuizMeetName
            // 
            this.QuizMeetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuizMeetName.DataPropertyName = "QuizMeetName";
            this.QuizMeetName.HeaderText = "Quiz Meet Name";
            this.QuizMeetName.Name = "QuizMeetName";
            this.QuizMeetName.ReadOnly = true;
            // 
            // TeamName
            // 
            this.TeamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamName.DataPropertyName = "TeamName";
            this.TeamName.HeaderText = "Team Name";
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Round1NumberQuestionsCorrect";
            this.dataGridViewTextBoxColumn4.HeaderText = "Round 1 No. Correct";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Round1Points";
            this.dataGridViewTextBoxColumn5.HeaderText = "Round 1 Points";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Round2NumberQuestionsCorrect";
            this.dataGridViewTextBoxColumn6.HeaderText = "Round 2 No. Correct";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Round2Points";
            this.dataGridViewTextBoxColumn7.HeaderText = "Round 2 Points";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PerfectRounds";
            this.dataGridViewTextBoxColumn8.HeaderText = "Perfect Rounds";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // ScoreLevel
            // 
            this.ScoreLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScoreLevel.DataPropertyName = "ScoreLevel";
            this.ScoreLevel.HeaderText = "Score Level";
            this.ScoreLevel.Items.AddRange(new object[] {
            "Undetermined",
            "Bronze",
            "Silver",
            "Gold",
            "Gold with One Perfect Round",
            "Gold All-Star"});
            this.ScoreLevel.Name = "ScoreLevel";
            // 
            // PercentCorrect
            // 
            this.PercentCorrect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PercentCorrect.DataPropertyName = "PercentCorrect";
            this.PercentCorrect.HeaderText = "% Correct";
            this.PercentCorrect.Name = "PercentCorrect";
            // 
            // TotalPoints
            // 
            this.TotalPoints.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPoints.DataPropertyName = "TotalPoints";
            this.TotalPoints.HeaderText = "Total Points";
            this.TotalPoints.Name = "TotalPoints";
            this.TotalPoints.ReadOnly = true;
            // 
            // QuizzerScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1394, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quizzerScoresDataGridView);
            this.Controls.Add(this.quizzerScoresBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuizzerScoresForm";
            this.Text = "Edit Quizzer Scores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizzerScoresForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizzerScoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizzerScoresBindingNavigator)).EndInit();
            this.quizzerScoresBindingNavigator.ResumeLayout(false);
            this.quizzerScoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizzerScoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizzerScoresDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuizMeetDataSet quizMeetDataSet;
        private System.Windows.Forms.BindingSource quizzerScoresBindingSource;
        private QuizMeetDataSetTableAdapters.QuizzerScoresTableAdapter quizzerScoresTableAdapter;
        private QuizMeetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator quizzerScoresBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton quizzerScoresBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView quizzerScoresDataGridView;
        private System.Windows.Forms.Button editIndividuallyButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateQuizzerScoresButton;
        private System.Windows.Forms.ComboBox calculationMethodComboBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button generateCSVFileButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateCSVFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editIndividuallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQuizzerScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateQuestionsCorrectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateNumberOfPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelBothLevelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countScoreLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countGoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countSilverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countBronzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countGoldAllStarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countGoldWithOnePerfectRoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countAllGoldToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuizzerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuizzerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuizLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChurchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuizMeetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn ScoreLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentCorrect;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPoints;
    }
}