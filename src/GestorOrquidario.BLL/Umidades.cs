using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GestorOrquidario.BLL
{
    public class Umidades : IBusiness<FlorUmidade>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorUmidade> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorUmidade> GetAll(FlorUmidade value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorUmidade where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorUmidade > 0)
                {
                    parameters.Add(new DBParameter("IdFlorUmidade", DbType.Int32, value.IdFlorUmidade));
                    SqlQuery = SqlQuery + " and IdFlorUmidade = @IdFlorUmidade ";
                }

                if (!string.IsNullOrEmpty(value.Descricao))
                {
                    parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));
                    SqlQuery = SqlQuery + " and Descricao = @Descricao ";
                }
            }

            return new DBConnection().GetList<FlorUmidade>(SqlQuery, parameters);
        }

        public FlorUmidade Get(FlorUmidade value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorUmidade value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));

                if (value.IdFlorUmidade > 0)
                {
                    SqlQuery = "update FlorUmidade set Descricao = @Descricao where IdFlorUmidade = @IdFlorUmidade";
                    parameters.Add(new DBParameter("IdFlorUmidade", DbType.Int32, value.IdFlorUmidade));
                }
                else
                {
                    SqlQuery = "insert into FlorUmidade(Descricao) values (@Descricao)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorUmidade value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorUmidade > 0)
                {
                    string SqlQuery = "delete from FlorUmidade where IdFlorUmidade = @IdFlorUmidade";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorUmidade", DbType.Int32, value.IdFlorUmidade));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorUmidade(Id));
        }
    }
}
