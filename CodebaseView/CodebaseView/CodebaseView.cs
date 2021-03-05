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
            string query = new SELECTQueryBuilder().setColumns("commit_hash", "datetime", "message").setTables("commit").setOrderBy("datetime").build();
            string authorNames = new SELECTQueryBuilder().setColumns("name").setTables("author").build();
            
            
            populateCommits(query);
            populateAuthorBox(authorNames);

            this.dataGridViewCommitHashBox.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void populateCommits(string query)
        {
            DataTable dt = SQL.execute(query);
            this.dataGridViewCommitHashBox.DataSource = dt;
        }
        private void populateAuthorBox(string sql)
        {
            DataTable dt = SQL.execute(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.comboBoxSelectAuthor.Items.Add(dt.Rows[i]["name"].ToString());
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
            
            

        }

        private void test()
        {
            this.richTextBoxCodeChanges.Text = "";
            string dateTime = this.dateTimePicker1.Text;

            TimeStamp date = new TimeStamp(this.dateTimePicker1.Value.Year.ToString(),
                this.dateTimePicker1.Value.Month.ToString(),
                this.dateTimePicker1.Value.Day.ToString(),
                this.dateTimePicker1.Value.TimeOfDay.ToString());

            SELECTQueryBuilder qe = new SELECTQueryBuilder();
            string currentDate = dateTimePicker1.Value.ToString();
            string sqlstr = qe.setColumns("message", "author_id").setTables("commit").setConditionals("datetime = '"
                + date.ToSelectString() + "'").build();
            DataTable authorCommit = SQL.execute(sqlstr);

            textBoxCommitMessage.Text = authorCommit.Rows[0]["message"].ToString();
        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            this.richTextBoxCodeChanges.Text = "";
            int row = e.RowIndex;
            string commitHash = this.dataGridViewCommitHashBox.Rows[row].Cells[0].Value.ToString();
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
            /*
            richTextBoxCodeChanges.Clear();
          
            
            string commitHash = textBoxCommitHash.Text;
            string sqlStr = new SELECTQueryBuilder().setColumns("message", "author_id", "datetime").setTables("commit").
                setConditionals("commit_hash = '" + commitHash + "'").build();
            DataTable commitHashes = SQL.execute(sqlStr);
            /*if (commitHashes.Rows.Count == 0)
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

            }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Filter_Button_Click(object sender, EventArgs e)
        {
            SELECTQueryBuilder selectQueryBuilder = new SELECTQueryBuilder();
            selectQueryBuilder.setColumns("commit_hash", "datetime", "message");
            selectQueryBuilder.setTables("commit");

            string timeAfter = this.GetTimeStamp(this.dateTimePicker1);
            string timeBefore = this.GetTimeStamp(this.dateTimePicker2);

            GitParser parser = new GitParser();
            string repoURL = parser.retrieveRepoURL();

            //get repo_id
            if (repoURL != null || repoURL != string.Empty)
            {
                SELECTQueryBuilder tempQueryBuilder = new SELECTQueryBuilder();
                tempQueryBuilder.setTables("Repository").setColumns("repo_id").setConditionals("repoURL = '" + repoURL + "'");

                string tempSqlStr = tempQueryBuilder.build();
                DataTable tempRepoID = SQL.execute(tempSqlStr);

                if (tempRepoID.Rows.Count > 0)
                {
                    string repo_id = tempRepoID.Rows[0]["repo_id"].ToString();
                    selectQueryBuilder.setConditionals("repo_id = " + repo_id);
                }
            }
            selectQueryBuilder.setConditionals("datetime >= '" + timeAfter + "' and datetime <= '" + timeBefore + "'");

            //get author id
            if (this.comboBoxSelectAuthor.SelectedIndex > -1)
            {
                string name = this.comboBoxSelectAuthor.SelectedItem.ToString();
                SELECTQueryBuilder tempQueryBuilder = new SELECTQueryBuilder();
                tempQueryBuilder.setTables("Author").setColumns("author_id").setConditionals("name = '" + name + "'");

                string tempSqlStr = tempQueryBuilder.build();
                DataTable tempAuthorID = SQL.execute(tempSqlStr);

                if (tempAuthorID.Rows.Count > 0)
                {
                    string author_id = tempAuthorID.Rows[0]["author_id"].ToString();
                    selectQueryBuilder.setConditionals("author_id = " + author_id);
                }
            }

            //get commit hash
            if (this.textBoxCommitHash.Text != string.Empty)
            {
                string commitHash = this.textBoxCommitHash.Text;
                selectQueryBuilder.setConditionals("commit_hash = '" + commitHash + "'");
            }

            string selectQueryString = selectQueryBuilder.build();
            DataTable commitTable = SQL.execute(selectQueryString);

            this.dataGridViewCommitHashBox.DataSource = commitTable;

            //TODO: get filename
            if (this.labelShowFileName.Text != string.Empty)
            {
                string filename = this.labelShowFileName.Text;
                //selectQueryBuilder.setConditionals("commit_hash = '" + commitHash + "'");
            }
            //TODO: get directory
        }

        private string GetTimeStamp(DateTimePicker dateTimePicker)
        {
            string year = dateTimePicker.Value.Year.ToString();
            string month = dateTimePicker.Value.Month.ToString();
            string day = dateTimePicker.Value.Day.ToString();
            string time = dateTimePicker.Value.TimeOfDay.ToString();

            TimeStamp date = new TimeStamp(year, month, day, time);
            
            return date.ToSelectString();
        }

       

        private void selectFileButton_clicked(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.SafeFileName.ToString();
                string directory = openFileDialog1.FileName.ToString();
      
                string repoFileName = this.GetRepoFileNameFromTrueDirectory(directory);
                this.labelShowFileName.Text = repoFileName;
            }
        }

        
        private string GetRepoFileNameFromTrueDirectory(string directory)
        {
            GitParser parser = new GitParser();
            char[] repoURL = parser.retrieveRepoURL().ToCharArray();

            List<char> templist = new List<char>();

            for (int i = repoURL.Length - 1; i >= 0; i--)
            {
                if (repoURL[i] == '/')
                {
                    break;
                }
                else 
                {
                    templist.Add(repoURL[i]);
                }
            }

            char[] tempstarter = templist.ToArray();
            Array.Reverse(tempstarter);

            string startingGitDirectory = new string(tempstarter).Replace(".git", "");

            int index = directory.IndexOf(startingGitDirectory);


            int length = directory.Length - (index + startingGitDirectory.Length + 1);

            string finalFileName = directory.Substring(index + startingGitDirectory.Length + 1, length);

            return finalFileName;
        }

        private void commitHashBox_mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();
                menu.MenuItems.Add(new MenuItem("Copy commit hash"));

                int selectRow = this.dataGridViewCommitHashBox.HitTest(e.X, e.Y).RowIndex;
                this.dataGridViewCommitHashBox.Rows[selectRow].Selected = true;
                menu.Show(this.dataGridViewCommitHashBox, new Point(e.X, e.Y));

                if (this.dataGridViewCommitHashBox.GetCellCount(DataGridViewElementStates.Selected) > 0)
                {
                    string text = this.dataGridViewCommitHashBox.Rows[selectRow].Cells[0].Value.ToString();
                    Clipboard.SetText(text);
                }
            }
        }

        
    }
}