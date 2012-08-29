using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _014_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = new Pessoa[]
            {
                new Pessoa(){nome="Agnaldo"}, //0
                new Pessoa(){nome="Zé"}, //1
                new Pessoa(){nome="Chico"}, //2
                new Pessoa(){nome="Tião"} //3
            };

            var pessoasComIndice = pessoas
                .Select((p, i) => new { i, p.nome })
                .OrderBy(p => p.nome);

            //var pessoasComIndice = pessoas
            //    .OrderBy(pessoa => pessoa.nome)
            //    .Select((pessoa, index) => new { index, pessoa.nome });

            ObjectDumper.Write(pessoasComIndice);

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public String nome;
    }
}