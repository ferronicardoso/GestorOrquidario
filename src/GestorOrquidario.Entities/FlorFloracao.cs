using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorFloracao
    {
        [ColumnMapping(Source = "IdFlorFloracao", PrimaryKey = true)]
        public Int32 IdFlorFloracao { get; set; }
        [ColumnMapping(Source = "Descricao")]
        public string Descricao { get; set; }

        public FlorFloracao()
        {

        }

        public FlorFloracao(int IdFlorFloracao)
        {
            this.IdFlorFloracao = IdFlorFloracao;
        }
    }
}
