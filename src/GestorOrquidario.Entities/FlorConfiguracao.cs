using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorConfiguracao
    {
        [ColumnMapping(Source = "IdFlorConfiguracao", PrimaryKey = true)]
        public int IdFlorConfiguracao { get; set; }
        [ColumnMapping(Source = "Background")]
        public byte[] Background { get; set; }

        public FlorConfiguracao()
        {

        }

        public FlorConfiguracao(int IdFlorConfiguracao)
        {
            this.IdFlorConfiguracao = IdFlorConfiguracao;
        }
    }
}
