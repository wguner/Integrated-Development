using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView
{
    public class INSERTQueryBuilder : QueryBuilder
    {
        private string table;
        private List<string> columns;
        private List<string> values;

        public INSERTQueryBuilder()
        {
            this.table = "";
            this.columns = new List<string>();
            this.values = new List<string>();
            
        }

        public INSERTQueryBuilder setTable(string table)
        {
            this.table = table;
            return this;
        }

        public INSERTQueryBuilder addColumnValue(string column, string value)
        {
            this.columns.Add(column);
            this.values.Add(value);
            return this;
        }

        public string build()
        {
            string query = "INSERT INTO " + table + "(";
            foreach (string column in this.columns)
            {
                query += column + ",";
            }
            query = query.Trim(',');
            query += ") VALUES (";
            foreach (string value in this.values)
            {
                query += "'" + cleanforsql(value) + "',";
            }
            query = query.Trim(',');
            query += ")";
            return query;
        }

        public string cleanforsql(string value)
        {
            return value.Replace("'", "");
        }
    }
}
