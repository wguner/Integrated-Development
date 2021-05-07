using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodebaseView
{
    public partial class ProgrammerGradesForm : Form
    {
        public ProgrammerGradesForm()
        {
            InitializeComponent();
            this.ProgrammerName.Visible = false;
            this.numCommits.Visible = false;
            this.programmerGrade.Visible = false;
        }

        private void viewGrades_Click(object sender, EventArgs e)
        {
            this.ProgrammerName.Visible = true;
            this.numCommits.Visible = true;
            this.programmerGrade.Visible = true;
            this.programmerInfo.Rows.Add("Shawn Poole", "58", "B");
            this.programmerInfo.Rows.Add("Alex Udodik", "54", "B");
            this.programmerInfo.Rows.Add("Jacob Huber", "45", "B-");
        }
    }
}
