
namespace QuizMeetScorekeeper
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizMeetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizzerScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizzersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.churchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateQuizzerScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateTeamScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.calculateToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quizMeetsToolStripMenuItem,
            this.quizzerScoresToolStripMenuItem,
            this.quizzersToolStripMenuItem,
            this.teamsToolStripMenuItem,
            this.churchesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // quizMeetsToolStripMenuItem
            // 
            this.quizMeetsToolStripMenuItem.Name = "quizMeetsToolStripMenuItem";
            this.quizMeetsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.quizMeetsToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.quizMeetsToolStripMenuItem.Text = "Quiz &Meets";
            this.quizMeetsToolStripMenuItem.Click += new System.EventHandler(this.QuizMeetsToolStripMenuItem_Click);
            // 
            // quizzerScoresToolStripMenuItem
            // 
            this.quizzerScoresToolStripMenuItem.Name = "quizzerScoresToolStripMenuItem";
            this.quizzerScoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.quizzerScoresToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.quizzerScoresToolStripMenuItem.Text = "Quizzer &Scores";
            this.quizzerScoresToolStripMenuItem.Click += new System.EventHandler(this.QuizzerScoresToolStripMenuItem_Click);
            // 
            // quizzersToolStripMenuItem
            // 
            this.quizzersToolStripMenuItem.Name = "quizzersToolStripMenuItem";
            this.quizzersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quizzersToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.quizzersToolStripMenuItem.Text = "&Quizzers";
            this.quizzersToolStripMenuItem.Click += new System.EventHandler(this.QuizzersToolStripMenuItem_Click);
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.teamsToolStripMenuItem.Text = "&Teams";
            this.teamsToolStripMenuItem.Click += new System.EventHandler(this.TeamsToolStripMenuItem_Click);
            // 
            // churchesToolStripMenuItem
            // 
            this.churchesToolStripMenuItem.Name = "churchesToolStripMenuItem";
            this.churchesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.churchesToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.churchesToolStripMenuItem.Text = "&Churches";
            this.churchesToolStripMenuItem.Click += new System.EventHandler(this.ChurchesToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateQuizzerScoresToolStripMenuItem,
            this.calculateTeamScoresToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            // 
            // calculateQuizzerScoresToolStripMenuItem
            // 
            this.calculateQuizzerScoresToolStripMenuItem.Name = "calculateQuizzerScoresToolStripMenuItem";
            this.calculateQuizzerScoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.calculateQuizzerScoresToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.calculateQuizzerScoresToolStripMenuItem.Text = "Qui&zzer Scores";
            this.calculateQuizzerScoresToolStripMenuItem.Click += new System.EventHandler(this.CalculateQuizzerScoresToolStripMenuItem_Click);
            // 
            // calculateTeamScoresToolStripMenuItem
            // 
            this.calculateTeamScoresToolStripMenuItem.Name = "calculateTeamScoresToolStripMenuItem";
            this.calculateTeamScoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.calculateTeamScoresToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.calculateTeamScoresToolStripMenuItem.Text = "Te&am Scores";
            this.calculateTeamScoresToolStripMenuItem.Click += new System.EventHandler(this.CalculateTeamScoresToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuizMeetScorekeeper.Properties.Resources.dr_digalot_and_canteen;
            this.pictureBox3.Location = new System.Drawing.Point(358, 309);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(484, 352);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuizMeetScorekeeper.Properties.Resources.q_logo;
            this.pictureBox2.Location = new System.Drawing.Point(562, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuizMeetScorekeeper.Properties.Resources.childrens_quiz_text_logo;
            this.pictureBox1.Location = new System.Drawing.Point(438, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.creditsToolStripMenuItem.Text = "C&redits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.CreditsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Quiz Meet Scorekeeper";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizMeetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizzerScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizzersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem churchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateQuizzerScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateTeamScoresToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
    }
}

