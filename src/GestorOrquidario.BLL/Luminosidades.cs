using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GestorOrquidario.BLL
{
    public class Luminosidades : IBusiness<FlorLuminosidade>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorLuminosidade> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorLuminosidade> GetAll(FlorLuminosidade value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorLuminosidade where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorLuminosidade > 0)
                {
                    parameters.Add(new DBParameter("IdFlorLuminosidade", DbType.Int32, value.IdFlorLuminosidade));
                    SqlQuery = SqlQuery + " and IdFlorLuminosidade = @IdFlorLuminosidade ";
                }

                if (!string.IsNullOrEmpty(value.Descricao))
                {
                    parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));
                    SqlQuery = SqlQuery + " and Descricao = @Descricao ";
                }
            }

            return new DBConnection().GetList<FlorLuminosidade>(SqlQuery, parameters);
        }

        public FlorLuminosidade Get(FlorLuminosidade value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorLuminosidade value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));

                if (value.IdFlorLuminosidade > 0)
                {
                    SqlQuery = "update FlorLuminosidade set Descricao = @Descricao where IdFlorLuminosidade = @IdFlorLuminosidade";
                    parameters.Add(new DBParameter("IdFlorLuminosidade", DbType.Int32, value.IdFlorLuminosidade));
                }
                else
                {
                    SqlQuery = "insert into FlorLuminosidade(Descricao) values (@Descricao)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorLuminosidade value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorLuminosidade > 0)
                {
                    string SqlQuery = "delete from FlorLuminosidade where IdFlorLuminosidade = @IdFlorLuminosidade";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorLuminosidade", DbType.Int32, value.IdFlorLuminosidade));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorLuminosidade(Id));
        }
    }
}
