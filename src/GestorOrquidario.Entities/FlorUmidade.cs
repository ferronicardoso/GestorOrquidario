using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorUmidade
    {
        [ColumnMapping(Source = "IdFlorUmidade", PrimaryKey = true)]
        public Int32 IdFlorUmidade { get; set; }
        [ColumnMapping(Source = "Descricao")]
        public string Descricao { get; set; }

        public FlorUmidade()
        {

        }

        public FlorUmidade(int IdFlorUmidade)
        {
            this.IdFlorUmidade = IdFlorUmidade;
        }
    }
}
