using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GestorOrquidario.BLL
{
    public class Tipos : IBusiness<FlorTipo>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorTipo> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorTipo> GetAll(FlorTipo value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorTipo where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorTipo > 0)
                {
                    parameters.Add(new DBParameter("IdFlorTipo", DbType.Int32, value.IdFlorTipo));
                    SqlQuery = SqlQuery + " and IdFlorTipo = @IdFlorTipo ";
                }

                if (!string.IsNullOrEmpty(value.Descricao))
                {
                    parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));
                    SqlQuery = SqlQuery + " and Descricao = @Descricao ";
                }
            }

            return new DBConnection().GetList<FlorTipo>(SqlQuery, parameters);
        }

        public FlorTipo Get(FlorTipo value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorTipo value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));

                if (value.IdFlorTipo > 0)
                {
                    SqlQuery = "update FlorTipo set Descricao = @Descricao where IdFlorTipo = @IdFlorTipo";
                    parameters.Add(new DBParameter("IdFlorTipo", DbType.Int32, value.IdFlorTipo));
                }
                else
                {
                    SqlQuery = "insert into FlorTipo(Descricao) values (@Descricao)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorTipo value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorTipo > 0)
                {
                    string SqlQuery = "delete from FlorTipo where IdFlorTipo = @IdFlorTipo";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorTipo", DbType.Int32, value.IdFlorTipo));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorTipo(Id));
        }
    }
}
