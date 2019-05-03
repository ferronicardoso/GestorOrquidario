using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorFertilizante
    {
        [ColumnMapping(Source = "IdFlorFertilizante", PrimaryKey = true)]
        public Int32 IdFlorFertilizante { get; set; }
        [ColumnMapping(Source = "Descricao")]
        public string Descricao { get; set; }

        public FlorFertilizante()
        {

        }

        public FlorFertilizante(int IdFlorFertilizante)
        {
            this.IdFlorFertilizante = IdFlorFertilizante;
        }
    }
}
