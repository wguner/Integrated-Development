namespace CodebaseView
{
    partial class CodebaseView
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
            this.CommitInfo = new System.Windows.Forms.GroupBox();
            this.Options = new System.Windows.Forms.GroupBox();
            this.CodeChanges = new System.Windows.Forms.GroupBox();
            this.Contributors = new System.Windows.Forms.GroupBox();
            this.ContributorsBox = new System.Windows.Forms.ListBox();
            this.Commits = new System.Windows.Forms.GroupBox();
            this.CommitsBox = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Options.SuspendLayout();
            this.Contributors.SuspendLayout();
            this.Commits.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommitInfo
            // 
            this.CommitInfo.AutoSize = true;
            this.CommitInfo.Location = new System.Drawing.Point(12, 12);
            this.CommitInfo.Name = "CommitInfo";
            this.CommitInfo.Size = new System.Drawing.Size(758, 54);
            this.CommitInfo.TabIndex = 0;
            this.CommitInfo.TabStop = false;
            this.CommitInfo.Text = "Commit Info";
            this.CommitInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Options
            // 
            this.Options.AutoSize = true;
            this.Options.Controls.Add(this.button1);
            this.Options.Controls.Add(this.label2);
            this.Options.Controls.Add(this.label1);
            this.Options.Controls.Add(this.dateTimePicker2);
            this.Options.Controls.Add(this.dateTimePicker1);
            this.Options.Location = new System.Drawing.Point(776, 12);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(225, 595);
            this.Options.TabIndex = 1;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            this.Options.Enter += new System.EventHandler(this.Options_Enter);
            // 
            // CodeChanges
            // 
            this.CodeChanges.AutoSize = true;
            this.CodeChanges.Location = new System.Drawing.Point(12, 72);
            this.CodeChanges.Name = "CodeChanges";
            this.CodeChanges.Size = new System.Drawing.Size(530, 411);
            this.CodeChanges.TabIndex = 2;
            this.CodeChanges.TabStop = false;
            this.CodeChanges.Text = "Code / Changes";
            // 
            // Contributors
            // 
            this.Contributors.AutoSize = true;
            this.Contributors.Controls.Add(this.ContributorsBox);
            this.Contributors.Location = new System.Drawing.Point(12, 489);
            this.Contributors.Name = "Contributors";
            this.Contributors.Size = new System.Drawing.Size(758, 119);
            this.Contributors.TabIndex = 3;
            this.Contributors.TabStop = false;
            this.Contributors.Text = "Contributors";
            // 
            // ContributorsBox
            // 
            this.ContributorsBox.FormattingEnabled = true;
            this.ContributorsBox.Location = new System.Drawing.Point(9, 18);
            this.ContributorsBox.Name = "ContributorsBox";
            this.ContributorsBox.ScrollAlwaysVisible = true;
            this.ContributorsBox.Size = new System.Drawing.Size(742, 82);
            this.ContributorsBox.TabIndex = 0;
            this.ContributorsBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Commits
            // 
            this.Commits.AutoSize = true;
            this.Commits.Controls.Add(this.CommitsBox);
            this.Commits.Location = new System.Drawing.Point(548, 72);
            this.Commits.Name = "Commits";
            this.Commits.Size = new System.Drawing.Size(222, 411);
            this.Commits.TabIndex = 4;
            this.Commits.TabStop = false;
            this.Commits.Text = "Commits";
            this.Commits.Enter += new System.EventHandler(this.Commits_Enter);
            // 
            // CommitsBox
            // 
            this.CommitsBox.FormattingEnabled = true;
            this.CommitsBox.Location = new System.Drawing.Point(6, 19);
            this.CommitsBox.Name = "CommitsBox";
            this.CommitsBox.ScrollAlwaysVisible = true;
            this.CommitsBox.Size = new System.Drawing.Size(209, 368);
            this.CommitsBox.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 89);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CodebaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 619);
            this.Controls.Add(this.Commits);
            this.Controls.Add(this.Contributors);
            this.Controls.Add(this.CodeChanges);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.CommitInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CodebaseView";
            this.Text = "Codebase View";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.Contributors.ResumeLayout(false);
            this.Commits.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CommitInfo;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.GroupBox CodeChanges;
        private System.Windows.Forms.GroupBox Contributors;
        private System.Windows.Forms.GroupBox Commits;
        private System.Windows.Forms.ListBox ContributorsBox;
        private System.Windows.Forms.ListBox CommitsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}

