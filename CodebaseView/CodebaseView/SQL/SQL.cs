using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView
{
    public static class SQL
    {
        public static readonly string connectionString = "Host = localhost; Username = postgres; Database = 421Db; password = password";

<<<<<<< HEAD:CodebaseView/CodebaseView/SQL.cs
        public static string getMostRecentCommitID()
        {
            
            string query = new SELECTQueryBuilder().setColumns("commit_id")
                                .setTables("commit").build();
            var data = execute(query);
            if (data.Rows.Count > 0)
                return data.Rows[data.Rows.Count - 1]["commit_id"].ToString();
            else
                return "";    
        }
        
=======
>>>>>>> databaseFileMapping:CodebaseView/CodebaseView/SQL/SQL.cs
        public static DataTable execute(string sqlstr)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand(sqlstr, connection))
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        da.Fill(dt);
                        return dt;
                    }
                    catch (NpgsqlException e)
                    {
                        Console.WriteLine(e.Message.ToString());
                        MessageBox message = new MessageBox("SQL Error: " + e.Message.ToString() + "\n Failing Query: " + sqlstr);
                        message.Show();
                        return null;
                    }
                }
            }
        }

        public static bool executeInsert(string sqlstr)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand(sqlstr, connection))
                {
                    try
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        return true;
                    }
                    catch (NpgsqlException e)
                    {
                        return false;
                    }
                }
            }
        }
    }
 
}
