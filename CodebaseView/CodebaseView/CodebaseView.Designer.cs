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
            this.Commits = new System.Windows.Forms.GroupBox();
            this.commitsDataGrid = new System.Windows.Forms.DataGridView();
            this.Options = new System.Windows.Forms.GroupBox();
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
            this.Contributors = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CommitBox.SuspendLayout();
            this.Commits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commitsDataGrid)).BeginInit();
            this.Options.SuspendLayout();
            this.Contributors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // CommitBox
            // 
            this.CommitBox.AutoSize = true;
            this.CommitBox.Controls.Add(this.label6);
            this.CommitBox.Controls.Add(this.dataGridView1);
            this.CommitBox.Controls.Add(this.dataGridView2);
            this.CommitBox.Controls.Add(this.label5);
            this.CommitBox.Location = new System.Drawing.Point(450, 465);
            this.CommitBox.Name = "CommitBox";
            this.CommitBox.Size = new System.Drawing.Size(794, 148);
            this.CommitBox.TabIndex = 0;
            this.CommitBox.TabStop = false;
            this.CommitBox.Text = "Commit Info";
            this.CommitBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Commits
            // 
            this.Commits.AutoSize = true;
            this.Commits.Controls.Add(this.commitsDataGrid);
            this.Commits.Location = new System.Drawing.Point(889, 3);
            this.Commits.Name = "Commits";
            this.Commits.Size = new System.Drawing.Size(355, 459);
            this.Commits.TabIndex = 4;
            this.Commits.TabStop = false;
            this.Commits.Text = "Commits";
            this.Commits.Enter += new System.EventHandler(this.Commits_Enter);
            // 
            // commitsDataGrid
            // 
            this.commitsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.commitsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commitsDataGrid.ColumnHeadersVisible = false;
            this.commitsDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.commitsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.commitsDataGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commitsDataGrid.Location = new System.Drawing.Point(3, 16);
            this.commitsDataGrid.Name = "commitsDataGrid";
            this.commitsDataGrid.ReadOnly = true;
            this.commitsDataGrid.RowHeadersVisible = false;
            this.commitsDataGrid.Size = new System.Drawing.Size(349, 440);
            this.commitsDataGrid.TabIndex = 2;
            this.commitsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Options
            // 
            this.Options.AutoSize = true;
            this.Options.Controls.Add(this.label7);
            this.Options.Controls.Add(this.textBox1);
            this.Options.Controls.Add(this.label3);
            this.Options.Controls.Add(this.comboBox1);
            this.Options.Controls.Add(this.button2);
            this.Options.Controls.Add(this.selected_file_clicked);
            this.Options.Controls.Add(this.button1);
            this.Options.Controls.Add(this.label2);
            this.Options.Controls.Add(this.label1);
            this.Options.Controls.Add(this.dateTimePicker2);
            this.Options.Controls.Add(this.dateTimePicker1);
            this.Options.Location = new System.Drawing.Point(1264, 13);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(225, 595);
            this.Options.TabIndex = 1;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            this.Options.Enter += new System.EventHandler(this.Options_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Authors / Branch";
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
            this.label2.Location = new System.Drawing.Point(81, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 73);
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
            this.dateTimePicker2.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CodeChanges
            // 
            this.CodeChanges.AutoSize = true;
            this.CodeChanges.Location = new System.Drawing.Point(18, 13);
            this.CodeChanges.Name = "CodeChanges";
            this.CodeChanges.Size = new System.Drawing.Size(865, 446);
            this.CodeChanges.TabIndex = 2;
            this.CodeChanges.TabStop = false;
            this.CodeChanges.Text = "Code / Changes";
            // 
            // Contributors
            // 
            this.Contributors.AutoSize = true;
            this.Contributors.Controls.Add(this.label4);
            this.Contributors.Controls.Add(this.comboBox2);
            this.Contributors.Location = new System.Drawing.Point(12, 465);
            this.Contributors.Name = "Contributors";
            this.Contributors.Size = new System.Drawing.Size(432, 143);
            this.Contributors.TabIndex = 3;
            this.Contributors.TabStop = false;
            this.Contributors.Text = "Repository Selection";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(418, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Add Repository";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Commit Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Author Commit Info";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 97);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(404, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(384, 97);
            this.dataGridView2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 11;
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
            // CodebaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 619);
            this.Controls.Add(this.CommitBox);
            this.Controls.Add(this.Commits);
            this.Controls.Add(this.Contributors);
            this.Controls.Add(this.CodeChanges);
            this.Controls.Add(this.Options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CodebaseView";
            this.Text = "Codebase View";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CommitBox.ResumeLayout(false);
            this.CommitBox.PerformLayout();
            this.Commits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commitsDataGrid)).EndInit();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.Contributors.ResumeLayout(false);
            this.Contributors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView commitsDataGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}


