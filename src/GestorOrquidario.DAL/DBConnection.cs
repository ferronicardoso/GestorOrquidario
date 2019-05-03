using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;

namespace GestorOrquidario.DAL
{
    public class DBConnection
    {
        private const string CONNECTIONSTRING_NAME = "DBConnection";

        private string ConnectionStringName { get; set; }

        private string ConnectionString
        {
            get
            {
                string _connectionString = ConfigurationManager.ConnectionStrings[this.ConnectionStringName].ConnectionString;
                return _connectionString;
            }
        }

        public string DatabasePath
        {
            get
            {
                SQLiteConnectionStringBuilder connBuilder = new SQLiteConnectionStringBuilder();
                connBuilder.ConnectionString = ConfigurationManager.ConnectionStrings[CONNECTIONSTRING_NAME].ConnectionString;

                string _DatabasePath = connBuilder.DataSource;
                return _DatabasePath;
            }
        }

        public DBConnection()
        {
            this.ConnectionStringName = CONNECTIONSTRING_NAME;
        }

        public DBConnection(string connectionStringName)
        {
            this.ConnectionStringName = string.IsNullOrEmpty(connectionStringName) ? CONNECTIONSTRING_NAME : connectionStringName;
        }

        public List<T> GetList<T>(string SqlQuery) where T : new()
        {
            return GetList<T>(SqlQuery, null);
        }

        public List<T> GetList<T>(string SqlQuery, DBParameterCollection parameters) where T : new()
        {
            var t = new List<T>();

            using (SQLiteConnection connection = new SQLiteConnection(this.ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = connection;
                    command.CommandText = SqlQuery;

                    if (parameters != null && parameters.Count > 0)
                    {
                        foreach (DBParameter item in parameters)
                        {
                            command.Parameters.Add(new SQLiteParameter(item.ParameterName, item.DbType));
                        }
                    }

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        t = reader.ToList<T>();
                    }
                }
            }

            return t;
        }

        public bool Set(string SqlQuery)
        {
            return Set(SqlQuery, null);
        }

        public bool Set(string SqlQuery, DBParameterCollection parameters)
        {
            int Id = Set(SqlQuery, parameters, false);
            return Id > 0;
        }

        public int Set(string SqlQuery, DBParameterCollection parameters, bool returnId = false)
        {
            int Id = 0;

            using (SQLiteConnection connection = new SQLiteConnection(this.ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    if (returnId)
                    {
                        SqlQuery = string.Format("{0}; select last_insert_rowid();", SqlQuery);
                    }

                    command.Connection = connection;
                    command.CommandText = SqlQuery;

                    if (parameters != null && parameters.Count > 0)
                    {
                        foreach (DBParameter item in parameters)
                        {
                            SQLiteParameter param = new SQLiteParameter();
                            param.ParameterName = item.ParameterName;
                            param.DbType = item.DbType;
                            param.Value = item.Value;
                            command.Parameters.Add(param);
                        }
                    }

                    Id = returnId ? Convert.ToInt32(command.ExecuteScalar()) : command.ExecuteNonQuery();
                }
            }

            return Id;
        }
    }
}
