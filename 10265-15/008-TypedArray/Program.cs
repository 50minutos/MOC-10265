using System;
using System.Linq;

namespace _008_TypedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = 
            {
                new Pessoa { codigo = 1, nome = "Adão" }, 
                new Pessoa{ codigo = 2, nome = "Eva" }, 
                new Pessoa{ codigo = 3, nome = "Caim" }, 
                new Pessoa{ codigo = 4, nome = "Abel" } 
            };

            var filhos = pessoas
                .Where(pessoa => pessoa.codigo > 2);

            ObjectDumper.Write(filhos);

            Console.WriteLine();

            var nomes = filhos
                .Select(pessoa => pessoa.nome);

            ObjectDumper.Write(nomes);

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public int codigo;
        public string nome;
    }
}
