using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace CodebaseView
{
    public class QueryExecuter
    {
        string queryString;
        Action<NpgsqlDataReader> action;
        public QueryExecuter(string queryString, Action<NpgsqlDataReader> action)
        {
            this.queryString = queryString;
            this.action = action;
            this.ExecuteQuery();
        }
        public QueryExecuter(string queryString)
        {
            this.queryString = queryString;
            this.ExecuteCommandQuery();
        }
        private string buildConnectionString()
        {
            // placeholder for the db
            return "Host = localhost; Username = postgres; Database = 421Db; password = password;";
        }

        public void ExecuteQuery()
        {
            using (var connection = new NpgsqlConnection(buildConnectionString()))
            {
                connection.Open();
                using(var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = queryString;
                    try
                    {
                        var reader = cmd.ExecuteReader();
                        while (reader.Read()) action(reader);
                    }
                    catch (NpgsqlException e)
                    {
                        Console.WriteLine(e.Message.ToString());  
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void ExecuteCommandQuery()
        {
            using (var connection = new NpgsqlConnection(buildConnectionString()))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = queryString;
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        Console.WriteLine(e.Message.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
