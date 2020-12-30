using System;

namespace Construtore_15_12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            //  Utilizando o construtor vazio
            Produto produto1 = new Produto();
            
            produto1.Codigo = 1;
            produto1.Nome= "Coca-Cola";
            produto1.Descricao="Refrigerante Coca-Cola";
            produto1.Estoque= 30;
            
            Console.WriteLine($"Produto 1 Código {produto1.Codigo}, Nome {produto1.Nome}, Descrição {produto1.Descricao}, Estoque {produto1.Estoque}");
        }
    }
}
