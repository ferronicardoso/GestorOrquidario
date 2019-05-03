using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GestorOrquidario.BLL
{
    public class Fotos : IBusiness<FlorFoto>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorFoto> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorFoto> GetAll(FlorFoto value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorFoto where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorFoto > 0)
                {
                    parameters.Add(new DBParameter("IdFlorFoto", DbType.Int32, value.IdFlorFoto));
                    SqlQuery = SqlQuery + " and IdFlorFoto = @IdFlorFoto ";
                }

                if (value.IdFlor > 0)
                {
                    parameters.Add(new DBParameter("IdFlor", DbType.Int32, value.IdFlor));
                    SqlQuery = SqlQuery + " and IdFlor = @IdFlor ";
                }
            }

            return new DBConnection().GetList<FlorFoto>(SqlQuery, parameters);
        }

        public FlorFoto Get(FlorFoto value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorFoto[] values)
        {
            bool saved = false;

            int i = 0;

            foreach (FlorFoto item in values)
            {
                if (Set(item)) i++;
            }

            saved = values.Length == i;

            return saved;
        }

        public bool Set(FlorFoto value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();

                if (value.IdFlor > 0)
                {
                    parameters.Add(new DBParameter("Conteudo", DbType.Binary, value.Conteudo));

                    if (value.IdFlorFoto > 0)
                    {
                        SqlQuery = "update FlorFoto set Conteudo = @Conteudo where IdFlorFoto = @IdFlorFoto";
                        parameters.Add(new DBParameter("IdFlorFoto", DbType.Int32, value.IdFlorFoto));
                    }
                    else
                    {
                        SqlQuery = "insert into FlorFoto(IdFlor, Conteudo) values (@IdFlor, @Conteudo)";
                        parameters.Add(new DBParameter("IdFlor", DbType.Int32, value.IdFlor));
                    }
                 
                    saved = new DBConnection().Set(SqlQuery, parameters);
               }                
            }

            return saved;
        }
        
        public bool Delete(FlorFoto value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorFoto > 0)
                {
                    string SqlQuery = "delete from FlorFoto where IdFlorFoto = @IdFlorFoto";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorFoto", DbType.Int32, value.IdFlorFoto));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorFoto(Id));
        }
    }
}
