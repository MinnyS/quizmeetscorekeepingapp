
namespace QuizMeetScorekeeper
{
    partial class TeamsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamsForm));
            this.teamsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.teamsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.teamsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuizMeetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChurchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editIndividuallyButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.teamsTableAdapter = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TeamsTableAdapter();
            this.tableAdapterManager = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TableAdapterManager();
            this.calculateTeamScoresButton = new System.Windows.Forms.Button();
            this.quizzerScoresTableAdapter = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.QuizzerScoresTableAdapter();
            this.teamScoresCalculationMethodComboBox = new System.Windows.Forms.ComboBox();
            this.mainButtonsPanel = new System.Windows.Forms.Panel();
            this.generateCSVFileButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingNavigator)).BeginInit();
            this.teamsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).BeginInit();
            this.mainButtonsPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.teamsBindingNavigator.Size = new System.Drawing.Size(1180, 27);
            this.teamsBindingNavigator.TabIndex = 0;
            this.teamsBindingNavigator.Text = "bindingNavigator1";
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.quizMeetDataSet;
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
            this.bindingNavigatorAddNewItem.Text = "Add New Team";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
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
            // teamsDataGridView
            // 
            this.teamsDataGridView.AllowUserToAddRows = false;
            this.teamsDataGridView.AllowUserToOrderColumns = true;
            this.teamsDataGridView.AutoGenerateColumns = false;
            this.teamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TeamName,
            this.QuizMeetName,
            this.ChurchName,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.teamsDataGridView.DataSource = this.teamsBindingSource;
            this.teamsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamsDataGridView.Location = new System.Drawing.Point(0, 27);
            this.teamsDataGridView.Name = "teamsDataGridView";
            this.teamsDataGridView.RowHeadersWidth = 82;
            this.teamsDataGridView.Size = new System.Drawing.Size(1180, 597);
            this.teamsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TeamID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // TeamName
            // 
            this.TeamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamName.DataPropertyName = "TeamName";
            this.TeamName.HeaderText = "Team Name";
            this.TeamName.MinimumWidth = 10;
            this.TeamName.Name = "TeamName";
            // 
            // QuizMeetName
            // 
            this.QuizMeetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QuizMeetName.DataPropertyName = "QuizMeetName";
            this.QuizMeetName.HeaderText = "Quiz Meet Name";
            this.QuizMeetName.Name = "QuizMeetName";
            this.QuizMeetName.ReadOnly = true;
            this.QuizMeetName.Width = 139;
            // 
            // ChurchName
            // 
            this.ChurchName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ChurchName.DataPropertyName = "ChurchName";
            this.ChurchName.HeaderText = "Church Name";
            this.ChurchName.Name = "ChurchName";
            this.ChurchName.ReadOnly = true;
            this.ChurchName.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Round1BonusPoints";
            this.dataGridViewTextBoxColumn5.HeaderText = "Round 1 Bonus Points";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 132;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Round1TeamPoints";
            this.dataGridViewTextBoxColumn6.HeaderText = "Round 1 Team Points";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 126;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Round2BonusPoints";
            this.dataGridViewTextBoxColumn7.HeaderText = "Round 2 Bonus Points";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 132;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Round2TeamPoints";
            this.dataGridViewTextBoxColumn8.HeaderText = "Round 2 Team Points";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 126;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TotalPoints";
            this.dataGridViewTextBoxColumn9.HeaderText = "Total Points";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 104;
            // 
            // editIndividuallyButton
            // 
            this.editIndividuallyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editIndividuallyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editIndividuallyButton.Location = new System.Drawing.Point(734, 17);
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
            this.exitButton.Location = new System.Drawing.Point(1093, 17);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            // calculateTeamScoresButton
            // 
            this.calculateTeamScoresButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateTeamScoresButton.Location = new System.Drawing.Point(505, 15);
            this.calculateTeamScoresButton.Name = "calculateTeamScoresButton";
            this.calculateTeamScoresButton.Size = new System.Drawing.Size(193, 32);
            this.calculateTeamScoresButton.TabIndex = 18;
            this.calculateTeamScoresButton.Text = "&Calculate Team Scores";
            this.calculateTeamScoresButton.UseVisualStyleBackColor = true;
            this.calculateTeamScoresButton.Click += new System.EventHandler(this.CalculateTeamScoresButton_Click);
            // 
            // quizzerScoresTableAdapter
            // 
            this.quizzerScoresTableAdapter.ClearBeforeFill = true;
            // 
            // teamScoresCalculationMethodComboBox
            // 
            this.teamScoresCalculationMethodComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.teamScoresCalculationMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamScoresCalculationMethodComboBox.FormattingEnabled = true;
            this.teamScoresCalculationMethodComboBox.Location = new System.Drawing.Point(15, 15);
            this.teamScoresCalculationMethodComboBox.Name = "teamScoresCalculationMethodComboBox";
            this.teamScoresCalculationMethodComboBox.Size = new System.Drawing.Size(484, 29);
            this.teamScoresCalculationMethodComboBox.TabIndex = 19;
            // 
            // mainButtonsPanel
            // 
            this.mainButtonsPanel.Controls.Add(this.generateCSVFileButton);
            this.mainButtonsPanel.Controls.Add(this.teamScoresCalculationMethodComboBox);
            this.mainButtonsPanel.Controls.Add(this.editIndividuallyButton);
            this.mainButtonsPanel.Controls.Add(this.calculateTeamScoresButton);
            this.mainButtonsPanel.Controls.Add(this.exitButton);
            this.mainButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainButtonsPanel.Location = new System.Drawing.Point(0, 563);
            this.mainButtonsPanel.Name = "mainButtonsPanel";
            this.mainButtonsPanel.Size = new System.Drawing.Size(1180, 61);
            this.mainButtonsPanel.TabIndex = 20;
            // 
            // generateCSVFileButton
            // 
            this.generateCSVFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateCSVFileButton.Location = new System.Drawing.Point(915, 17);
            this.generateCSVFileButton.Name = "generateCSVFileButton";
            this.generateCSVFileButton.Size = new System.Drawing.Size(142, 32);
            this.generateCSVFileButton.TabIndex = 21;
            this.generateCSVFileButton.Text = "&Generate CSV File";
            this.generateCSVFileButton.UseVisualStyleBackColor = true;
            this.generateCSVFileButton.Click += new System.EventHandler(this.GenerateCSVFileButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TeamsForm
            // 
            this.AcceptButton = this.calculateTeamScoresButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1180, 624);
            this.Controls.Add(this.mainButtonsPanel);
            this.Controls.Add(this.teamsDataGridView);
            this.Controls.Add(this.teamsBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeamsForm";
            this.Text = "Edit Teams";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamsForm_FormClosing);
            this.Load += new System.EventHandler(this.TeamsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingNavigator)).EndInit();
            this.teamsBindingNavigator.ResumeLayout(false);
            this.teamsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).EndInit();
            this.mainButtonsPanel.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView teamsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button editIndividuallyButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateTeamScoresButton;
        private QuizMeetDataSetTableAdapters.QuizzerScoresTableAdapter quizzerScoresTableAdapter;
        private System.Windows.Forms.ComboBox teamScoresCalculationMethodComboBox;
        private System.Windows.Forms.Panel mainButtonsPanel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuizMeetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChurchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button generateCSVFileButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}