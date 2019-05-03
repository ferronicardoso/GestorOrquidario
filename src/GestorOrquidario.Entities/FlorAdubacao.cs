using GestorOrquidario.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestorOrquidario.Entities
{
    public class FlorAdubacao
    {
        [ColumnMapping(Source = "IdFlorAdubacao", PrimaryKey = true)]
        public Int32 IdFlorAdubacao { get; set; }
        [ColumnMapping(Source = "Descricao")]
        public string Descricao { get; set; }

        public FlorAdubacao()
        {

        }

        public FlorAdubacao(int IdFlorAdubacao)
        {
            this.IdFlorAdubacao = IdFlorAdubacao;
        }
    }
}
