using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009_GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livro> livros = new List<Livro>() 
            {
                new Livro(){titulo = "SQL é fácil"}, 
                new Livro(){titulo = "Acesso a dados com C#"}, 
                new Livro(){titulo = "LINQ sem mistério"}, 
                new Livro(){titulo = "LINQ to SQL"}, 
                new Livro(){titulo = "ABC do Truco"}
            };

            var livrosDeLINQ = livros
                                .Where(livro => livro.titulo.Contains("LINQ"));

            ObjectDumper.Write(livrosDeLINQ);

            Console.ReadKey();
        }
    }

    class Livro
    {
        public string titulo;
    }
}