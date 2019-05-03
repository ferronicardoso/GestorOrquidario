using System.Data;

namespace GestorOrquidario.DAL
{
    public class DBParameter : IDataParameter
    {
        public DBParameter()
        {

        }

        public DBParameter(string parameterName, DbType dbType)
        {
            this.ParameterName = parameterName;
            this.DbType = dbType;
        }

        public DBParameter(string parameterName, object value)
        {
            this.ParameterName = parameterName;
            this.Value = value;
        }

        public DBParameter(string parameterName, DbType dbType, object value)
        {
            this.ParameterName = parameterName;
            this.DbType = dbType;
            this.Value = value;
        }

        public DbType DbType { get; set; }

        public ParameterDirection Direction { get; set; }

        public bool IsNullable
        {
            get { return false; }
        }

        public string ParameterName { get; set; }
        public string SourceColumn { get; set; }
        public DataRowVersion SourceVersion { get; set; }
        public object Value { get; set; }
    }
}
