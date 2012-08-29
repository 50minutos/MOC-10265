using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace _023_Update
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=True");

            dc.Log = Console.Out;

            var pessoas = from p in dc.GetTable<Pessoa>()
                          select p;

            ObjectDumper.Write(pessoas);

            Console.WriteLine();

            foreach (Pessoa p in pessoas)
            {
                p.Nome += "*";
            }

            dc.SubmitChanges();

            ObjectDumper.Write(dc.GetTable<Pessoa>());

            Console.ReadKey();
        }
    }

    [Table(Name = "PESSOA")]
    class Pessoa
    {
        [Column(Name = "COD_PESSOA", IsPrimaryKey = true)]
        public int Codigo { get; set; }

        [Column(Name = "NOME_PESSOA")]
        public String Nome { get; set; }

        [Column(Name = "SEXO_PESSOA")]
        public char Sexo { get; set; }
    }
}