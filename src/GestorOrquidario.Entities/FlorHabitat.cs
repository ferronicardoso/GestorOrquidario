using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorHabitat
    {
        [ColumnMapping(Source = "IdFlorHabitat", PrimaryKey = true)]
        public Int32 IdFlorHabitat { get; set; }
        [ColumnMapping(Source = "Descricao")]
        public string Descricao { get; set; }

        public FlorHabitat()
        {

        }

        public FlorHabitat(int IdFlorHabitat)
        {
            this.IdFlorHabitat = IdFlorHabitat;
        }
    }
}
