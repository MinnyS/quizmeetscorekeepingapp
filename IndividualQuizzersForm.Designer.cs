
namespace QuizMeetScorekeeper
{
    partial class IndividualQuizzersForm
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
            System.Windows.Forms.Label quizzerIDIdentLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label quizLevelLabel;
            System.Windows.Forms.Label churchIDIdentLabel;
            System.Windows.Forms.Label gradeLabel;
            System.Windows.Forms.Label birthdateLabel;
            System.Windows.Forms.Label accommodationsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualQuizzersForm));
            this.quizzersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.quizzersBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.quizzersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.quizzerIDLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.quizLevelComboBox = new System.Windows.Forms.ComboBox();
            this.churchComboBox = new System.Windows.Forms.ComboBox();
            this.gradeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.accommodationsTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.churchIDLabel = new System.Windows.Forms.Label();
            this.tableAdapterManager = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TableAdapterManager();
            this.quizzersTableAdapter = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.QuizzersTableAdapter();
            this.churchesTableAdapter = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.ChurchesTableAdapter();
            quizzerIDIdentLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            quizLevelLabel = new System.Windows.Forms.Label();
            churchIDIdentLabel = new System.Windows.Forms.Label();
            gradeLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            accommodationsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quizzersBindingNavigator)).BeginInit();
            this.quizzersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizzersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // quizzerIDIdentLabel
            // 
            quizzerIDIdentLabel.AutoSize = true;
            quizzerIDIdentLabel.Location = new System.Drawing.Point(21, 48);
            quizzerIDIdentLabel.Name = "quizzerIDIdentLabel";
            quizzerIDIdentLabel.Size = new System.Drawing.Size(85, 21);
            quizzerIDIdentLabel.TabIndex = 1;
            quizzerIDIdentLabel.Text = "Quizzer ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(21, 92);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(89, 21);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "&First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(21, 136);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(87, 21);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "&Last Name:";
            // 
            // quizLevelLabel
            // 
            quizLevelLabel.AutoSize = true;
            quizLevelLabel.Location = new System.Drawing.Point(21, 180);
            quizLevelLabel.Name = "quizLevelLabel";
            quizLevelLabel.Size = new System.Drawing.Size(85, 21);
            quizLevelLabel.TabIndex = 7;
            quizLevelLabel.Text = "Quiz Le&vel:";
            // 
            // churchIDIdentLabel
            // 
            churchIDIdentLabel.AutoSize = true;
            churchIDIdentLabel.Location = new System.Drawing.Point(21, 225);
            churchIDIdentLabel.Name = "churchIDIdentLabel";
            churchIDIdentLabel.Size = new System.Drawing.Size(82, 21);
            churchIDIdentLabel.TabIndex = 9;
            churchIDIdentLabel.Text = "&Church ID:";
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new System.Drawing.Point(21, 269);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(55, 21);
            gradeLabel.TabIndex = 13;
            gradeLabel.Text = "&Grade:";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new System.Drawing.Point(21, 318);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(76, 21);
            birthdateLabel.TabIndex = 15;
            birthdateLabel.Text = "&Birthdate:";
            // 
            // accommodationsLabel
            // 
            accommodationsLabel.AutoSize = true;
            accommodationsLabel.Location = new System.Drawing.Point(21, 360);
            accommodationsLabel.Name = "accommodationsLabel";
            accommodationsLabel.Size = new System.Drawing.Size(134, 21);
            accommodationsLabel.TabIndex = 17;
            accommodationsLabel.Text = "&Accommodations:";
            // 
            // quizzersBindingNavigator
            // 
            this.quizzersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.quizzersBindingNavigator.BindingSource = this.quizzersBindingSource;
            this.quizzersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.quizzersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.quizzersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.quizzersBindingNavigatorSaveItem});
            this.quizzersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.quizzersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.quizzersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.quizzersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.quizzersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.quizzersBindingNavigator.Name = "quizzersBindingNavigator";
            this.quizzersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.quizzersBindingNavigator.Size = new System.Drawing.Size(609, 27);
            this.quizzersBindingNavigator.TabIndex = 0;
            this.quizzersBindingNavigator.Text = "bindingNavigator1";
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
            // quizzersBindingSource
            // 
            this.quizzersBindingSource.DataMember = "Quizzers";
            this.quizzersBindingSource.DataSource = this.quizMeetDataSet;
            this.quizzersBindingSource.PositionChanged += new System.EventHandler(this.QuizzersBindingSource_PositionChanged);
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
            // quizzersBindingNavigatorSaveItem
            // 
            this.quizzersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quizzersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("quizzersBindingNavigatorSaveItem.Image")));
            this.quizzersBindingNavigatorSaveItem.Name = "quizzersBindingNavigatorSaveItem";
            this.quizzersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.quizzersBindingNavigatorSaveItem.Text = "Save Data";
            this.quizzersBindingNavigatorSaveItem.Click += new System.EventHandler(this.QuizzersBindingNavigatorSaveItem_Click);
            // 
            // quizzerIDLabel
            // 
            this.quizzerIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizzersBindingSource, "QuizzerID", true));
            this.quizzerIDLabel.Location = new System.Drawing.Point(161, 48);
            this.quizzerIDLabel.Name = "quizzerIDLabel";
            this.quizzerIDLabel.Size = new System.Drawing.Size(200, 23);
            this.quizzerIDLabel.TabIndex = 2;
            this.quizzerIDLabel.Text = "ID";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizzersBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(161, 87);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(347, 29);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizzersBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(161, 132);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(347, 29);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // quizLevelComboBox
            // 
            this.quizLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizzersBindingSource, "QuizLevel", true));
            this.quizLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quizLevelComboBox.FormattingEnabled = true;
            this.quizLevelComboBox.Items.AddRange(new object[] {
            "Red Level",
            "Blue Level"});
            this.quizLevelComboBox.Location = new System.Drawing.Point(161, 177);
            this.quizLevelComboBox.Name = "quizLevelComboBox";
            this.quizLevelComboBox.Size = new System.Drawing.Size(347, 29);
            this.quizLevelComboBox.TabIndex = 8;
            // 
            // churchComboBox
            // 
            this.churchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.churchComboBox.FormattingEnabled = true;
            this.churchComboBox.Location = new System.Drawing.Point(218, 222);
            this.churchComboBox.Name = "churchComboBox";
            this.churchComboBox.Size = new System.Drawing.Size(290, 29);
            this.churchComboBox.TabIndex = 10;
            this.churchComboBox.SelectedIndexChanged += new System.EventHandler(this.ChurchesComboBox_SelectedIndexChanged);
            // 
            // gradeNumericUpDown
            // 
            this.gradeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.quizzersBindingSource, "Grade", true));
            this.gradeNumericUpDown.Location = new System.Drawing.Point(161, 267);
            this.gradeNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.gradeNumericUpDown.Name = "gradeNumericUpDown";
            this.gradeNumericUpDown.Size = new System.Drawing.Size(51, 29);
            this.gradeNumericUpDown.TabIndex = 14;
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.quizzersBindingSource, "Birthdate", true));
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(161, 312);
            this.birthdateDateTimePicker.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.birthdateDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(347, 29);
            this.birthdateDateTimePicker.TabIndex = 16;
            this.birthdateDateTimePicker.Value = new System.DateTime(2021, 12, 25, 0, 0, 0, 0);
            // 
            // accommodationsTextBox
            // 
            this.accommodationsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizzersBindingSource, "Accommodations", true));
            this.accommodationsTextBox.Location = new System.Drawing.Point(161, 357);
            this.accommodationsTextBox.Name = "accommodationsTextBox";
            this.accommodationsTextBox.Size = new System.Drawing.Size(347, 29);
            this.accommodationsTextBox.TabIndex = 18;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(522, 475);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // churchIDLabel
            // 
            this.churchIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quizzersBindingSource, "ChurchID", true));
            this.churchIDLabel.Location = new System.Drawing.Point(161, 225);
            this.churchIDLabel.Name = "churchIDLabel";
            this.churchIDLabel.Size = new System.Drawing.Size(51, 23);
            this.churchIDLabel.TabIndex = 20;
            this.churchIDLabel.Text = "ID";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChurchesTableAdapter = null;
            this.tableAdapterManager.QuizMeetsTableAdapter = null;
            this.tableAdapterManager.QuizzerScoresTableAdapter = null;
            this.tableAdapterManager.QuizzersTableAdapter = this.quizzersTableAdapter;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // quizzersTableAdapter
            // 
            this.quizzersTableAdapter.ClearBeforeFill = true;
            // 
            // churchesTableAdapter
            // 
            this.churchesTableAdapter.ClearBeforeFill = true;
            // 
            // IndividualQuizzersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(609, 519);
            this.Controls.Add(this.churchIDLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(quizzerIDIdentLabel);
            this.Controls.Add(this.quizzerIDLabel);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(quizLevelLabel);
            this.Controls.Add(this.quizLevelComboBox);
            this.Controls.Add(churchIDIdentLabel);
            this.Controls.Add(this.churchComboBox);
            this.Controls.Add(gradeLabel);
            this.Controls.Add(this.gradeNumericUpDown);
            this.Controls.Add(birthdateLabel);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Controls.Add(accommodationsLabel);
            this.Controls.Add(this.accommodationsTextBox);
            this.Controls.Add(this.quizzersBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IndividualQuizzersForm";
            this.Text = "Individual Quizzers Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IndividualQuizzersForm_FormClosing);
            this.Load += new System.EventHandler(this.IndividualQuizzersForm_Load);
            this.Shown += new System.EventHandler(this.IndividualQuizzersForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.quizzersBindingNavigator)).EndInit();
            this.quizzersBindingNavigator.ResumeLayout(false);
            this.quizzersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizzersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuizMeetDataSet quizMeetDataSet;
        private System.Windows.Forms.BindingSource quizzersBindingSource;
        private QuizMeetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator quizzersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton quizzersBindingNavigatorSaveItem;
        private System.Windows.Forms.Label quizzerIDLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox quizLevelComboBox;
        private System.Windows.Forms.ComboBox churchComboBox;
        private System.Windows.Forms.NumericUpDown gradeNumericUpDown;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.TextBox accommodationsTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label churchIDLabel;
        private QuizMeetDataSetTableAdapters.QuizzersTableAdapter quizzersTableAdapter;
        private QuizMeetDataSetTableAdapters.ChurchesTableAdapter churchesTableAdapter;
    }
}