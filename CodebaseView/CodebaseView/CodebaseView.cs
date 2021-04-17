using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualBasic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.IO;

namespace CodebaseView
{
    public partial class CodebaseView : Form
    {
        
      //  DataTable commitInfo = new DataTable();
        BindingSource binding = new BindingSource();
        
        public string connectionString = "Host = localhost; Port = 5432; Username = postgres; Database = 421Db; password = password";
        public string repo_id = string.Empty;
        private bool repo_and_branch_selected = false;
        
        public CodebaseView()
        {
            InitializeComponent();
            InitPopulate();
        }

        private void InitPopulate()
        {
            string query = new SELECTQueryBuilder().setColumns("commit_hash", "datetime", "message").setTables("commit").setOrderBy("datetime").build();
            string authorNames = new SELECTQueryBuilder().setColumns("name").setTables("author").build();
            string repoNames = new SELECTQueryBuilder().setColumns("repourl").setTables("repository").build();
            string branchNames = new SELECTQueryBuilder().setColumns("name").setTables("Branch").build();
            
            
            populateRepositoryBox(repoNames);
            //populateBranchBox(branchNames);
            this.dataGridViewCommitHashBox.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.labelShowFileName.Text = "";
            this.labelShowDirectory.Text = "";

            disableFilteringOptions();
           
        }

        private void populateCommits(string query)
        {
            DataTable dt = SQL.execute(query);
            this.dataGridViewCommitHashBox.DataSource = dt;
        }
        private void populateRepositoryBox(string sql)
        {
            this.comboBoxSelectRepository.Items.Clear();
            DataTable dt = SQL.execute(sql);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                this.comboBoxSelectRepository.Items.Add(dt.Rows[i]["repourl"].ToString());
            }
        }
        private void populateBranchBox(string sql)
        {
            this.comboBoxSelectBranch.Items.Clear();
            DataTable dt = SQL.execute(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.comboBoxSelectBranch.Items.Add(dt.Rows[i]["name"].ToString());
            }
        }
        private void populateAuthorBox(string sql)
        {
            this.comboBoxSelectAuthor.Items.Clear();
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
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string commitHash = this.dataGridViewCommitHashBox.Rows[row].Cells[0].Value.ToString();

            if (commitHash == null || commitHash == string.Empty)
            {
                this.dataGridViewCommitHashBox.Rows[row].Selected = false;
                return;
            }

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

            List<string> changes = new List<string>();

            //this is hardcoded because of our app running directly in our repo so it's weird atm.
            if (this.comboBoxSelectRepository.SelectedIndex > -1)
            {
                string repoURL = this.comboBoxSelectRepository.SelectedItem.ToString();

                if (repoURL == "https://gitlab.eecs.wsu.edu/2019080728/cpts-421.git")
                {
                    changes = parser.initCodeChanges(commitHash);
                }
                else
                {
                    string repoFileDirectory = Registry_Keys.RegistryHandler.readFileLocation(repoURL);
                    changes = parser.initCodeChanges(commitHash, repoFileDirectory);
                }
            }
            
            
            

            this.richTextBoxCodeChanges.Text = "";

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
            this.richTextBoxCodeChanges.BackColor = Color.White;


        }

        private void appendTextToCodeChangesBox(RichTextBox box, string line, Color color)
        {
            box.SelectionColor = color;
            box.AppendText(line + "\n");
            box.SelectionColor = box.ForeColor;
        }

       
        

        private void Filter_Button_Click(object sender, EventArgs e)
        {
            SELECTQueryBuilder selectQueryBuilder = new SELECTQueryBuilder();
            selectQueryBuilder.setColumns("commit_hash", "datetime", "message");
            selectQueryBuilder.setTables("commit");

            string timeAfter = this.GetTimeStamp(this.dateTimePicker1);
            string timeBefore = this.GetTimeStamp(this.dateTimePicker2);

            //GitParser parser = new GitParser();
            //string repoURL = parser.retrieveRepoURL();
            

            //get repo_id
            if (this.comboBoxSelectRepository.SelectedIndex > -1)
            {
                string repoURL = this.comboBoxSelectRepository.SelectedItem.ToString();
                if (repoURL != null || repoURL != string.Empty)
                {

                    SELECTQueryBuilder tempQueryBuilder = new SELECTQueryBuilder();
                    tempQueryBuilder.setTables("Repository").setColumns("repo_id").setConditionals("repoURL = '" + repoURL + "'");

                    string tempSqlStr = tempQueryBuilder.build();
                    DataTable tempRepoID = SQL.execute(tempSqlStr);

                    if (tempRepoID.Rows.Count > 0)
                    {
                        string repo_id = tempRepoID.Rows[0]["repo_id"].ToString();
                        this.repo_id = repo_id;

                        selectQueryBuilder.setConditionals("commit.repo_id = " + repo_id);
                    }
                }
            }
           
            //get dates
            selectQueryBuilder.setConditionals("datetime >= '" + timeAfter + "' and datetime <= '" + timeBefore + "'");

            //get branch id

            
            if (this.comboBoxSelectBranch.SelectedIndex > -1)
            {
                string branchname = this.comboBoxSelectBranch.SelectedItem.ToString();

                if (branchname != null || branchname != string.Empty)
                {
                    SELECTQueryBuilder tempQueryBuilder = new SELECTQueryBuilder();
                    tempQueryBuilder.setTables("Branch").setColumns("branch_id").setConditionals("name = '" + branchname + "'");
                    string tempSqlStr = tempQueryBuilder.build();

                    DataTable tempBranch = SQL.execute(tempSqlStr);

                    if (tempBranch.Rows.Count > 0)
                    {
                        string branch_id = tempBranch.Rows[0]["branch_id"].ToString();
                        selectQueryBuilder.setInnerJoinBy("Commit_Map_Branch CMB on CMB.branch_id = " + branch_id +
                            " and CMB.commit_id = commit.commit_id");
                    }
                }
            }

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

            //get filename
            if (this.labelShowFileName.Text != string.Empty)
            {
                string filename = this.labelShowFileName.Text;
                selectQueryBuilder.setInnerJoinBy("File_Map_Commit fmc on fmc.commit_id = commit.commit_id ");
                selectQueryBuilder.setInnerJoinBy("FILE F on F.file_id = fmc.file_id and F.filename = '" +
                                                    filename + "'");
            }

            //get file directory
            if (this.labelShowDirectory.Text != string.Empty)
            {
                string folderName = this.labelShowDirectory.Text;
                selectQueryBuilder.setInnerJoinBy("File_Map_Commit fmc on fmc.commit_id = commit.commit_id ");
                selectQueryBuilder.setInnerJoinBy("FILE F on F.file_id = fmc.file_id and F.filename like CONCAT('" + folderName + "', '%')");
            }

            selectQueryBuilder.setDistinct();
            string selectQueryString = selectQueryBuilder.build();
            DataTable commitTable = SQL.execute(selectQueryString);

            this.dataGridViewCommitHashBox.DataSource = commitTable;



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

        private void buttonSelectDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string folder = fbd.SelectedPath;
                    string repoFolderName = this.GetRepoFileNameFromTrueDirectory(folder);
                    this.labelShowDirectory.Text = repoFolderName;
                }
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

            string tempFileName1 = directory.Substring(index + startingGitDirectory.Length + 1, length);

            //flip the backward slashes with forward because that is how the database file names are.
            string tempFileName2 = tempFileName1.Replace(@"\", @"/");

            //remove the extension at the end of the file name
            if (tempFileName2.Contains("."))
            {
                int tempIndex = tempFileName2.IndexOf(".");

                if (tempIndex > 0)
                {
                    string returned = tempFileName2.Substring(0, tempIndex);
                    return returned;
                }
            }
            return tempFileName2;
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

        private void AddRepositoryStrip_Click(object sender, EventArgs e)
        {
            AddRepositoryForm addRepo = new AddRepositoryForm();
            addRepo.executeRepoAdding += this.addRepository;
            addRepo.Parent = Parent;
            addRepo.StartPosition = FormStartPosition.CenterParent;
            addRepo.Show();
        }
        private void addRepository(object sender, EventArgs e)
        {
            string repoURL = sender as string;
            Repo_Cloning.RepoCloner.cloneRepoIntoTemp(repoURL);
            string repoNames = new SELECTQueryBuilder().setColumns("repourl").setTables("repository").build();
            string authorNames = new SELECTQueryBuilder().setColumns("name").setTables("author").build();

            populateRepositoryBox(repoNames);
            populateAuthorBox(authorNames);


        }

        private void enableFilteringOptions()
        {
            this.CommitBox.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.dateTimePicker2.Enabled = true;
            this.comboBoxSelectAuthor.Enabled = true;
            this.textBoxCommitHash.Enabled = true;
            this.buttonSelectDirectory.Enabled = true;
            this.buttonSelectFile.Enabled = true;
            this.Filter_Button.Enabled = true;
        }

        private void disableFilteringOptions()
        {
            this.CommitBox.Enabled = false;
            this.comboBoxSelectBranch.Enabled = false;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker2.Enabled = false;
            this.comboBoxSelectAuthor.Enabled = false;
            this.textBoxCommitHash.Enabled = false;
            this.buttonSelectDirectory.Enabled = false;
            this.buttonSelectFile.Enabled = false;

            this.Filter_Button.Enabled = false;
        }

        private void shouldEnableFiltering()
        {
            if (this.comboBoxSelectRepository.SelectedIndex > -1 && this.comboBoxSelectBranch.SelectedIndex > -1)
            {
                if (!repo_and_branch_selected)
                {
                    enableFilteringOptions();

                    string repo_url = comboBoxSelectRepository.SelectedItem.ToString();
                    //get author names from particular repo
                    string id = new SELECTQueryBuilder()
                        .setColumns("repo_id")
                        .setTables("Repository")
                        .setConditionals("repourl = '" + repo_url + "'")
                        .build();

                    DataTable repoTable = SQL.execute(id);
                    string repo_id = repoTable.Rows[0]["repo_id"].ToString();

                    /*select distinct name 
                        from author
                        join commit C on C.repo_id = 1*/
                    string authors = new SELECTQueryBuilder()
                        .setDistinct()
                        .setColumns("name")
                        .setTables("Author")
                        .setInnerJoinBy("commit C on C.repo_id = " + repo_id)
                        .build();
                    populateAuthorBox(authors);

                    repo_and_branch_selected = true;
                }
                
            }

            else if (this.comboBoxSelectRepository.SelectedIndex > -1)
            {
                string repo_url = comboBoxSelectRepository.SelectedItem.ToString();
                
                string id = new SELECTQueryBuilder()
                    .setColumns("repo_id")
                    .setTables("Repository")
                    .setConditionals("repourl = '" + repo_url + "'")
                    .build();

                DataTable repoTable = SQL.execute(id);
                string repo_id = repoTable.Rows[0]["repo_id"].ToString();

                
                string branches = new SELECTQueryBuilder()
                    .setDistinct()
                    .setColumns("name")
                    .setTables("Branch")
                    .setInnerJoinBy("commit C on C.repo_id = " + repo_id)
                    .build();
                populateBranchBox(branches);
                this.comboBoxSelectBranch.Enabled = true; 
            }
            
            
        }

        private void comboBoxSelectRepository_selectionChanged(object sender, EventArgs e)
        {
            shouldEnableFiltering();
        }

        private void comboBoxSelectBranch_selectionChanged(object sender, EventArgs e)
        {
            shouldEnableFiltering();
        }

        private string getRepoID()
        {
            string repoURL = this.comboBoxSelectRepository.SelectedItem.ToString();
            if (repoURL != null || repoURL != string.Empty)
            {

                SELECTQueryBuilder tempQueryBuilder = new SELECTQueryBuilder();
                tempQueryBuilder.setTables("Repository").setColumns("repo_id").setConditionals("repoURL = '" + repoURL + "'");

                string tempSqlStr = tempQueryBuilder.build();
                DataTable tempRepoID = SQL.execute(tempSqlStr);

                if (tempRepoID.Rows.Count > 0)
                {
                    string repo_id = tempRepoID.Rows[0]["repo_id"].ToString();
                    if (repo_id != null || repo_id != string.Empty)
                    {
                        return repo_id;
                    }
    
                }
            }

            return string.Empty;
        }
    }
}