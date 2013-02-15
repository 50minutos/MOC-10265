using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_CustomizarEdmx
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto
            {
                Id = 1,
                Nome = "martelo"
            };

            var produtoPerecivel = new Perecivel
            {
                Id = 2, 
                Nome = "maçã", 
                Vencimento = DateTime.Now.AddDays(2)
            };

            Console.WriteLine(produto);
            Console.WriteLine(produtoPerecivel);

            Console.ReadKey();
        }
    }
}
