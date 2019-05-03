using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GestorOrquidario.BLL
{
    public class Configuracoes : IBusiness<FlorConfiguracao>
    {
        private DBParameterCollection parameters;

        public IEnumerable<FlorConfiguracao> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorConfiguracao> GetAll(FlorConfiguracao value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorConfiguracao where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorConfiguracao > 0)
                {
                    parameters.Add(new DBParameter("IdFlorConfiguracao", DbType.Int32, value.IdFlorConfiguracao));
                    SqlQuery = SqlQuery + " and IdFlorConfiguracao = @IdFlorConfiguracao ";
                }
            }

            return new DBConnection().GetList<FlorConfiguracao>(SqlQuery, parameters);
        }

        public FlorConfiguracao Get(FlorConfiguracao value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorConfiguracao value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Background", DbType.Binary, value.Background));

                if (value.IdFlorConfiguracao > 0)
                {
                    SqlQuery = "update FlorConfiguracao set Background = @Background where IdFlorConfiguracao = @IdFlorConfiguracao";
                    parameters.Add(new DBParameter("IdFlorConfiguracao", DbType.Int32, value.IdFlorConfiguracao));
                }
                else
                {
                    SqlQuery = "insert into FlorConfiguracao(Background) values (@Background)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorConfiguracao value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorConfiguracao > 0)
                {
                    string SqlQuery = "delete from FlorConfiguracao where IdFlorConfiguracao = @IdFlorConfiguracao";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorConfiguracao", DbType.Int32, value.IdFlorConfiguracao));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorConfiguracao(Id));
        }
    }
}
