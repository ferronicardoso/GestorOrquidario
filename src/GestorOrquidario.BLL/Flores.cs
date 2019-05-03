using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GestorOrquidario.BLL
{
    public class Flores : IBusiness<Flor>
    {
        DBParameterCollection parameters = null;

        public IEnumerable<Flor> GetAll()
        {
            return GetAll(null);
        }

        public IEnumerable<Flor> GetAll(Flor value)
        {
            parameters = new DBParameterCollection();

            string SqlQuery = "select a.*, b.Conteudo as Foto, b.IdFlorFoto from Flor a left join FlorFoto b on (b.IdFlor = a.IdFlor) where 1 = 1 ";

            if (value != null)
            {
                if (value.IdFlorGenero > 0)
                {
                    parameters.Add(new DBParameter("IdFlor", DbType.Int32, value.IdFlor));
                    SqlQuery = SqlQuery + " and IdFlor = @IdFlor ";
                }

                if (!string.IsNullOrEmpty(value.Especie))
                {
                    parameters.Add(new DBParameter("Especie", DbType.String, value.Especie));
                    SqlQuery = SqlQuery + " and Especie = @Especie ";
                }

                if (!string.IsNullOrEmpty(value.Particularidades))
                {
                    parameters.Add(new DBParameter("Particularidades", DbType.String, value.Particularidades));
                    SqlQuery = SqlQuery + " and Particularidades = @Particularidades ";
                }
            }

            return new DBConnection().GetList<Flor>(SqlQuery, parameters);
        }

        public Flor Get(Flor value)
        {
            return GetAll(value).FirstOrDefault();
        }

        public bool Set(Flor value)
        {
            bool saved = false;

            if (value != null)
            {
                string SqlQuery = string.Empty;
                DBParameterCollection parameters = new DBParameterCollection();
                parameters.Add(new DBParameter("Especie", DbType.String, value.Especie));
                parameters.Add(new DBParameter("Particularidades", DbType.String, value.Particularidades));
                parameters.Add(new DBParameter("Naturalidade", DbType.String, value.Naturalidade));
                parameters.Add(new DBParameter("Caracteristicas", DbType.String, value.Caracteristicas));
                parameters.Add(new DBParameter("TamanhoPlanta", DbType.Decimal, value.TamanhoPlanta));
                parameters.Add(new DBParameter("TamanhoFlor", DbType.Decimal, value.TamanhoFlor));
                parameters.Add(new DBParameter("Cor", DbType.String, value.Cor));
                parameters.Add(new DBParameter("Hasteal", DbType.Int32, value.Hasteal));
                parameters.Add(new DBParameter("Perfume", DbType.Boolean, value.Perfume));
                parameters.Add(new DBParameter("DuracaoFloracao", DbType.Int32, value.DuracaoFloracao));
                parameters.Add(new DBParameter("Cultivo", DbType.String, value.Cultivo));

                if (value.DiaFloracao.HasValue)
                {
                    parameters.Add(new DBParameter("DiaFloracao", DbType.DateTime, value.DiaFloracao.Value));
                }
                else
                {
                    parameters.Add(new DBParameter("DiaFloracao", DbType.DateTime, null));
                }
                
                parameters.Add(new DBParameter("QuantidadeFlores", DbType.Int32, value.QuantidadeFlores));
                parameters.Add(new DBParameter("QuantidadeHastes", DbType.Int32, value.QuantidadeHastes));

                if (value.TrocaSubstrato.HasValue)
                {
                    parameters.Add(new DBParameter("TrocaSubstrato", DbType.DateTime, value.TrocaSubstrato.Value));
                }
                else
                {
                    parameters.Add(new DBParameter("TrocaSubstrato", DbType.DateTime, null));
                }
                
                parameters.Add(new DBParameter("IdFlorGenero", DbType.Int32, value.IdFlorGenero));
                parameters.Add(new DBParameter("IdFlorSubstrato", DbType.Int32, value.IdFlorSubstrato));
                parameters.Add(new DBParameter("IdFlorFertilizante", DbType.Int32, value.IdFlorFertilizante));
                parameters.Add(new DBParameter("IdFlorUmidade", DbType.Int32, value.IdFlorUmidade));
                parameters.Add(new DBParameter("IdFlorLuminosidade", DbType.Int32, value.IdFlorLuminosidade));
                parameters.Add(new DBParameter("IdFlorFloracao", DbType.Int32, value.IdFlorFloracao));
                parameters.Add(new DBParameter("IdFlorCrescimento", DbType.Int32, value.IdFlorCrescimento));
                parameters.Add(new DBParameter("IdFlorOrigem", DbType.Int32, value.IdFlorOrigem));
                parameters.Add(new DBParameter("IdFlorTipo", DbType.Int32, value.IdFlorTipo));
                parameters.Add(new DBParameter("IdFlorHabitat", DbType.Int32, value.IdFlorHabitat));
                parameters.Add(new DBParameter("IdFlorAdubacao", DbType.Int32, value.IdFlorAdubacao));
                parameters.Add(new DBParameter("IdFlorFornecedor", DbType.Int32, value.IdFlorFornecedor));

                if (value.IdFlor > 0)
                {
                    SqlQuery = " update Flor set ";
                    SqlQuery = SqlQuery + " Especie = @Especie, ";
                    SqlQuery = SqlQuery + " Particularidades = @Particularidades, ";
                    SqlQuery = SqlQuery + " Naturalidade = @Naturalidade, ";
                    SqlQuery = SqlQuery + " Caracteristicas = @Caracteristicas, ";
                    SqlQuery = SqlQuery + " TamanhoPlanta = @TamanhoPlanta, ";
                    SqlQuery = SqlQuery + " TamanhoFlor = @TamanhoFlor, ";
                    SqlQuery = SqlQuery + " Cor = @Cor, ";
                    SqlQuery = SqlQuery + " Hasteal = @Hasteal, ";
                    SqlQuery = SqlQuery + " Perfume = @Perfume, ";
                    SqlQuery = SqlQuery + " DuracaoFloracao = @DuracaoFloracao, ";
                    SqlQuery = SqlQuery + " Cultivo = @Cultivo, ";
                    SqlQuery = SqlQuery + " DiaFloracao = @DiaFloracao, ";
                    SqlQuery = SqlQuery + " QuantidadeFlores = @QuantidadeFlores, ";
                    SqlQuery = SqlQuery + " QuantidadeHastes = @QuantidadeHastes, ";
                    SqlQuery = SqlQuery + " TrocaSubstrato = @TrocaSubstrato, ";
                    SqlQuery = SqlQuery + " IdFlorGenero = @IdFlorGenero, ";
                    SqlQuery = SqlQuery + " IdFlorSubstrato = @IdFlorSubstrato, ";
                    SqlQuery = SqlQuery + " IdFlorFertilizante = @IdFlorFertilizante, ";
                    SqlQuery = SqlQuery + " IdFlorUmidade = @IdFlorUmidade, ";
                    SqlQuery = SqlQuery + " IdFlorLuminosidade = @IdFlorLuminosidade, ";
                    SqlQuery = SqlQuery + " IdFlorFloracao = @IdFlorFloracao, ";
                    SqlQuery = SqlQuery + " IdFlorCrescimento = @IdFlorCrescimento, ";
                    SqlQuery = SqlQuery + " IdFlorOrigem = @IdFlorOrigem, ";
                    SqlQuery = SqlQuery + " IdFlorTipo = @IdFlorTipo, ";
                    SqlQuery = SqlQuery + " IdFlorHabitat = @IdFlorHabitat, ";
                    SqlQuery = SqlQuery + " IdFlorAdubacao = @IdFlorAdubacao, ";
                    SqlQuery = SqlQuery + " IdFlorFornecedor = @IdFlorFornecedor ";
                    SqlQuery = SqlQuery + " where IdFlor = @IdFlor";
                    parameters.Add(new DBParameter("IdFlor", DbType.Int32, value.IdFlor));
                }
                else
                {
                    SqlQuery = "insert into Flor(Especie, Particularidades, Naturalidade, Caracteristicas, TamanhoPlanta, TamanhoFlor, Cor, Hasteal, Perfume, DuracaoFloracao, Cultivo, ";
                    SqlQuery = SqlQuery + " DiaFloracao, QuantidadeFlores, QuantidadeHastes, TrocaSubstrato, IdFlorGenero, IdFlorSubstrato, IdFlorFertilizante, ";
                    SqlQuery = SqlQuery + " IdFlorUmidade, IdFlorLuminosidade, IdFlorFloracao, IdFlorCrescimento, IdFlorOrigem, IdFlorTipo, IdFlorHabitat, IdFlorAdubacao, IdFlorFornecedor) ";
                    SqlQuery = SqlQuery + " values(@Especie, @Particularidades, @Naturalidade, @Caracteristicas, @TamanhoPlanta, @TamanhoFlor, @Cor, @Hasteal, @Perfume, @DuracaoFloracao, @Cultivo, ";
                    SqlQuery = SqlQuery + " @DiaFloracao, @QuantidadeFlores, @QuantidadeHastes, @TrocaSubstrato, @IdFlorGenero, @IdFlorSubstrato, @IdFlorFertilizante, ";
                    SqlQuery = SqlQuery + " @IdFlorUmidade, @IdFlorLuminosidade, @IdFlorFloracao, @IdFlorCrescimento, @IdFlorOrigem, @IdFlorTipo, @IdFlorHabitat, @IdFlorAdubacao, @IdFlorFornecedor)";
                }

                int Id = value.IdFlor > 0 ? value.IdFlor : new DBConnection().Set(SqlQuery, parameters, true);

                if (Id > 0 && (value.Foto != null && value.Foto.Length > 0))
                {
                    FlorFoto foto = new FlorFoto()
                    {
                        IdFlor = Id,
                        IdFlorFoto = value.IdFlorFoto.HasValue ? value.IdFlorFoto.Value : 0,
                        Conteudo = value.Foto
                    };

                    new Fotos().Set(foto);
                }

                saved = Id > 0;
            }

            return saved;
        }

        public bool Delete(Flor value)
        {
            bool deleted = false;

            if (value != null)
            {
                if (value.IdFlorGenero > 0)
                {
                    string SqlQuery = "delete from Flor where IdFlor = @IdFlor";
                    DBParameterCollection parameters = new DBParameterCollection();
                    parameters.Add(new DBParameter("IdFlor", DbType.Int32, value.IdFlor));

                    deleted = new DBConnection().Set(SqlQuery, parameters);
                }
            }

            return deleted;
        }

        public bool Delete(int Id)
        {
            return Delete(new Flor(Id));
        }
    }
}
