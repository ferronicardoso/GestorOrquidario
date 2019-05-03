using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorCrescimento
    {
        [ColumnMapping(Source = "IdFlorCrescimento", PrimaryKey = true)]
        public Int32 IdFlorCrescimento { get; set; }
        [ColumnMapping(Source = "Descricao")]
        public string Descricao { get; set; }

        public FlorCrescimento()
        {

        }

        public FlorCrescimento(int IdFlorCrescimento)
        {
            this.IdFlorCrescimento = IdFlorCrescimento;
        }
    }    
}
