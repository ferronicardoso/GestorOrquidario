using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorUf
    {
        [ColumnMapping(Source = "IdFlorUf", PrimaryKey = true)]
        public Int32 IdFlorUf { get; set; }
        [ColumnMapping(Source = "Sigla")]
        public string Sigla { get; set; }

        public FlorUf()
        {

        }

        public FlorUf(int IdFlorUf)
        {
            this.IdFlorUf = IdFlorUf;
        }
    }
}
