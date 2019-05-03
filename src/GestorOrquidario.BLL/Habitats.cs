using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GestorOrquidario.BLL
{
    public class Habitats : IBusiness<FlorHabitat>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorHabitat> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorHabitat> GetAll(FlorHabitat value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorHabitat where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorHabitat > 0)
                {
                    parameters.Add(new DBParameter("IdFlorHabitat", DbType.Int32, value.IdFlorHabitat));
                    SqlQuery = SqlQuery + " and IdFlorHabitat = @IdFlorHabitat ";
                }

                if (!string.IsNullOrEmpty(value.Descricao))
                {
                    parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));
                    SqlQuery = SqlQuery + " and Descricao = @Descricao ";
                }
            }

            return new DBConnection().GetList<FlorHabitat>(SqlQuery, parameters);
        }

        public FlorHabitat Get(FlorHabitat value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorHabitat value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));

                if (value.IdFlorHabitat > 0)
                {
                    SqlQuery = "update FlorHabitat set Descricao = @Descricao where IdFlorHabitat = @IdFlorHabitat";
                    parameters.Add(new DBParameter("IdFlorHabitat", DbType.Int32, value.IdFlorHabitat));
                }
                else
                {
                    SqlQuery = "insert into FlorHabitat(Descricao) values (@Descricao)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorHabitat value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorHabitat > 0)
                {
                    string SqlQuery = "delete from FlorHabitat where IdFlorHabitat = @IdFlorHabitat";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorHabitat", DbType.Int32, value.IdFlorHabitat));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorHabitat(Id));
        }
    }
}
