using GestorOrquidario.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestorOrquidario.Entities
{
    public class Flor
    {
        [ColumnMapping(Source = "IdFlor", PrimaryKey = true)]
        public Int32 IdFlor { get; set; }
        [ColumnMapping(Source = "Especie")]
        public string Especie { get; set; }
        [ColumnMapping(Source = "Particularidades")]
        public string Particularidades { get; set; }
        [ColumnMapping(Source = "Naturalidade")]
        public string Naturalidade { get; set; }
        [ColumnMapping(Source = "Caracteristicas")]
        public string Caracteristicas { get; set; }
        [ColumnMapping(Source = "TamanhoPlanta")]
        public decimal? TamanhoPlanta { get; set; }
        [ColumnMapping(Source = "TamanhoFlor")]
        public decimal? TamanhoFlor { get; set; }
        [ColumnMapping(Source = "Cor")]
        public string Cor { get; set; }
        [ColumnMapping(Source = "Hasteal")]
        public Int32? Hasteal { get; set; }
        [ColumnMapping(Source = "Perfume")]
        public Boolean? Perfume { get; set; }
        [ColumnMapping(Source = "DuracaoFloracao")]
        public Int32? DuracaoFloracao { get; set; }
        [ColumnMapping(Source = "Cultivo")]
        public string Cultivo { get; set; }
        [ColumnMapping(Source = "DiaFloracao")]
        public DateTime? DiaFloracao { get; set; }
        [ColumnMapping(Source = "QuantidadeFlores")]
        public Int32? QuantidadeFlores { get; set; }
        [ColumnMapping(Source = "QuantidadeHastes")]
        public Int32? QuantidadeHastes { get; set; }
        [ColumnMapping(Source = "TrocaSubstrato")]
        public DateTime? TrocaSubstrato { get; set; }
        [ColumnMapping(Source = "IdFlorAdubacao")]
        public Int32 IdFlorAdubacao { get; set; }
        [ColumnMapping(Source = "IdFlorCrescimento")]
        public Int32 IdFlorCrescimento { get; set; }
        [ColumnMapping(Source = "IdFlorFertilizante")]
        public Int32 IdFlorFertilizante { get; set; }
        [ColumnMapping(Source = "IdFlorFloracao")]
        public Int32 IdFlorFloracao { get; set; }
        [ColumnMapping(Source = "IdFlorGenero")]
        public Int32 IdFlorGenero { get; set; }
        [ColumnMapping(Source = "IdFlorHabitat")]
        public Int32 IdFlorHabitat { get; set; }
        [ColumnMapping(Source = "IdFlorLuminosidade")]
        public Int32 IdFlorLuminosidade { get; set; }
        [ColumnMapping(Source = "IdFlorOrigem")]
        public Int32 IdFlorOrigem { get; set; }
        [ColumnMapping(Source = "IdFlorSubstrato")]
        public Int32 IdFlorSubstrato { get; set; }
        [ColumnMapping(Source = "IdFlorTipo")]
        public Int32 IdFlorTipo { get; set; }
        [ColumnMapping(Source = "IdFlorUmidade")]
        public Int32 IdFlorUmidade { get; set; }
        [ColumnMapping(Source = "IdFlorFornecedor")]
        public Int32? IdFlorFornecedor { get; set; }
        [ColumnMapping(Source = "Foto")]
        public byte[] Foto { get; set; }
        [ColumnMapping(Source = "IdFlorFoto")]
        public Int32? IdFlorFoto { get; set; }

        public Flor()
        {

        }

        public Flor(int IdFlor)
        {
            this.IdFlor = IdFlor;
        }
    }
}
