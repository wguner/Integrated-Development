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
    public partial class MessageBox : Form
    {
        public MessageBox(string message)
        {
            InitializeComponent();
            this.message.Text = message;
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
