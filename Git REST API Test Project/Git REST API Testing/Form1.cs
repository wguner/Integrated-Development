using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_REST_API_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //"https://github.com/MyEtherWallet/etherwallet"
            //"https://github.com/octocat/Hello-World/commit/7fd1a60b01f91b314f59955a4e4d4e80d8edf11d.diff"
            //"https://api.github.com/repos/MyEtherWallet/etherwallet"
            showinfo("https://github.com/octocat/Hello-World/commit/7fd1a60b01f91b314f59955a4e4d4e80d8edf11d.diff");
        }

        public void showinfo(string url)
        {
            Git git = new Git(url);
            Console.WriteLine( git.getResponse());


        }
    }
}
