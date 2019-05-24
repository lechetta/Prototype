using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeAtv
{
    class servico : ProdutoPrototype
    {
        private int _Codigos;
        private string _nome;
        private double _preco;
        private double _valorTotal;
        private int _qtd;


        public servico(int Codigo, string nome, double preco, int qtd)
        {
            this._Codigos = Codigo;
            this._nome = nome;
            this._preco = preco;
            this._qtd = qtd;
            this._valorTotal = qtd * preco;
        }



        public override ProdutoPrototype clonar()
        {
            return this.MemberwiseClone() as ProdutoPrototype;

        }

        public int Codigo
        {
            get { return this._Codigos; }
            set { _Codigos = value; }
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
        public int qtd
        {
            get { return this._qtd; }
            set { _qtd = value; }
        }
        public double valor_total
        {
            get { return this._valorTotal; }
            set { _valorTotal = value; }
        }
    }
}
