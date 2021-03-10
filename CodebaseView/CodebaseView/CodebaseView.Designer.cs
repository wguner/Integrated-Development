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
            this.dataGridViewCommitHashBox = new System.Windows.Forms.DataGridView();
            this.Options = new System.Windows.Forms.GroupBox();
            this.labelSelectRepository = new System.Windows.Forms.Label();
            this.comboBoxSelectRepository = new System.Windows.Forms.ComboBox();
            this.labelSelectBranch = new System.Windows.Forms.Label();
            this.comboBoxSelectBranch = new System.Windows.Forms.ComboBox();
            this.labelShowFileName = new System.Windows.Forms.Label();
            this.labelFilterByCommitHash = new System.Windows.Forms.Label();
            this.textBoxCommitHash = new System.Windows.Forms.TextBox();
            this.labelSelectAuthors = new System.Windows.Forms.Label();
            this.comboBoxSelectAuthor = new System.Windows.Forms.ComboBox();
            this.buttonSelectDirectory = new System.Windows.Forms.Button();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.Filter_Button = new System.Windows.Forms.Button();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CodeChanges = new System.Windows.Forms.GroupBox();
            this.richTextBoxCodeChanges = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRepositoryStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CommitBox.SuspendLayout();
            this.Commits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommitHashBox)).BeginInit();
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
            this.Commits.Controls.Add(this.dataGridViewCommitHashBox);
            this.Commits.Location = new System.Drawing.Point(889, 27);
            this.Commits.Name = "Commits";
            this.Commits.Size = new System.Drawing.Size(355, 459);
            this.Commits.TabIndex = 4;
            this.Commits.TabStop = false;
            this.Commits.Text = "Commits";
            // 
            // dataGridViewCommitHashBox
            // 
            this.dataGridViewCommitHashBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCommitHashBox.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCommitHashBox.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewCommitHashBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommitHashBox.ColumnHeadersVisible = false;
            this.dataGridViewCommitHashBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewCommitHashBox.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCommitHashBox.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCommitHashBox.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCommitHashBox.MultiSelect = false;
            this.dataGridViewCommitHashBox.Name = "dataGridViewCommitHashBox";
            this.dataGridViewCommitHashBox.ReadOnly = true;
            this.dataGridViewCommitHashBox.RowHeadersVisible = false;
            this.dataGridViewCommitHashBox.RowHeadersWidth = 100;
            this.dataGridViewCommitHashBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCommitHashBox.Size = new System.Drawing.Size(349, 429);
            this.dataGridViewCommitHashBox.TabIndex = 2;
            this.dataGridViewCommitHashBox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridViewCommitHashBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.commitHashBox_mouseClick);
            // 
            // Options
            // 
            this.Options.AutoSize = true;
            this.Options.Controls.Add(this.labelSelectRepository);
            this.Options.Controls.Add(this.comboBoxSelectRepository);
            this.Options.Controls.Add(this.labelSelectBranch);
            this.Options.Controls.Add(this.comboBoxSelectBranch);
            this.Options.Controls.Add(this.labelShowFileName);
            this.Options.Controls.Add(this.labelFilterByCommitHash);
            this.Options.Controls.Add(this.textBoxCommitHash);
            this.Options.Controls.Add(this.labelSelectAuthors);
            this.Options.Controls.Add(this.comboBoxSelectAuthor);
            this.Options.Controls.Add(this.buttonSelectDirectory);
            this.Options.Controls.Add(this.buttonSelectFile);
            this.Options.Controls.Add(this.Filter_Button);
            this.Options.Controls.Add(this.labelStartDate);
            this.Options.Controls.Add(this.labelEndDate);
            this.Options.Controls.Add(this.dateTimePicker2);
            this.Options.Controls.Add(this.dateTimePicker1);
            this.Options.Location = new System.Drawing.Point(1264, 27);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(231, 595);
            this.Options.TabIndex = 1;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // labelSelectRepository
            // 
            this.labelSelectRepository.Location = new System.Drawing.Point(3, 16);
            this.labelSelectRepository.Name = "labelSelectRepository";
            this.labelSelectRepository.Size = new System.Drawing.Size(222, 15);
            this.labelSelectRepository.TabIndex = 17;
            this.labelSelectRepository.Text = "Select Repository";
            this.labelSelectRepository.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSelectRepository
            // 
            this.comboBoxSelectRepository.FormattingEnabled = true;
            this.comboBoxSelectRepository.Location = new System.Drawing.Point(3, 34);
            this.comboBoxSelectRepository.Name = "comboBoxSelectRepository";
            this.comboBoxSelectRepository.Size = new System.Drawing.Size(222, 21);
            this.comboBoxSelectRepository.TabIndex = 16;
            // 
            // labelSelectBranch
            // 
            this.labelSelectBranch.Location = new System.Drawing.Point(3, 75);
            this.labelSelectBranch.Name = "labelSelectBranch";
            this.labelSelectBranch.Size = new System.Drawing.Size(222, 17);
            this.labelSelectBranch.TabIndex = 15;
            this.labelSelectBranch.Text = "Select Branch";
            this.labelSelectBranch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSelectBranch
            // 
            this.comboBoxSelectBranch.FormattingEnabled = true;
            this.comboBoxSelectBranch.Location = new System.Drawing.Point(3, 95);
            this.comboBoxSelectBranch.Name = "comboBoxSelectBranch";
            this.comboBoxSelectBranch.Size = new System.Drawing.Size(222, 21);
            this.comboBoxSelectBranch.TabIndex = 14;
            // 
            // labelShowFileName
            // 
            this.labelShowFileName.AutoSize = true;
            this.labelShowFileName.Location = new System.Drawing.Point(6, 482);
            this.labelShowFileName.Name = "labelShowFileName";
            this.labelShowFileName.Size = new System.Drawing.Size(48, 13);
            this.labelShowFileName.TabIndex = 13;
            this.labelShowFileName.Text = "File label";
            // 
            // labelFilterByCommitHash
            // 
            this.labelFilterByCommitHash.Location = new System.Drawing.Point(3, 320);
            this.labelFilterByCommitHash.Name = "labelFilterByCommitHash";
            this.labelFilterByCommitHash.Size = new System.Drawing.Size(222, 15);
            this.labelFilterByCommitHash.TabIndex = 12;
            this.labelFilterByCommitHash.Text = "Filter By Commit Hash";
            this.labelFilterByCommitHash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCommitHash
            // 
            this.textBoxCommitHash.Location = new System.Drawing.Point(3, 338);
            this.textBoxCommitHash.Name = "textBoxCommitHash";
            this.textBoxCommitHash.Size = new System.Drawing.Size(222, 20);
            this.textBoxCommitHash.TabIndex = 11;
            // 
            // labelSelectAuthors
            // 
            this.labelSelectAuthors.Location = new System.Drawing.Point(3, 143);
            this.labelSelectAuthors.Name = "labelSelectAuthors";
            this.labelSelectAuthors.Size = new System.Drawing.Size(222, 15);
            this.labelSelectAuthors.TabIndex = 10;
            this.labelSelectAuthors.Text = "Select Author";
            this.labelSelectAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSelectAuthor
            // 
            this.comboBoxSelectAuthor.FormattingEnabled = true;
            this.comboBoxSelectAuthor.Location = new System.Drawing.Point(3, 161);
            this.comboBoxSelectAuthor.Name = "comboBoxSelectAuthor";
            this.comboBoxSelectAuthor.Size = new System.Drawing.Size(222, 21);
            this.comboBoxSelectAuthor.TabIndex = 9;
            // 
            // buttonSelectDirectory
            // 
            this.buttonSelectDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectDirectory.Location = new System.Drawing.Point(3, 392);
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.Size = new System.Drawing.Size(222, 40);
            this.buttonSelectDirectory.TabIndex = 8;
            this.buttonSelectDirectory.Text = "Select Directory";
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectFile.Location = new System.Drawing.Point(3, 440);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(222, 40);
            this.buttonSelectFile.TabIndex = 5;
            this.buttonSelectFile.Text = "Select File";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.selectFileButton_clicked);
            // 
            // Filter_Button
            // 
            this.Filter_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_Button.Location = new System.Drawing.Point(3, 536);
            this.Filter_Button.Name = "Filter_Button";
            this.Filter_Button.Size = new System.Drawing.Size(222, 40);
            this.Filter_Button.TabIndex = 4;
            this.Filter_Button.Text = "Filter";
            this.Filter_Button.UseVisualStyleBackColor = true;
            this.Filter_Button.Click += new System.EventHandler(this.Filter_Button_Click);
            // 
            // labelStartDate
            // 
            this.labelStartDate.Location = new System.Drawing.Point(3, 204);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(222, 15);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "Start Date";
            this.labelStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEndDate
            // 
            this.labelEndDate.Location = new System.Drawing.Point(3, 255);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(222, 13);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "End Date";
            this.labelEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 271);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(222, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2021, 2, 24, 0, 0, 0, 0);
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
            this.richTextBoxCodeChanges.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCodeChanges.Location = new System.Drawing.Point(0, 12);
            this.richTextBoxCodeChanges.Name = "richTextBoxCodeChanges";
            this.richTextBoxCodeChanges.ReadOnly = true;
            this.richTextBoxCodeChanges.Size = new System.Drawing.Size(868, 416);
            this.richTextBoxCodeChanges.TabIndex = 0;
            this.richTextBoxCodeChanges.Text = "";
            this.richTextBoxCodeChanges.WordWrap = false;
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
            this.AddRepositoryStrip});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // AddRepositoryStrip
            // 
            this.AddRepositoryStrip.Name = "AddRepositoryStrip";
            this.AddRepositoryStrip.Size = new System.Drawing.Size(180, 22);
            this.AddRepositoryStrip.Text = "Add Repository";
            this.AddRepositoryStrip.Click += new System.EventHandler(this.AddRepositoryStrip_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommitHashBox)).EndInit();
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
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Filter_Button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridViewCommitHashBox;
        private System.Windows.Forms.Button buttonSelectDirectory;
        private System.Windows.Forms.Label labelSelectAuthors;
        private System.Windows.Forms.ComboBox comboBoxSelectAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFilterByCommitHash;
        private System.Windows.Forms.TextBox textBoxCommitHash;
        private System.Windows.Forms.TextBox textBoxCommitMessage;
        private System.Windows.Forms.TextBox textBoxAuthorCommitInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddRepositoryStrip;
        private System.Windows.Forms.RichTextBox richTextBoxCodeChanges;
        private System.Windows.Forms.Label labelShowFileName;
        private System.Windows.Forms.Label labelSelectRepository;
        private System.Windows.Forms.ComboBox comboBoxSelectRepository;
        private System.Windows.Forms.Label labelSelectBranch;
        private System.Windows.Forms.ComboBox comboBoxSelectBranch;
    }
}


