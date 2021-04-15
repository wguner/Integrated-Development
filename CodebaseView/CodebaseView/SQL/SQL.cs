using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView
{
    public static class SQL
    {
        public static readonly string connectionString = "Host = localhost; Port = 5432; Username = postgres; Database = 421Db; password = password";

        public static DataTable execute(string sqlstr)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
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
                
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("File not found." + e.ToString());
                    return null;
                }
            }
        }
    }
}
