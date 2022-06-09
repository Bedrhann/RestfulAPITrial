using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bedirhan_Hafta_2.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string TableName { get; }
        public TableAttribute(string tableName)
        {
            TableName = tableName;
        }
    }
    public class ColumnAttribute : Attribute
    {
        public string Features { get; }
        public ColumnAttribute(string features)
        {
            Features = features;
        }
    }
}
