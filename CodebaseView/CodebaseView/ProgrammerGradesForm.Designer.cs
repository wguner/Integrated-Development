namespace CodebaseView
{
    partial class ProgrammerGradesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.programmerInfo = new System.Windows.Forms.DataGridView();
            this.printGrades = new System.Windows.Forms.Button();
            this.viewGrades = new System.Windows.Forms.Button();
            this.ProgrammerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCommits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programmerGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programmerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.programmerInfo);
            this.groupBox1.Location = new System.Drawing.Point(201, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programmer Information";
            // 
            // programmerInfo
            // 
            this.programmerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programmerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgrammerName,
            this.numCommits,
            this.programmerGrade});
            this.programmerInfo.Location = new System.Drawing.Point(8, 23);
            this.programmerInfo.Name = "programmerInfo";
            this.programmerInfo.Size = new System.Drawing.Size(572, 392);
            this.programmerInfo.TabIndex = 0;
            // 
            // printGrades
            // 
            this.printGrades.Location = new System.Drawing.Point(11, 12);
            this.printGrades.Name = "printGrades";
            this.printGrades.Size = new System.Drawing.Size(184, 196);
            this.printGrades.TabIndex = 1;
            this.printGrades.Text = "Print Grades";
            this.printGrades.UseVisualStyleBackColor = true;
            // 
            // viewGrades
            // 
            this.viewGrades.Location = new System.Drawing.Point(12, 214);
            this.viewGrades.Name = "viewGrades";
            this.viewGrades.Size = new System.Drawing.Size(184, 204);
            this.viewGrades.TabIndex = 2;
            this.viewGrades.Text = "View Grades";
            this.viewGrades.UseVisualStyleBackColor = true;
            this.viewGrades.Click += new System.EventHandler(this.viewGrades_Click);
            // 
            // ProgrammerName
            // 
            this.ProgrammerName.HeaderText = "Programmer Name";
            this.ProgrammerName.Name = "ProgrammerName";
            // 
            // numCommits
            // 
            this.numCommits.HeaderText = "Number of Commits";
            this.numCommits.Name = "numCommits";
            // 
            // programmerGrade
            // 
            this.programmerGrade.HeaderText = "Programmer Grade";
            this.programmerGrade.Name = "programmerGrade";
            // 
            // ProgrammerGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewGrades);
            this.Controls.Add(this.printGrades);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProgrammerGradesForm";
            this.Text = "ProgrammerGradesForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.programmerInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView programmerInfo;
        private System.Windows.Forms.Button printGrades;
        private System.Windows.Forms.Button viewGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgrammerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCommits;
        private System.Windows.Forms.DataGridViewTextBoxColumn programmerGrade;
    }
}