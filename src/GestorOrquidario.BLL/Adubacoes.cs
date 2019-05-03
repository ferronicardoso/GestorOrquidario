using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GestorOrquidario.BLL
{
    public class Adubacoes : IBusiness<FlorAdubacao>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorAdubacao> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorAdubacao> GetAll(FlorAdubacao value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorAdubacao where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorAdubacao > 0)
                {
                    parameters.Add(new DBParameter("IdFlorAdubacao", DbType.Int32, value.IdFlorAdubacao));
                    SqlQuery = SqlQuery + " and IdFlorAdubacao = @IdFlorAdubacao ";
                }

                if (!string.IsNullOrEmpty(value.Descricao))
                {
                    parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));
                    SqlQuery = SqlQuery + " and Descricao = @Descricao ";
                }
            }

            return new DBConnection().GetList<FlorAdubacao>(SqlQuery, parameters);
        }

        public FlorAdubacao Get(FlorAdubacao value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorAdubacao value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));

                if (value.IdFlorAdubacao > 0)
                {
                    SqlQuery = "update FlorAdubacao set Descricao = @Descricao where IdFlorAdubacao = @IdFlorAdubacao";
                    parameters.Add(new DBParameter("IdFlorAdubacao", DbType.Int32, value.IdFlorAdubacao));
                }
                else
                {
                    SqlQuery = "insert into FlorAdubacao(Descricao) values (@Descricao)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorAdubacao value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorAdubacao > 0)
                {
                    string SqlQuery = "delete from FlorAdubacao where IdFlorAdubacao = @IdFlorAdubacao";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorAdubacao", DbType.Int32, value.IdFlorAdubacao));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorAdubacao(Id));
        }
    }
}
