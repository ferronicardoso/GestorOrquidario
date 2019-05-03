using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorGenero
    {
        [ColumnMapping(Source = "IdFlorGenero", PrimaryKey = true)]
        public Int32 IdFlorGenero { get; set; }
        [ColumnMapping(Source = "Descricao")]
        public string Descricao { get; set; }

        public FlorGenero()
        {

        }

        public FlorGenero(int IdFlorGenero)
        {
            this.IdFlorGenero = IdFlorGenero;
        }
    }
}
