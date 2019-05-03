using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GestorOrquidario.BLL
{
    public class Fornecedores : IBusiness<FlorFornecedor>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorFornecedor> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorFornecedor> GetAll(FlorFornecedor value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorFornecedor where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorFornecedor > 0)
                {
                    parameters.Add(new DBParameter("IdFlorFornecedor", DbType.Int32, value.IdFlorFornecedor));
                    SqlQuery = SqlQuery + " and IdFlorFornecedor = @IdFlorFornecedor ";
                }

                if (!string.IsNullOrEmpty(value.Nome))
                {
                    parameters.Add(new DBParameter("Nome", DbType.String, value.Nome));
                    SqlQuery = SqlQuery + " and Nome = @Nome ";
                }
            }

            return new DBConnection().GetList<FlorFornecedor>(SqlQuery, parameters);
        }

        public FlorFornecedor Get(FlorFornecedor value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(FlorFornecedor value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Nome", DbType.String, value.Nome));

                if (value.IdFlorFornecedor > 0)
                {
                    SqlQuery = "update FlorFornecedor set Nome = @Nome where IdFlorFornecedor = @IdFlorFornecedor";
                    parameters.Add(new DBParameter("IdFlorFornecedor", DbType.Int32, value.IdFlorFornecedor));
                }
                else
                {
                    SqlQuery = "insert into FlorFornecedor(Nome) values (@Nome)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorFornecedor value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorFornecedor > 0)
                {
                    string SqlQuery = "delete from FlorFornecedor where IdFlorFornecedor = @IdFlorFornecedor";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorFornecedor", DbType.Int32, value.IdFlorFornecedor));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorFornecedor(Id));
        }
    }
}
