using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView
{
    public class SELECTQueryBuilder : QueryBuilder
    {
        private List<string> columns;
        private List<string> tables;
        private List<string> conditionals;
        private List<string> groupBy;
        private List<string> orderBy;

        public SELECTQueryBuilder()
        {
            this.columns = new List<string>();
            this.tables = new List<string>();
            this.conditionals = new List<string>();
            this.groupBy = new List<string>();
            this.orderBy = new List<string>();
        }

        public SELECTQueryBuilder setColumns(params string[] arguments)
        {
            foreach (string column in arguments)
            {
                this.columns.Add(column);
            }
            return this;
        }

        public SELECTQueryBuilder setTables(params string[] arguments)
        {
            foreach (string table in arguments)
            {
                this.tables.Add(table);
            }
            return this;
        }

        public SELECTQueryBuilder setConditionals(params string[] arguments)
        {
            foreach (string conditional in arguments)
            {
                this.conditionals.Add(conditional);
            }
            return this;
        }

        public SELECTQueryBuilder setGroupBy(params string[] arguments)
        {
            foreach (string groupBy in arguments)
            {
                this.groupBy.Add(groupBy);
            }
            return this;
        }

        public SELECTQueryBuilder setOrderBy(params string[] arguments)
        {
            foreach (string orderBy in arguments)
            {
                this.orderBy.Add(orderBy);
            }
            return this;
        }

        public string build()
        {
            string query = "SELECT ";
            foreach (string column in this.columns) { query += column + ","; }
            query = query.Trim(',');
            query += " FROM ";
            foreach (string table in this.tables) { query += table + ","; }
            query = query.Trim(',');
            if (this.conditionals.Count > 0)
            {
                query += " WHERE ";
                foreach (string conditional in this.conditionals) { query += conditional + ","; }
                query = query.Trim(',');
            }
            if (this.groupBy.Count > 0)
            {
                query += " GROUP BY ";
                foreach (string groupBy in this.groupBy) { query += groupBy + ","; }
                query = query.Trim(',');
            }
            if (this.orderBy.Count > 0)
            {
                query += " ORDER BY ";
                foreach (string orderBy in this.orderBy) { query += orderBy + ","; }
                query = query.Trim(',');
            }
            return query;
        }
    }
}
