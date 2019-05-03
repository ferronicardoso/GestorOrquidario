using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorMeusDados
    {
        [ColumnMapping(Source = "IdFlorMeusDados", PrimaryKey = true)]
        public Int32 IdFlorMeusDados { get; set; }
        [ColumnMapping(Source = "Nome")]
        public string Nome { get; set; }
        [ColumnMapping(Source = "Endereco")]
        public string Endereco { get; set; }
        [ColumnMapping(Source = "Complemento")]
        public string Complemento { get; set; }
        [ColumnMapping(Source = "Bairro")]
        public string Bairro { get; set; }
        [ColumnMapping(Source = "Cidade")]
        public string Cidade { get; set; }
        [ColumnMapping(Source = "Telefone")]
        public string Telefone { get; set; }
        [ColumnMapping(Source = "Celular")]
        public string Celular { get; set; }
        [ColumnMapping(Source = "Cep")]
        public string Cep { get; set; }
        [ColumnMapping(Source = "Email")]
        public string Email { get; set; }
        [ColumnMapping(Source = "Site")]
        public string Site { get; set; }
        [ColumnMapping(Source = "MSN")]
        public string MSN { get; set; }
        [ColumnMapping(Source = "Skype")]
        public string Skype { get; set; }
        [ColumnMapping(Source = "Imagem")]
        public byte[] Imagem { get; set; }
        [ColumnMapping(Source = "IdFlorUf")]
        public int IdFlorUf { get; set; }

        public FlorMeusDados()
        {

        }

        public FlorMeusDados(int IdFlorMeusDados)
        {
            this.IdFlorMeusDados = IdFlorMeusDados;
        }
    }
}
