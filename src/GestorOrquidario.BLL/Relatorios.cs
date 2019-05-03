using GestorOrquidario.DAL;
using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestorOrquidario.BLL
{
    public class Relatorios
    {
        DBParameterCollection parameters = null;

        public IEnumerable<RelatorioFlores> GetRelatorioFlores()
        {
            parameters = new DBParameterCollection();
            string SqlQuery = "select a.IdFlor, a.Especie, a.Particularidades, a.Naturalidade, a.Caracteristicas, ";
            SqlQuery = SqlQuery + "a.TamanhoPlanta, a.TamanhoFlor, a.Cor, a.Hasteal, a.Perfume, a.DuracaoFloracao, ";
            SqlQuery = SqlQuery + "a.Cultivo, a.DiaFloracao, a.QuantidadeFlores, a.QuantidadeHastes, a.TrocaSubstrato, ";
            SqlQuery = SqlQuery + "b.Descricao as Adubacao, c.Descricao as Crescimento, d.Descricao as Fertilizante, ";
            SqlQuery = SqlQuery + "e.Descricao as Floracao, f.Nome as Fornecedor, g.Conteudo as Foto, h.Descricao as Genero, ";
            SqlQuery = SqlQuery + "i.Descricao as Habitat, j.Descricao as Luminosidade, k.Descricao as Origem, ";
            SqlQuery = SqlQuery + "l.Descricao as Substrato, m.Descricao as Tipo, n.Descricao as Umidade ";
            SqlQuery = SqlQuery + "from Flor a ";
            SqlQuery = SqlQuery + "inner join FlorAdubacao     b on (b.IdFlorAdubacao     = a.IdFlorAdubacao    ) ";
            SqlQuery = SqlQuery + "inner join FlorCrescimento  c on (c.IdFlorCrescimento  = a.IdFlorCrescimento ) ";
            SqlQuery = SqlQuery + "inner join FlorFertilizante d on (d.IdFlorFertilizante = a.IdFlorFertilizante) ";
            SqlQuery = SqlQuery + "inner join FlorFloracao     e on (e.IdFlorFloracao     = a.IdFlorFloracao    ) ";
            SqlQuery = SqlQuery + "left join FlorFornecedor   f on (f.IdFlorFornecedor   = a.IdFlorFornecedor  ) ";
            SqlQuery = SqlQuery + "inner join FlorFoto         g on (g.IdFlor             = a.IdFlor            ) ";
            SqlQuery = SqlQuery + "inner join FlorGenero       h on (h.IdFlorGenero       = a.IdFlorGenero      ) ";
            SqlQuery = SqlQuery + "inner join FlorHabitat      i on (i.IdFlorHabitat      = a.IdFlorHabitat     ) ";
            SqlQuery = SqlQuery + "inner join FlorLuminosidade j on (j.IdFlorLuminosidade = a.IdFlorLuminosidade) ";
            SqlQuery = SqlQuery + "inner join FlorOrigem       k on (k.IdFlorOrigem       = a.IdFlorOrigem      ) ";
            SqlQuery = SqlQuery + "inner join FlorSubstrato    l on (l.IdFlorSubstrato    = a.IdFlorSubstrato   ) ";
            SqlQuery = SqlQuery + "inner join FlorTipo         m on (m.IdFlorTipo         = a.IdFlorTipo        ) ";
            SqlQuery = SqlQuery + "inner join FlorUmidade      n on (n.IdFlorUmidade      = a.IdFlorUmidade     ) ";

            return new DBConnection().GetList<RelatorioFlores>(SqlQuery, null);
        }
    }
}
