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
    public partial class AddRepositoryForm : Form
    {
        public EventHandler executeRepoAdding;


        public AddRepositoryForm()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (RepoURLBox.Text != string.Empty)
            {
                string url = RepoURLBox.Text.ToString();
                executeRepoAdding?.Invoke(url, e);
            }
            this.Close();
        }
    }
}
