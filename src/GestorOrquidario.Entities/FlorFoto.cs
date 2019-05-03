using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorFoto
    {
        [ColumnMapping(Source = "IdFlorFoto", PrimaryKey = true)]
        public Int32 IdFlorFoto { get; set; }
        [ColumnMapping(Source = "IdFlor")]
        public Int32 IdFlor { get; set; }
        [ColumnMapping(Source = "Conteudo")]
        public byte[] Conteudo { get; set; }

        public FlorFoto()
        {

        }

        public FlorFoto(int IdFlorFoto)
        {
            this.IdFlorFoto = IdFlorFoto;
        }
    }
}
