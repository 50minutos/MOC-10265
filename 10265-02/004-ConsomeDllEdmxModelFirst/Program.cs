using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;
using _003_DllEdmxModelFirst;

namespace _004_ConsomeDllEdmxModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa
            {
                Id = 1,
                Nome = "Agnaldo",
                Telefones = new EntityCollection<Telefone> 
                { 
                    new Telefone { Id = 1, 
                        Numero = "11 98765-4321", 
                        PessoaId = 1 }, 
                    new Telefone { Id = 2, 
                        Numero = "11 91234-5678", 
                        PessoaId = 1 } 
                }
            };

            Console.WriteLine("Código: {0}", p.Id);
            Console.WriteLine("Nome: {0}", p.Nome);
            Console.WriteLine("Telefones:");

            foreach (var item in p.Telefones)
            {
                Console.WriteLine("   {0}\t{1}", item.Id, item.Numero);
            }

            Console.WriteLine();

            foreach (var pessoa in new AdventureWorksContainer().Pessoas.Where(x => x.Id == 1))
            {
                Console.WriteLine("{0} -> {1}", pessoa.Id, pessoa.Nome);

                foreach (var telefone in pessoa.Telefones)
                {
                    Console.WriteLine("\t{0} -> {1}", telefone.Id, telefone.Numero);
                }
            }

            Console.ReadKey();
        }
    }
}
