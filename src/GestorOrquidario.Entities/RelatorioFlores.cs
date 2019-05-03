using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class RelatorioFlores
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

        [ColumnMapping(Source = "Adubacao")]
        public string Adubacao { get; set; }
        [ColumnMapping(Source = "Crescimento")]
        public string Crescimento { get; set; }
        [ColumnMapping(Source = "Fertilizante")]
        public string Fertilizante { get; set; }
        [ColumnMapping(Source = "Floracao")]
        public string Floracao { get; set; }
        [ColumnMapping(Source = "Genero")]
        public string Genero { get; set; }
        [ColumnMapping(Source = "Habitat")]
        public string Habitat { get; set; }
        [ColumnMapping(Source = "Luminosidade")]
        public string Luminosidade { get; set; }
        [ColumnMapping(Source = "Origem")]
        public string Origem { get; set; }
        [ColumnMapping(Source = "Substrato")]
        public string Substrato { get; set; }
        [ColumnMapping(Source = "Tipo")]
        public string Tipo { get; set; }
        [ColumnMapping(Source = "Umidade")]
        public string Umidade { get; set; }
        [ColumnMapping(Source = "Fornecedor")]
        public string Fornecedor { get; set; }
        [ColumnMapping(Source = "Foto")]
        public byte[] Foto { get; set; }
    }
}
