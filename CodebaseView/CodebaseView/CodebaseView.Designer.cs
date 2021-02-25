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
            this.CommitBox = new System.Windows.Forms.GroupBox();
            this.textBoxAuthorCommitInfo = new System.Windows.Forms.TextBox();
            this.textBoxCommitMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Commits = new System.Windows.Forms.GroupBox();
            this.commitsDataGrid = new System.Windows.Forms.DataGridView();
            this.Options = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CommithashBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.selected_file_clicked = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CodeChanges = new System.Windows.Forms.GroupBox();
            this.richTextBoxCodeChanges = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CommitBox.SuspendLayout();
            this.Commits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commitsDataGrid)).BeginInit();
            this.Options.SuspendLayout();
            this.CodeChanges.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommitBox
            // 
            this.CommitBox.AutoSize = true;
            this.CommitBox.Controls.Add(this.textBoxAuthorCommitInfo);
            this.CommitBox.Controls.Add(this.textBoxCommitMessage);
            this.CommitBox.Controls.Add(this.label6);
            this.CommitBox.Controls.Add(this.label5);
            this.CommitBox.Location = new System.Drawing.Point(18, 465);
            this.CommitBox.Name = "CommitBox";
            this.CommitBox.Size = new System.Drawing.Size(1229, 161);
            this.CommitBox.TabIndex = 0;
            this.CommitBox.TabStop = false;
            this.CommitBox.Text = "Commit Info";
            this.CommitBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxAuthorCommitInfo
            // 
            this.textBoxAuthorCommitInfo.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxAuthorCommitInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthorCommitInfo.Location = new System.Drawing.Point(871, 36);
            this.textBoxAuthorCommitInfo.Multiline = true;
            this.textBoxAuthorCommitInfo.Name = "textBoxAuthorCommitInfo";
            this.textBoxAuthorCommitInfo.ReadOnly = true;
            this.textBoxAuthorCommitInfo.Size = new System.Drawing.Size(352, 106);
            this.textBoxAuthorCommitInfo.TabIndex = 5;
            // 
            // textBoxCommitMessage
            // 
            this.textBoxCommitMessage.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxCommitMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommitMessage.Location = new System.Drawing.Point(6, 36);
            this.textBoxCommitMessage.Multiline = true;
            this.textBoxCommitMessage.Name = "textBoxCommitMessage";
            this.textBoxCommitMessage.ReadOnly = true;
            this.textBoxCommitMessage.Size = new System.Drawing.Size(859, 106);
            this.textBoxCommitMessage.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1004, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Author Commit Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Commit Message";
            // 
            // Commits
            // 
            this.Commits.AutoSize = true;
            this.Commits.Controls.Add(this.commitsDataGrid);
            this.Commits.Location = new System.Drawing.Point(889, 27);
            this.Commits.Name = "Commits";
            this.Commits.Size = new System.Drawing.Size(355, 459);
            this.Commits.TabIndex = 4;
            this.Commits.TabStop = false;
            this.Commits.Text = "Commits";
            this.Commits.Enter += new System.EventHandler(this.Commits_Enter);
            // 
            // commitsDataGrid
            // 
            this.commitsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commitsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.commitsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.commitsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commitsDataGrid.ColumnHeadersVisible = false;
            this.commitsDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.commitsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.commitsDataGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commitsDataGrid.Location = new System.Drawing.Point(3, 16);
            this.commitsDataGrid.MultiSelect = false;
            this.commitsDataGrid.Name = "commitsDataGrid";
            this.commitsDataGrid.ReadOnly = true;
            this.commitsDataGrid.RowHeadersVisible = false;
            this.commitsDataGrid.RowHeadersWidth = 100;
            this.commitsDataGrid.Size = new System.Drawing.Size(349, 440);
            this.commitsDataGrid.TabIndex = 2;
            this.commitsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Options
            // 
            this.Options.AutoSize = true;
            this.Options.Controls.Add(this.label7);
            this.Options.Controls.Add(this.CommithashBox);
            this.Options.Controls.Add(this.label3);
            this.Options.Controls.Add(this.comboBox1);
            this.Options.Controls.Add(this.button2);
            this.Options.Controls.Add(this.selected_file_clicked);
            this.Options.Controls.Add(this.button1);
            this.Options.Controls.Add(this.label2);
            this.Options.Controls.Add(this.label1);
            this.Options.Controls.Add(this.dateTimePicker2);
            this.Options.Controls.Add(this.dateTimePicker1);
            this.Options.Location = new System.Drawing.Point(1264, 27);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(225, 595);
            this.Options.TabIndex = 1;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            this.Options.Enter += new System.EventHandler(this.Options_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Filter By Commit Hash";
            // 
            // CommithashBox
            // 
            this.CommithashBox.Location = new System.Drawing.Point(7, 228);
            this.CommithashBox.Name = "CommithashBox";
            this.CommithashBox.Size = new System.Drawing.Size(211, 20);
            this.CommithashBox.TabIndex = 11;
            this.CommithashBox.TextChanged += new System.EventHandler(this.CommithashBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Authors";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Select Directory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // selected_file_clicked
            // 
            this.selected_file_clicked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_file_clicked.Location = new System.Drawing.Point(6, 477);
            this.selected_file_clicked.Name = "selected_file_clicked";
            this.selected_file_clicked.Size = new System.Drawing.Size(213, 40);
            this.selected_file_clicked.TabIndex = 5;
            this.selected_file_clicked.Text = "Select File";
            this.selected_file_clicked.UseVisualStyleBackColor = true;
            this.selected_file_clicked.Click += new System.EventHandler(this.button2_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "End Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 89);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2021, 2, 24, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CodeChanges
            // 
            this.CodeChanges.AutoSize = true;
            this.CodeChanges.Controls.Add(this.richTextBoxCodeChanges);
            this.CodeChanges.Location = new System.Drawing.Point(18, 31);
            this.CodeChanges.Name = "CodeChanges";
            this.CodeChanges.Size = new System.Drawing.Size(874, 447);
            this.CodeChanges.TabIndex = 2;
            this.CodeChanges.TabStop = false;
            this.CodeChanges.Text = "Code / Changes";
            // 
            // richTextBoxCodeChanges
            // 
            this.richTextBoxCodeChanges.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxCodeChanges.Location = new System.Drawing.Point(0, 12);
            this.richTextBoxCodeChanges.Name = "richTextBoxCodeChanges";
            this.richTextBoxCodeChanges.ReadOnly = true;
            this.richTextBoxCodeChanges.Size = new System.Drawing.Size(868, 416);
            this.richTextBoxCodeChanges.TabIndex = 0;
            this.richTextBoxCodeChanges.Text = "";
            this.richTextBoxCodeChanges.WordWrap = false;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1501, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.fileToolStripMenuItem.Text = "Add Repository";
            // 
            // CodebaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 619);
            this.Controls.Add(this.CommitBox);
            this.Controls.Add(this.Commits);
            this.Controls.Add(this.CodeChanges);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CodebaseView";
            this.Text = "Codebase View";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CommitBox.ResumeLayout(false);
            this.CommitBox.PerformLayout();
            this.Commits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commitsDataGrid)).EndInit();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.CodeChanges.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CommitBox;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.GroupBox CodeChanges;
        private System.Windows.Forms.GroupBox Commits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button selected_file_clicked;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView commitsDataGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CommithashBox;
        private System.Windows.Forms.TextBox textBoxCommitMessage;
        private System.Windows.Forms.TextBox textBoxAuthorCommitInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxCodeChanges;
    }
}


