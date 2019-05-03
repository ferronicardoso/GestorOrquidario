using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GestorOrquidario.BLL
{
    public class Floracoes : IBusiness<FlorFloracao>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorFloracao> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorFloracao> GetAll(FlorFloracao value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorFloracao where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorFloracao > 0)
                {
                    parameters.Add(new DBParameter("IdFlorFloracao", DbType.Int32, value.IdFlorFloracao));
                    SqlQuery = SqlQuery + " and IdFlorFloracao = @IdFlorFloracao ";
                }

                if (!string.IsNullOrEmpty(value.Descricao))
                {
                    parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));
                    SqlQuery = SqlQuery + " and Descricao = @Descricao ";
                }
            }

            return new DBConnection().GetList<FlorFloracao>(SqlQuery, parameters);
        }

        public FlorFloracao Get(FlorFloracao value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorFloracao value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));

                if (value.IdFlorFloracao > 0)
                {
                    SqlQuery = "update FlorFloracao set Descricao = @Descricao where IdFlorFloracao = @IdFlorFloracao";
                    parameters.Add(new DBParameter("IdFlorFloracao", DbType.Int32, value.IdFlorFloracao));
                }
                else
                {
                    SqlQuery = "insert into FlorFloracao(Descricao) values (@Descricao)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorFloracao value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorFloracao > 0)
                {
                    string SqlQuery = "delete from FlorFloracao where IdFlorFloracao = @IdFlorFloracao";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorFloracao", DbType.Int32, value.IdFlorFloracao));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorFloracao(Id));
        }
    }
}
