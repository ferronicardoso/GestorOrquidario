using GestorOrquidario.DAL;
using System;

namespace GestorOrquidario.Entities
{
    public class FlorFornecedor
    {
        [ColumnMapping(Source = "IdFlorFornecedor", PrimaryKey = true)]
        public Int32 IdFlorFornecedor { get; set; }
        [ColumnMapping(Source = "Nome")]
        public string Nome { get; set; }

        public FlorFornecedor()
        {

        }

        public FlorFornecedor(int IdFlorFornecedor)
        {
            this.IdFlorFornecedor = IdFlorFornecedor;
        }
    }
}
