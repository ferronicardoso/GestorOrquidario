using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GestorOrquidario.BLL
{
    public class Generos : IBusiness<FlorGenero>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorGenero> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorGenero> GetAll(FlorGenero value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorGenero where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorGenero > 0)
                {
                    parameters.Add(new DBParameter("IdFlorGenero", DbType.Int32, value.IdFlorGenero));
                    SqlQuery = SqlQuery + " and IdFlorGenero = @IdFlorGenero ";
                }

                if (!string.IsNullOrEmpty(value.Descricao))
                {
                    parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));
                    SqlQuery = SqlQuery + " and Descricao = @Descricao ";
                }
            }

            return new DBConnection().GetList<FlorGenero>(SqlQuery, parameters);
        }

        public FlorGenero Get(FlorGenero value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorGenero value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));

                if (value.IdFlorGenero > 0)
                {
                    SqlQuery = "update FlorGenero set Descricao = @Descricao where IdFlorGenero = @IdFlorGenero";
                    parameters.Add(new DBParameter("IdFlorGenero", DbType.Int32, value.IdFlorGenero));
                }
                else
                {
                    SqlQuery = "insert into FlorGenero(Descricao) values (@Descricao)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorGenero value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorGenero > 0)
                {
                    string SqlQuery = "delete from FlorGenero where IdFlorGenero = @IdFlorGenero";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorGenero", DbType.Int32, value.IdFlorGenero));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorGenero(Id));
        }
    }
}
