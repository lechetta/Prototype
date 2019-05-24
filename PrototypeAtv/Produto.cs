using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeAtv
{
    class Produto : ProdutoPrototype
    {
        private int _CodigoBarras;
        private string _nome;
        private double _preco;


        public Produto(int CodigoBarras, string nome, double preco)
        {
            this._CodigoBarras = CodigoBarras;
            this._nome = nome;
            this._preco = preco;
        }



        public override ProdutoPrototype clonar()
        {
            return this.MemberwiseClone() as ProdutoPrototype;

        }

        public int CodigoBarra
        {
            get { return this._CodigoBarras; }
            set {_CodigoBarras = value; }
        }
        public string nome
        {
            get { return this._nome; }
            set { _nome = value; }
        }
        public double preco
        {
            get { return this._preco; }
            set { _preco = value; }
        }


    }
}
