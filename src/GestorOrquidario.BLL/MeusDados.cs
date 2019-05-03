using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GestorOrquidario.BLL
{
    public class MeusDados : IBusiness<FlorMeusDados>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<FlorMeusDados> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<FlorMeusDados> GetAll(FlorMeusDados value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select * from FlorMeusDados where 1 = 1";

            if (value != null)
            {
                if (value.IdFlorMeusDados > 0)
                {
                    parameters.Add(new DBParameter("IdFlorMeusDados", DbType.Int32, value.IdFlorMeusDados));
                    SqlQuery = SqlQuery + " and IdFlorMeusDados = @IdFlorMeusDados ";
                }

                if (!string.IsNullOrEmpty(value.Nome))
                {
                    parameters.Add(new DBParameter("Nome", DbType.String, value.Nome));
                    SqlQuery = SqlQuery + " and Nome = @Nome ";
                }
            }

            return new DBConnection().GetList<FlorMeusDados>(SqlQuery, parameters);
        }

        public FlorMeusDados Get(FlorMeusDados value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public IEnumerable<FlorUf> GetAllUf()
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select IdFlorUf, Sigla from FlorUf where 1 = 1";

            return new DBConnection().GetList<FlorUf>(SqlQuery, parameters);
        }

        public bool Set(FlorMeusDados value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Nome", DbType.String, value.Nome));
                parameters.Add(new DBParameter("Endereco", DbType.String, value.Endereco));
                parameters.Add(new DBParameter("Complemento", DbType.String, value.Complemento));
                parameters.Add(new DBParameter("Bairro", DbType.String, value.Bairro));
                parameters.Add(new DBParameter("Cidade", DbType.String, value.Cidade));
                parameters.Add(new DBParameter("Telefone", DbType.String, value.Telefone));
                parameters.Add(new DBParameter("Celular", DbType.String, value.Celular));
                parameters.Add(new DBParameter("Cep", DbType.String, value.Cep));
                parameters.Add(new DBParameter("Email", DbType.String, value.Email));
                parameters.Add(new DBParameter("Site", DbType.String, value.Site));
                parameters.Add(new DBParameter("MSN", DbType.String, value.MSN));
                parameters.Add(new DBParameter("Skype", DbType.String, value.Skype));
                parameters.Add(new DBParameter("Imagem", DbType.Binary, value.Imagem));
                parameters.Add(new DBParameter("IdFlorUf", DbType.Int32, value.IdFlorUf));
                
                if (value.IdFlorMeusDados > 0)
                {
                    SqlQuery = "update FlorMeusDados set ";
                    SqlQuery = SqlQuery + " Nome = @Nome, ";
                    SqlQuery = SqlQuery + " Endereco = @Endereco, ";
                    SqlQuery = SqlQuery + " Complemento = @Complemento, ";
                    SqlQuery = SqlQuery + " Bairro = @Bairro, ";
                    SqlQuery = SqlQuery + " Cidade = @Cidade, ";
                    SqlQuery = SqlQuery + " Telefone = @Telefone, ";
                    SqlQuery = SqlQuery + " Celular = @Celular, ";
                    SqlQuery = SqlQuery + " Cep = @Cep, ";
                    SqlQuery = SqlQuery + " Email = @Email, ";
                    SqlQuery = SqlQuery + " Site = @Site, ";
                    SqlQuery = SqlQuery + " MSN = @MSN, ";
                    SqlQuery = SqlQuery + " Skype = @Skype, ";
                    SqlQuery = SqlQuery + " Imagem = @Imagem, ";
                    SqlQuery = SqlQuery + " IdFlorUf = @IdFlorUf";

                    SqlQuery = SqlQuery + " where IdFlorMeusDados = @IdFlorMeusDados";
                    parameters.Add(new DBParameter("IdFlorMeusDados", DbType.Int32, value.IdFlorMeusDados));
                }
                else
                {
                    SqlQuery = "insert into FlorMeusDados(Nome, Endereco, Complemento, Bairro, Cidade, Telefone, Celular, Cep, Email, Site, MSN, Skype, Imagem, IdFlorUf) ";
                    SqlQuery = SqlQuery + "values (@Nome, @Endereco, @Complemento, @Bairro, @Cidade, @Telefone, @Celular, @Cep, @Email, @Site, @MSN, @Skype, @Imagem, @IdFlorUf)";
                }

                saved = new DBConnection().Set(SqlQuery, parameters);
            }

            return saved;
        }

        public bool Delete(FlorMeusDados value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorMeusDados > 0)
                {
                    string SqlQuery = "delete from FlorMeusDados where IdFlorMeusDados = @IdFlorMeusDados";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlorMeusDados", DbType.Int32, value.IdFlorMeusDados));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new FlorMeusDados(Id));
        }
    }
}
