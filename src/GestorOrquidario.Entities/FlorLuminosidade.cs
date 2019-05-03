using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorLuminosidade
    {
        [ColumnMapping(Source = "IdFlorLuminosidade", PrimaryKey = true)]
        public Int32 IdFlorLuminosidade { get; set; }
        [ColumnMapping(Source = "Descricao")]
        public string Descricao { get; set; }

        public FlorLuminosidade()
        {

        }

        public FlorLuminosidade(int IdFlorLuminosidade)
        {
            this.IdFlorLuminosidade = IdFlorLuminosidade;
        }
    }
}
