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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Options = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selected_file_clicked = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CodeChanges = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Contributors = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Commits = new System.Windows.Forms.GroupBox();
            this.commitsDataGrid = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CommitBox.SuspendLayout();
            this.Options.SuspendLayout();
            this.CodeChanges.SuspendLayout();
            this.Contributors.SuspendLayout();
            this.Commits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commitsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CommitBox
            // 
            this.CommitBox.AutoSize = true;
            this.CommitBox.Controls.Add(this.textBox2);
            this.CommitBox.Location = new System.Drawing.Point(12, 12);
            this.CommitBox.Name = "CommitBox";
            this.CommitBox.Size = new System.Drawing.Size(758, 57);
            this.CommitBox.TabIndex = 0;
            this.CommitBox.TabStop = false;
            this.CommitBox.Text = "Commit Info";
            this.CommitBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(738, 20);
            this.textBox2.TabIndex = 0;
            // 
            // Options
            // 
            this.Options.AutoSize = true;
            this.Options.Controls.Add(this.button2);
            this.Options.Controls.Add(this.textBox1);
            this.Options.Controls.Add(this.label3);
            this.Options.Controls.Add(this.selected_file_clicked);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author";
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
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date";
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 89);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CodeChanges
            // 
            this.CodeChanges.AutoSize = true;
            this.CodeChanges.Controls.Add(this.textBox4);
            this.CodeChanges.Location = new System.Drawing.Point(12, 72);
            this.CodeChanges.Name = "CodeChanges";
            this.CodeChanges.Size = new System.Drawing.Size(530, 411);
            this.CodeChanges.TabIndex = 2;
            this.CodeChanges.TabStop = false;
            this.CodeChanges.Text = "Code / Changes";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(506, 20);
            this.textBox4.TabIndex = 0;
            // 
            // Contributors
            // 
            this.Contributors.AutoSize = true;
            this.Contributors.Controls.Add(this.textBox3);
            this.Contributors.Location = new System.Drawing.Point(12, 489);
            this.Contributors.Name = "Contributors";
            this.Contributors.Size = new System.Drawing.Size(758, 119);
            this.Contributors.TabIndex = 3;
            this.Contributors.TabStop = false;
            this.Contributors.Text = "Contributors";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(736, 20);
            this.textBox3.TabIndex = 0;
            // 
            // Commits
            // 
            this.Commits.AutoSize = true;
            this.Commits.Controls.Add(this.commitsDataGrid);
            this.Commits.Location = new System.Drawing.Point(548, 72);
            this.Commits.Name = "Commits";
            this.Commits.Size = new System.Drawing.Size(228, 430);
            this.Commits.TabIndex = 4;
            this.Commits.TabStop = false;
            this.Commits.Text = "Commits";
            this.Commits.Enter += new System.EventHandler(this.Commits_Enter);
            // 
            // commitsDataGrid
            // 
            this.commitsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.commitsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commitsDataGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commitsDataGrid.Location = new System.Drawing.Point(0, 13);
            this.commitsDataGrid.Name = "commitsDataGrid";
            this.commitsDataGrid.Size = new System.Drawing.Size(222, 398);
            this.commitsDataGrid.TabIndex = 2;
            this.commitsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.Controls.Add(this.CommitBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CodebaseView";
            this.Text = "Codebase View";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CommitBox.ResumeLayout(false);
            this.CommitBox.PerformLayout();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.CodeChanges.ResumeLayout(false);
            this.CodeChanges.PerformLayout();
            this.Contributors.ResumeLayout(false);
            this.Contributors.PerformLayout();
            this.Commits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commitsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CommitBox;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.GroupBox CodeChanges;
        private System.Windows.Forms.GroupBox Contributors;
        private System.Windows.Forms.GroupBox Commits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button selected_file_clicked;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView commitsDataGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}


