using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeAtv
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorProduto gerenciador = new GerenciadorProduto();

            //Inicializa o gerenciado com as cores padrão
            gerenciador["produto1"] = new Produto(452, "detergente", 5.00);
            gerenciador["produto2"] = new Produto(785, "esponja", 0.50);
            gerenciador["produto3"] = new Produto(999, "roçadeira", 150.00);

            //Adiciar cores personalizadas
            gerenciador["servico1"] = new servico(123, "limpeza", 100.00, 1);
            gerenciador["servico2"] = new servico(200, "jardinagem", 150.00, 2);

            //As cores são clonadas para novos objetos
            Produto prod1 = gerenciador["produto1"].clonar() as Produto;
            Produto prod2 = gerenciador["produto2"].clonar() as Produto;
            Produto prod3 = gerenciador["produto3"].clonar() as Produto;
            servico serv1 = gerenciador["servico1"].clonar() as servico;
            servico serv2 = gerenciador["servico2"].clonar() as servico;

            Console.WriteLine("produto1: ({0},{1},{2})", prod1.CodigoBarra, prod1.nome, prod1.preco);
            Console.WriteLine("produto1: ({0},{1},{2})", prod2.CodigoBarra, prod2.nome, prod2.preco);
            Console.WriteLine("produto1: ({0},{1},{2})", prod3.CodigoBarra, prod3.nome, prod3.preco);
            Console.WriteLine("servico1: ({0},{1},{2},{3},{4})", serv1.nome, serv1.preco, serv1.Codigo, serv1.qtd, serv1.valor_total);
            Console.WriteLine("servico2: ({0},{1},{2},{3},{4})", serv2.nome, serv2.preco, serv2.Codigo, serv2.qtd, serv2.valor_total);

            Console.ReadKey();

        }
    }
}
