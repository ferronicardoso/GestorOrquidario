using System;

namespace GestorOrquidario.DAL
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnMappingAttribute : Attribute
    {
        string source = string.Empty;
        bool primaryKey = false;

        public ColumnMappingAttribute() { }

        public string Source { get { return this.source; } set { this.source = value; } }
        public bool PrimaryKey { get { return this.primaryKey; } set { this.primaryKey = false; } }
    }
}
