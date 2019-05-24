using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeAtv
{
    class GerenciadorProduto
    {
        private Dictionary<string, ProdutoPrototype> _produto = new Dictionary<string, ProdutoPrototype>();

        //Indexador
        public ProdutoPrototype this[string key]
        {
            get { return _produto[key]; }
            set { _produto.Add(key, value); }

        }
    }
}
