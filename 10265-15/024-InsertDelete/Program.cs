using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace _024_InsertDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=True");

            //dc.Log = Console.Out;

            Pessoa pessoa = new Pessoa() { CodigoPessoa = 5, NomePessoa = "Cobra", SexoPessoa = 'F' };

            dc.GetTable<Pessoa>().InsertOnSubmit(pessoa);
            dc.SubmitChanges();

            ObjectDumper.Write(dc.GetTable<Pessoa>());

            Console.WriteLine();

            dc.GetTable<Pessoa>().DeleteOnSubmit(pessoa);
            dc.SubmitChanges();

            ObjectDumper.Write(dc.GetTable<Pessoa>());

            Console.ReadKey();
        }
    }

    [Table(Name = "PESSOA")]
    class Pessoa
    {
        [Column(Name = "COD_PESSOA", IsPrimaryKey = true)]
        public int CodigoPessoa { get; set; }

        [Column(Name = "NOME_PESSOA")]
        public String NomePessoa { get; set; }

        [Column(Name = "SEXO_PESSOA")]
        public char SexoPessoa { get; set; }
    }
}