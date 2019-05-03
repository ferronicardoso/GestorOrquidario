using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GestorOrquidario.BLL
{
    public class Origens : IBusiness<FlorOrigem>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorOrigem> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorOrigem> GetAll(FlorOrigem value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorOrigem where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorOrigem > 0)
                {
                    parameters.Add(new DBParameter("IdFlorOrigem", DbType.Int32, value.IdFlorOrigem));
                    SqlQuery = SqlQuery + " and IdFlorOrigem = @IdFlorOrigem ";
                }

                if (!string.IsNullOrEmpty(value.Descricao))
                {
                    parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));
                    SqlQuery = SqlQuery + " and Descricao = @Descricao ";
                }
            }

            return new DBConnection().GetList<FlorOrigem>(SqlQuery, parameters);
        }

        public FlorOrigem Get(FlorOrigem value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorOrigem value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));

                if (value.IdFlorOrigem > 0)
                {
                    SqlQuery = "update FlorOrigem set Descricao = @Descricao where IdFlorOrigem = @IdFlorOrigem";
                    parameters.Add(new DBParameter("IdFlorOrigem", DbType.Int32, value.IdFlorOrigem));
                }
                else
                {
                    SqlQuery = "insert into FlorOrigem(Descricao) values (@Descricao)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorOrigem value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorOrigem > 0)
                {
                    string SqlQuery = "delete from FlorOrigem where IdFlorOrigem = @IdFlorOrigem";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorOrigem", DbType.Int32, value.IdFlorOrigem));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorOrigem(Id));
        }
    }
}
