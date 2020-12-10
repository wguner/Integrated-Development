using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CodebaseView
{
    public partial class CodebaseView : Form
    {
        
      //  DataTable commitInfo = new DataTable();
        BindingSource binding = new BindingSource();
        
        public string connectionString = "Host = localhost; Username = postgres; Database = 421Db; password = password";

        
        public CodebaseView()
        {
            InitializeComponent();
            InitPopulate();
        }

        private void InitPopulate()
        {
            string query = new SELECTQueryBuilder().setColumns("commit_id").setTables("commit").build();
            populateCommits(query);
        }

        private void populateCommits(string query)
        {
            DataTable dt = SQL.execute(query);
            this.commitsDataGrid.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Options_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Commits_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog1.FileNames[0]);
                //textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(folderBrowserDialog1.SelectedPath);

            }
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string commitId = this.commitsDataGrid.Rows[row].Cells[0].Value.ToString();
            string sqlstr = new SELECTQueryBuilder().setColumns("message", "author")
                                .setTables("commit").setConditionals("commit_id = '" + commitId + "'").build();
            DataTable commitinfo = SQL.execute(sqlstr);
            textBox2.Text = commitinfo.Rows[0]["message"].ToString();
            textBox3.Text = commitinfo.Rows[0]["author"].ToString();

        }

    }
}

