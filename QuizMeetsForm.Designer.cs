
namespace QuizMeetScorekeeper
{
    partial class QuizMeetsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizMeetsForm));
            this.quizMeetsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.quizMeetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.quizMeetsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.quizMeetsDataGridView = new System.Windows.Forms.DataGridView();
            this.editIndividuallyButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.quizMeetsTableAdapter = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.QuizMeetsTableAdapter();
            this.tableAdapterManager = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostChurchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurriculumStudy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RedLevelRound1TotalQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedLevelRound2TotalQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlueLevelRound1TotalQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlueLevelRound2TotalQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedLevelPointsPerQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlueLevelPointsPerQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetsBindingNavigator)).BeginInit();
            this.quizMeetsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quizMeetsBindingNavigator
            // 
            this.quizMeetsBindingNavigator.AddNewItem = null;
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
            this.quizMeetsBindingNavigator.Size = new System.Drawing.Size(1408, 27);
            this.quizMeetsBindingNavigator.TabIndex = 0;
            this.quizMeetsBindingNavigator.Text = "bindingNavigator1";
            // 
            // quizMeetsBindingSource
            // 
            this.quizMeetsBindingSource.DataMember = "QuizMeets";
            this.quizMeetsBindingSource.DataSource = this.quizMeetDataSet;
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
            this.bindingNavigatorAddNewItem.Text = "Add New Quiz Meet";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
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
            // quizMeetsDataGridView
            // 
            this.quizMeetsDataGridView.AllowUserToAddRows = false;
            this.quizMeetsDataGridView.AllowUserToOrderColumns = true;
            this.quizMeetsDataGridView.AutoGenerateColumns = false;
            this.quizMeetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quizMeetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.HostChurchName,
            this.dataGridViewTextBoxColumn4,
            this.CurriculumStudy,
            this.RedLevelRound1TotalQuestions,
            this.RedLevelRound2TotalQuestions,
            this.BlueLevelRound1TotalQuestions,
            this.BlueLevelRound2TotalQuestions,
            this.RedLevelPointsPerQuestion,
            this.BlueLevelPointsPerQuestion});
            this.quizMeetsDataGridView.DataSource = this.quizMeetsBindingSource;
            this.quizMeetsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizMeetsDataGridView.Location = new System.Drawing.Point(0, 27);
            this.quizMeetsDataGridView.Name = "quizMeetsDataGridView";
            this.quizMeetsDataGridView.Size = new System.Drawing.Size(1408, 528);
            this.quizMeetsDataGridView.TabIndex = 1;
            // 
            // editIndividuallyButton
            // 
            this.editIndividuallyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editIndividuallyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editIndividuallyButton.Location = new System.Drawing.Point(1083, 19);
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
            this.exitButton.Location = new System.Drawing.Point(1321, 19);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.editIndividuallyButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 492);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1408, 63);
            this.panel1.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "QuizMeetID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quiz Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quiz Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 103;
            // 
            // HostChurchName
            // 
            this.HostChurchName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HostChurchName.DataPropertyName = "HostChurchName";
            this.HostChurchName.HeaderText = "Host Church";
            this.HostChurchName.Name = "HostChurchName";
            this.HostChurchName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QuizYear";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quiz Year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 101;
            // 
            // CurriculumStudy
            // 
            this.CurriculumStudy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CurriculumStudy.DataPropertyName = "CurriculumStudy";
            this.CurriculumStudy.HeaderText = "Curriculum Study";
            this.CurriculumStudy.Items.AddRange(new object[] {
            "Genesis",
            "Exodus",
            "Joshua, Judges, and Ruth",
            "I & II Samuel",
            "Matthew",
            "Acts"});
            this.CurriculumStudy.Name = "CurriculumStudy";
            this.CurriculumStudy.Width = 123;
            // 
            // RedLevelRound1TotalQuestions
            // 
            this.RedLevelRound1TotalQuestions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RedLevelRound1TotalQuestions.DataPropertyName = "RedLevelRound1TotalQuestions";
            this.RedLevelRound1TotalQuestions.HeaderText = "Red Round 1 Total Questions";
            this.RedLevelRound1TotalQuestions.Name = "RedLevelRound1TotalQuestions";
            // 
            // RedLevelRound2TotalQuestions
            // 
            this.RedLevelRound2TotalQuestions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RedLevelRound2TotalQuestions.DataPropertyName = "RedLevelRound2TotalQuestions";
            this.RedLevelRound2TotalQuestions.HeaderText = "Red Round 2 Total Questions";
            this.RedLevelRound2TotalQuestions.Name = "RedLevelRound2TotalQuestions";
            // 
            // BlueLevelRound1TotalQuestions
            // 
            this.BlueLevelRound1TotalQuestions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BlueLevelRound1TotalQuestions.DataPropertyName = "BlueLevelRound1TotalQuestions";
            this.BlueLevelRound1TotalQuestions.HeaderText = "Blue Round 1 Total Questions";
            this.BlueLevelRound1TotalQuestions.Name = "BlueLevelRound1TotalQuestions";
            // 
            // BlueLevelRound2TotalQuestions
            // 
            this.BlueLevelRound2TotalQuestions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BlueLevelRound2TotalQuestions.DataPropertyName = "BlueLevelRound2TotalQuestions";
            this.BlueLevelRound2TotalQuestions.HeaderText = "Blue Round 2 Total Questions";
            this.BlueLevelRound2TotalQuestions.Name = "BlueLevelRound2TotalQuestions";
            // 
            // RedLevelPointsPerQuestion
            // 
            this.RedLevelPointsPerQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RedLevelPointsPerQuestion.DataPropertyName = "RedLevelPointsPerQuestion";
            this.RedLevelPointsPerQuestion.HeaderText = "Red Question Points";
            this.RedLevelPointsPerQuestion.Name = "RedLevelPointsPerQuestion";
            // 
            // BlueLevelPointsPerQuestion
            // 
            this.BlueLevelPointsPerQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BlueLevelPointsPerQuestion.DataPropertyName = "BlueLevelPointsPerQuestion";
            this.BlueLevelPointsPerQuestion.HeaderText = "Blue Question Points";
            this.BlueLevelPointsPerQuestion.Name = "BlueLevelPointsPerQuestion";
            // 
            // QuizMeetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1408, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quizMeetsDataGridView);
            this.Controls.Add(this.quizMeetsBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuizMeetsForm";
            this.Text = "Edit Quiz Meets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizMeetsForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizMeetsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetsBindingNavigator)).EndInit();
            this.quizMeetsBindingNavigator.ResumeLayout(false);
            this.quizMeetsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuizMeetDataSet quizMeetDataSet;
        private System.Windows.Forms.BindingSource quizMeetsBindingSource;
        private QuizMeetDataSetTableAdapters.QuizMeetsTableAdapter quizMeetsTableAdapter;
        private QuizMeetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator quizMeetsBindingNavigator;
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
        private System.Windows.Forms.DataGridView quizMeetsDataGridView;
        private System.Windows.Forms.Button editIndividuallyButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostChurchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn CurriculumStudy;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedLevelRound1TotalQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedLevelRound2TotalQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlueLevelRound1TotalQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlueLevelRound2TotalQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedLevelPointsPerQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlueLevelPointsPerQuestion;
    }
}