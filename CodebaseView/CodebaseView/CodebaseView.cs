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
            displayCommitInfo();

        }
        public void displayCommitInfo()
        {
            string sqlstr = "SELECT commit_id FROM commit";
            DataTable commitinfo = new DataTable();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlstr, connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(commitinfo);
                            // s.binding.DataSource = commitInfo;
                            this.dataGridView1.DataSource = commitinfo;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    connection.Close();
                }
            }
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
            string commitId = this.dataGridView1.Rows[row].Cells[0].Value.ToString();
            string sqlstr = "SELECT message, author FROM commit WHERE commit_id = '" + commitId + "'";
            DataTable commitinfo = new DataTable();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlstr, connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(commitinfo);
                            // s.binding.DataSource = commitInfo;
                            textBox2.Text = commitinfo.Rows[0]["message"].ToString();
                            textBox3.Text = commitinfo.Rows[0]["author"].ToString();
                        }
                    }
                }
                catch (Exception s)
                {
                    Console.WriteLine(s);
                }
                finally
                {
                    connection.Close();
                }
            }
            
            string sqlstr2 = "SELECT filename FROM file WHERE commit_id = '" + commitId + "'";
            DataTable commitinfo2 = new DataTable();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlstr2, connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(commitinfo2);
                            // s.binding.DataSource = commitInfo;
                            textBox4.Text = commitinfo2.Rows[0]["filename"].ToString();
                        }
                    }
                }
                catch (Exception s)
                {
                    Console.WriteLine(s);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }
}

