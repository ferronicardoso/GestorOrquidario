using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorOrigem
    {
        [ColumnMapping(Source = "IdFlorOrigem", PrimaryKey = true)]
        public Int32 IdFlorOrigem { get; set; }
        [ColumnMapping(Source = "Descricao")]
        public string Descricao { get; set; }

        public FlorOrigem()
        {

        }

        public FlorOrigem(int IdFlorOrigem)
        {
            this.IdFlorOrigem = IdFlorOrigem;
        }
    }
}
