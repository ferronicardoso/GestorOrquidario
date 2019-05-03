using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorSubstrato
    {
        [ColumnMapping(Source = "IdFlorSubstrato", PrimaryKey = true)]
        public Int32 IdFlorSubstrato { get; set; }
        [ColumnMapping(Source = "Descricao")]
        public string Descricao { get; set; }

        public FlorSubstrato()
        {

        }

        public FlorSubstrato(int IdFlorSubstrato)
        {
            this.IdFlorSubstrato = IdFlorSubstrato;
        }
    }
}
