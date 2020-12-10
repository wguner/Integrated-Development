using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseView
{
    public class QueryInsertBuild
    {
        public string buildString(string table, List<String> attributes, List<string> values)
        {
            string queryString = "INSERT TO" + table + "(" + LoopAttributes(attributes) + ") " + "VALUES( "
                + LoopValues(values) + ");";
            return queryString;
        }
        public string LoopAttributes(List<string> attributes)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < attributes.Count; i++)
            {
                if (attributes.Count - 1 == i)
                {
                    stringBuilder.Append(attributes[i]);
                }
                else
                {
                    stringBuilder.Append(attributes[i] + ", ");
                }
            }
            return stringBuilder.ToString();
        }
        public string LoopValues(List<string> values)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < values.Count; i++)
            {
                if(values.Count - 1 == i)
                {
                    stringBuilder.Append("'" + values[i] + "' ");
                }
                else
                {
                    if(values[i] == "Date") // place holder for date attribute
                    {
                        stringBuilder.Append(values[i] + "', ");
                    }
                    else
                    {
                        stringBuilder.Append("'" + values[i] + "', ");
                    }
                }
            }
            return stringBuilder.ToString();
        }
    }
}
