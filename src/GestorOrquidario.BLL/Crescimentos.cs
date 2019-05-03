using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GestorOrquidario.BLL
{
    public class Crescimentos : IBusiness<FlorCrescimento>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorCrescimento> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorCrescimento> GetAll(FlorCrescimento value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorCrescimento where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorCrescimento > 0)
                {
                    parameters.Add(new DBParameter("IdFlorCrescimento", DbType.Int32, value.IdFlorCrescimento));
                    SqlQuery = SqlQuery + " and IdFlorCrescimento = @IdFlorCrescimento ";
                }

                if (!string.IsNullOrEmpty(value.Descricao))
                {
                    parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));
                    SqlQuery = SqlQuery + " and Descricao = @Descricao ";
                }
            }

            return new DBConnection().GetList<FlorCrescimento>(SqlQuery, parameters);
        }

        public FlorCrescimento Get(FlorCrescimento value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorCrescimento value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Descricao", DbType.String, value.Descricao));

                if (value.IdFlorCrescimento > 0)
                {
                    SqlQuery = "update FlorCrescimento set Descricao = @Descricao where IdFlorCrescimento = @IdFlorCrescimento";
                    parameters.Add(new DBParameter("IdFlorCrescimento", DbType.Int32, value.IdFlorCrescimento));
                }
                else
                {
                    SqlQuery = "insert into FlorCrescimento(Descricao) values (@Descricao)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorCrescimento value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorCrescimento > 0)
                {
                    string SqlQuery = "delete from FlorCrescimento where IdFlorCrescimento = @IdFlorCrescimento";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorCrescimento", DbType.Int32, value.IdFlorCrescimento));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorCrescimento(Id));
        }
    }
}
