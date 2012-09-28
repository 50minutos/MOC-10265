using System;
using System.Linq;

namespace _012_Where
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = 
            { 
                new Pessoa() { codigo = 1, nome = "Adao", sexo='M' }, 
                new Pessoa() { codigo = 2, nome = "Eva", sexo='F' },
                new Pessoa() { codigo = 3, nome = "Caim", sexo='M' }, 
                new Pessoa() { codigo = 4, nome = "Abel", sexo='M' } 
            };

            var homens = pessoas
                .Where(pessoa => pessoa.sexo == 'M');

            ObjectDumper.Write(homens);

            Console.WriteLine();

            var mulheres = from p in pessoas
                           where p.sexo == 'F'
                           select p;

            ObjectDumper.Write(mulheres);

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public int codigo;
        public String nome;
        public char sexo;
    }
}
