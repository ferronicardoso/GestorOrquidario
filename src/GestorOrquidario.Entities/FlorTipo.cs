using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorTipo
    {
        [ColumnMapping(Source = "IdFlorTipo", PrimaryKey = true)]
        public Int32 IdFlorTipo { get; set; }
        [ColumnMapping(Source = "Descricao")]
        public string Descricao { get; set; }

        public FlorTipo()
        {

        }

        public FlorTipo(int IdFlorTipo)
        {
            this.IdFlorTipo = IdFlorTipo;
        }
    }
}
