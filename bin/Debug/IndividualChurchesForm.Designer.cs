
namespace QuizMeetScorekeeper
{
    partial class IndividualChurchesForm
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
            System.Windows.Forms.Label churchIDIdentLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label quizCoachLabel;
            System.Windows.Forms.Label contactInfoLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label regionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualChurchesForm));
            this.quizMeetDataSet = new QuizMeetScorekeeper.QuizMeetDataSet();
            this.churchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.churchesTableAdapter = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.ChurchesTableAdapter();
            this.tableAdapterManager = new QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TableAdapterManager();
            this.churchesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.churchesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.churchIDLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.quizCoachTextBox = new System.Windows.Forms.TextBox();
            this.contactInfoTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            churchIDIdentLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            quizCoachLabel = new System.Windows.Forms.Label();
            contactInfoLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchesBindingNavigator)).BeginInit();
            this.churchesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // churchIDIdentLabel
            // 
            churchIDIdentLabel.AutoSize = true;
            churchIDIdentLabel.Location = new System.Drawing.Point(37, 61);
            churchIDIdentLabel.Name = "churchIDIdentLabel";
            churchIDIdentLabel.Size = new System.Drawing.Size(82, 21);
            churchIDIdentLabel.TabIndex = 1;
            churchIDIdentLabel.Text = "Church ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(37, 104);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 21);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "&Name:";
            // 
            // quizCoachLabel
            // 
            quizCoachLabel.AutoSize = true;
            quizCoachLabel.Location = new System.Drawing.Point(37, 147);
            quizCoachLabel.Name = "quizCoachLabel";
            quizCoachLabel.Size = new System.Drawing.Size(92, 21);
            quizCoachLabel.TabIndex = 5;
            quizCoachLabel.Text = "&Quiz Coach:";
            // 
            // contactInfoLabel
            // 
            contactInfoLabel.AutoSize = true;
            contactInfoLabel.Location = new System.Drawing.Point(37, 190);
            contactInfoLabel.Name = "contactInfoLabel";
            contactInfoLabel.Size = new System.Drawing.Size(97, 21);
            contactInfoLabel.TabIndex = 7;
            contactInfoLabel.Text = "&Contact Info:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(37, 233);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(72, 21);
            locationLabel.TabIndex = 9;
            locationLabel.Text = "&Location:";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new System.Drawing.Point(37, 276);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(62, 21);
            regionLabel.TabIndex = 11;
            regionLabel.Text = "&Region:";
            // 
            // quizMeetDataSet
            // 
            this.quizMeetDataSet.DataSetName = "QuizMeetDataSet";
            this.quizMeetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // churchesBindingSource
            // 
            this.churchesBindingSource.DataMember = "Churches";
            this.churchesBindingSource.DataSource = this.quizMeetDataSet;
            // 
            // churchesTableAdapter
            // 
            this.churchesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChurchesTableAdapter = this.churchesTableAdapter;
            this.tableAdapterManager.QuizMeetsTableAdapter = null;
            this.tableAdapterManager.QuizzerScoresTableAdapter = null;
            this.tableAdapterManager.QuizzersTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuizMeetScorekeeper.QuizMeetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // churchesBindingNavigator
            // 
            this.churchesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.churchesBindingNavigator.BindingSource = this.churchesBindingSource;
            this.churchesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.churchesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.churchesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.churchesBindingNavigatorSaveItem});
            this.churchesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.churchesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.churchesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.churchesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.churchesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.churchesBindingNavigator.Name = "churchesBindingNavigator";
            this.churchesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.churchesBindingNavigator.Size = new System.Drawing.Size(502, 27);
            this.churchesBindingNavigator.TabIndex = 0;
            this.churchesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // churchesBindingNavigatorSaveItem
            // 
            this.churchesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.churchesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("churchesBindingNavigatorSaveItem.Image")));
            this.churchesBindingNavigatorSaveItem.Name = "churchesBindingNavigatorSaveItem";
            this.churchesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.churchesBindingNavigatorSaveItem.Text = "Save Data";
            this.churchesBindingNavigatorSaveItem.Click += new System.EventHandler(this.ChurchesBindingNavigatorSaveItem_Click);
            // 
            // churchIDLabel
            // 
            this.churchIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.churchesBindingSource, "ChurchID", true));
            this.churchIDLabel.Location = new System.Drawing.Point(140, 61);
            this.churchIDLabel.Name = "churchIDLabel";
            this.churchIDLabel.Size = new System.Drawing.Size(100, 23);
            this.churchIDLabel.TabIndex = 2;
            this.churchIDLabel.Text = "ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.churchesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(140, 98);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(254, 29);
            this.nameTextBox.TabIndex = 4;
            // 
            // quizCoachTextBox
            // 
            this.quizCoachTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.churchesBindingSource, "QuizCoach", true));
            this.quizCoachTextBox.Location = new System.Drawing.Point(140, 141);
            this.quizCoachTextBox.Name = "quizCoachTextBox";
            this.quizCoachTextBox.Size = new System.Drawing.Size(254, 29);
            this.quizCoachTextBox.TabIndex = 6;
            // 
            // contactInfoTextBox
            // 
            this.contactInfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.churchesBindingSource, "ContactInfo", true));
            this.contactInfoTextBox.Location = new System.Drawing.Point(140, 184);
            this.contactInfoTextBox.Name = "contactInfoTextBox";
            this.contactInfoTextBox.Size = new System.Drawing.Size(254, 29);
            this.contactInfoTextBox.TabIndex = 8;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.churchesBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(140, 227);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(254, 29);
            this.locationTextBox.TabIndex = 10;
            // 
            // regionTextBox
            // 
            this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.churchesBindingSource, "Region", true));
            this.regionTextBox.Location = new System.Drawing.Point(140, 270);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(254, 29);
            this.regionTextBox.TabIndex = 12;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(415, 331);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // IndividualChurchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(502, 375);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(churchIDIdentLabel);
            this.Controls.Add(this.churchIDLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(quizCoachLabel);
            this.Controls.Add(this.quizCoachTextBox);
            this.Controls.Add(contactInfoLabel);
            this.Controls.Add(this.contactInfoTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(regionLabel);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(this.churchesBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IndividualChurchesForm";
            this.Text = "Edit Individual Churches";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IndividualChurchesForm_FormClosing);
            this.Load += new System.EventHandler(this.IndividualChurchesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizMeetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.churchesBindingNavigator)).EndInit();
            this.churchesBindingNavigator.ResumeLayout(false);
            this.churchesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuizMeetDataSet quizMeetDataSet;
        private System.Windows.Forms.BindingSource churchesBindingSource;
        private QuizMeetDataSetTableAdapters.ChurchesTableAdapter churchesTableAdapter;
        private QuizMeetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator churchesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton churchesBindingNavigatorSaveItem;
        private System.Windows.Forms.Label churchIDLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox quizCoachTextBox;
        private System.Windows.Forms.TextBox contactInfoTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}