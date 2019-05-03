using System;
using System.Collections;
using System.Data;

namespace GestorOrquidario.DAL
{
    public class DBParameterCollection : ArrayList, IDataParameterCollection
    {
        public DBParameterCollection()
            : base()
        { }

        #region IDataParameterCollection Members

        public object this[string parameterName]
        {
            get
            {
                return this[IndexOf(parameterName)];
            }
            set
            {
                this[IndexOf(parameterName)] = value;
            }
        }

        public void RemoveAt(string parameterName)
        {
            RemoveAt(IndexOf(parameterName));
        }

        public bool Contains(string parameterName)
        {
            return (-1 != IndexOf(parameterName));
        }

        public int IndexOf(string parameterName)
        {
            int idx = 0;
            foreach (DBParameter param in this)
            {
                if (parameterName == param.ParameterName) return idx;
                idx++;
            }
            return -1;
        }

        #endregion

        public override bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public override int Add(object value)
        {
            return Add((DBParameter)value);
        }

        public int Add(DBParameter value)
        {
            if (value.ParameterName != null)
            {
                return base.Add(value);
            }
            else
            {
                throw new ArgumentException("DBParameter must have a name");
            }
        }

        public int Add(string parameterName, DbType dbType)
        {
            return Add(new DBParameter(parameterName, dbType));
        }

        public int Add(string parameterName, object value)
        {
            return Add(new DBParameter(parameterName, value));
        }

        public int Add(string parameterName, DbType type, string sourceColumn)
        {
            return Add(new DBParameter(parameterName, type, sourceColumn));
        }
    }
}
