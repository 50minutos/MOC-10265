using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

//referenciar System.Data.Linq

namespace _022_LinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=True");

            dc.Log = Console.Out;

            //Table<Pessoa> pessoas = dc.GetTable<Pessoa>();

            var pessoas = from p in dc.GetTable<Pessoa>()
                          select p;

            //ObjectDumper.Write(pessoas);

            //Console.WriteLine();

            var nomes = from p in pessoas
                        select p.Nome;

            nomes = from p in nomes
                    where p.Equals("ABEL")
                    select p;

            ObjectDumper.Write(nomes);

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

/*
CREATE TABLE PESSOA 
(
	COD_PESSOA INT PRIMARY KEY, 
	NOME_PESSOA VARCHAR(50), 
	SEXO_PESSOA CHAR(1)
)

INSERT INTO PESSOA
VALUES (1, 'ADÃO', 'M'),
	(2, 'EVA', 'F'),
	(3, 'CAIM', 'M'),
	(4, 'ABEL', 'M')
*/