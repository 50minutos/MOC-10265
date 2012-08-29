using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Linq;
using System.Text;
using _001_AW;
namespace _002_Consome001AW
{
    class Program
    {
        static void Main(String[] args)
        {
            using (var e = new AdventureWorksEntities())
            {
                foreach (var c in e.Contatos.Take(5))
                {
                    Console.WriteLine("{0} -> {1}", c.Nome, c.ValidarSenha("abc"));
                }
            }

            Console.ReadKey();
        }
    }
}
