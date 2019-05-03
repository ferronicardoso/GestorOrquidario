using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GestorOrquidario.BLL
{
    public class Substrtatos : IBusiness<FlorSubstrato>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorSubstrato> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorSubstrato> GetAll(FlorSubstrato value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorSubstrato where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorSubstrato > 0)
                {
                    parameters.Add(new DBParameter("IdFlorSubstrato", DbType.Int32, value.IdFlorSubstrato));
                    SqlQuery = SqlQuery + " and IdFlorSubstrato = @IdFlorSubstrato ";
                }

                if (!string.IsNullOrEmpty(value.Descricao))
                {
                    parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));
                    SqlQuery = SqlQuery + " and Descricao = @Descricao ";
                }
            }

            return new DBConnection().GetList<FlorSubstrato>(SqlQuery, parameters);
        }

        public FlorSubstrato Get(FlorSubstrato value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorSubstrato value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));

                if (value.IdFlorSubstrato > 0)
                {
                    SqlQuery = "update FlorSubstrato set Descricao = @Descricao where IdFlorSubstrato = @IdFlorSubstrato";
                    parameters.Add(new DBParameter("IdFlorSubstrato", DbType.Int32, value.IdFlorSubstrato));
                }
                else
                {
                    SqlQuery = "insert into FlorSubstrato(Descricao) values (@Descricao)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorSubstrato value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorSubstrato > 0)
                {
                    string SqlQuery = "delete from FlorSubstrato where IdFlorSubstrato = @IdFlorSubstrato";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorSubstrato", DbType.Int32, value.IdFlorSubstrato));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorSubstrato(Id));
        }
    }
}
