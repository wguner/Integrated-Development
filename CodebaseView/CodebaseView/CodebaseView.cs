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
            string query = new SELECTQueryBuilder().setColumns("commit_hash", "datetime").setTables("commit").setOrderBy("datetime").build();
            string authorNames = new SELECTQueryBuilder().setColumns("name").setTables("author").build();
            populateCommits(query);
            populateAuthorBox(authorNames);
        }

        private void populateCommits(string query)
        {
            DataTable dt = SQL.execute(query);
            this.commitsDataGrid.DataSource = dt;
        }
        private void populateAuthorBox(string sql)
        {
            DataTable dt = SQL.execute(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.comboBox1.Items.Add(dt.Rows[i]["name"].ToString());
            }
        }

        private void populateFiles(string query)
        {
            DataTable dt = SQL.execute(query);
            
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
            this.richTextBoxCodeChanges.Text = "";
            string dateTime = this.dateTimePicker1.Text;
            TimeStamp date = TimeStamp.parseWinFormsTimeStamp(dateTime);
            SELECTQueryBuilder qe = new SELECTQueryBuilder();
            string currentDate = dateTimePicker1.Value.ToString();
            string sqlstr = qe.setColumns("message", "author_id").setTables("commit").setConditionals("datetime = '"
                + dateTime.ToString() + "'").build();
            DataTable authorCommit = SQL.execute(sqlstr);
            textBoxCommitMessage.Text = authorCommit.Rows[0]["message"].ToString();

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
            this.richTextBoxCodeChanges.Text = "";
            int row = e.RowIndex;
            string commitHash = this.commitsDataGrid.Rows[row].Cells[0].Value.ToString();
            string sqlstr = new SELECTQueryBuilder().setColumns("message", "author_id", "datetime")
                                .setTables("commit").setConditionals("commit_hash = '" + commitHash + "'").build();
            DataTable commitinfo = SQL.execute(sqlstr);
            
            textBoxCommitMessage.Text = "Message: " + commitinfo.Rows[0]["message"].ToString();



            string author_id = commitinfo.Rows[0]["author_id"].ToString();
            string authorStr = new SELECTQueryBuilder().setColumns("*").setTables("Author").setConditionals("author_id = " + author_id).build();
            DataTable authortable = SQL.execute(authorStr);

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Name: " + authortable.Rows[0]["name"].ToString());
            builder.AppendLine("ID: " + authortable.Rows[0]["author_id"].ToString());
            builder.AppendLine("Email: " + authortable.Rows[0]["email"].ToString());
            textBoxAuthorCommitInfo.Text = builder.ToString();

            GitParser parser = new GitParser();
            List<string> changes = parser.initCodeChanges(commitHash);


            foreach (string line in changes)
            {
                if (line.StartsWith("+"))
                {
                    appendTextToCodeChangesBox(this.richTextBoxCodeChanges, line, Color.Green);
                }
                else if (line.StartsWith("-"))
                {
                    appendTextToCodeChangesBox(this.richTextBoxCodeChanges, line, Color.Red);
                }
                else
                {
                    appendTextToCodeChangesBox(this.richTextBoxCodeChanges, line, Color.Black);
                }

            }

        }

        private void appendTextToCodeChangesBox(RichTextBox box, string line, Color color)
        {
            box.SelectionColor = color;
            box.AppendText(line + "\n");
            box.SelectionColor = box.ForeColor;
        }

        private void CommithashBox_TextChanged(object sender, EventArgs e)
        {
            
            richTextBoxCodeChanges.Clear();
          
            string commitHash = CommithashBox.Text;
            string sqlStr = new SELECTQueryBuilder().setColumns("message", "author_id", "datetime").setTables("commit").
                setConditionals("commit_hash = '" + commitHash + "'").build();
            DataTable commitHashes = SQL.execute(sqlStr);
            if (commitHashes.Rows.Count == 0)
            {
                richTextBoxCodeChanges.Text = "";
                return;
            }
            if (commitHashes.Rows.Count != 0)
            {
                string authorID = commitHashes.Rows[0]["author_id"].ToString();
                string authorStr = new SELECTQueryBuilder().setColumns("author_id", "name", "email").setTables("author")
                    .setConditionals("author_id = '" + authorID + "'").build();

                DataTable authorTable = SQL.execute(authorStr);
                StringBuilder authorInfo = new StringBuilder();
                authorInfo.AppendLine("Name: " + authorTable.Rows[0]["name"].ToString());
                authorInfo.AppendLine("ID: " + authorTable.Rows[0]["author_id"].ToString());
                authorInfo.AppendLine("Email: " + authorTable.Rows[0]["email"].ToString());
                textBoxAuthorCommitInfo.Text = authorInfo.ToString();

                StringBuilder builder = new StringBuilder();
                builder.AppendLine("Message: " + commitHashes.Rows[0]["message"].ToString());
                textBoxCommitMessage.Text = builder.ToString();
            }
            


            GitParser parser = new GitParser();
            List<string> changes = parser.initCodeChanges(commitHash);

            
            foreach (string line in changes)
            {
                if (line.StartsWith("+"))
                {
                    appendTextToCodeChangesBox(this.richTextBoxCodeChanges, line, Color.Green);
                }
                else if (line.StartsWith("-"))
                {
                    appendTextToCodeChangesBox(this.richTextBoxCodeChanges, line, Color.Red);
                }
                else
                {
                    appendTextToCodeChangesBox(this.richTextBoxCodeChanges, line, Color.Black);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Filter_Button_Click(object sender, EventArgs e)
        {
            //if (CommithashBox.T)
           // {

            //}
        }
    }
}