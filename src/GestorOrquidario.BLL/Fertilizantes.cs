using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GestorOrquidario.BLL
{
    public class Fertilizantes : IBusiness<FlorFertilizante>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorFertilizante> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorFertilizante> GetAll(FlorFertilizante value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorFertilizante where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorFertilizante > 0)
                {
                    parameters.Add(new DBParameter("IdFlorFertilizante", DbType.Int32, value.IdFlorFertilizante));
                    SqlQuery = SqlQuery + " and IdFlorFertilizante = @IdFlorFertilizante ";
                }

                if (!string.IsNullOrEmpty(value.Descricao))
                {
                    parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));
                    SqlQuery = SqlQuery + " and Descricao = @Descricao ";
                }
            }

            return new DBConnection().GetList<FlorFertilizante>(SqlQuery, parameters);
        }

        public FlorFertilizante Get(FlorFertilizante value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorFertilizante value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));

                if (value.IdFlorFertilizante > 0)
                {
                    SqlQuery = "update FlorFertilizante set Descricao = @Descricao where IdFlorFertilizante = @IdFlorFertilizante";
                    parameters.Add(new DBParameter("IdFlorFertilizante", DbType.Int32, value.IdFlorFertilizante));
                }
                else
                {
                    SqlQuery = "insert into FlorFertilizante(Descricao) values (@Descricao)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorFertilizante value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorFertilizante > 0)
                {
                    string SqlQuery = "delete from FlorFertilizante where IdFlorFertilizante = @IdFlorFertilizante";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorFertilizante", DbType.Int32, value.IdFlorFertilizante));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorFertilizante(Id));
        }
    }
}
