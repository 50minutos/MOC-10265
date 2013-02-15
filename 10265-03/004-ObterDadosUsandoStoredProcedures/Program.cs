using System;
using System.Linq;

namespace _004_ObterDadosUsandoStoredProcedures
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var e = new AdventureWorksEntities())
            {
                var funcionarios = e.ObterSubordinados(185).ToList();

                var primeiro = funcionarios.First();

                Console.WriteLine(String.Format("{0} {1} {2}", 
                              primeiro.ManagerID, primeiro.ManagerFirstName, primeiro.ManagerLastName));

                foreach (var item in funcionarios)
                {
                    Console.WriteLine("   {0}\t{1} {2}", item.EmployeeID, item.FirstName, item.LastName);
                }
            }

            Console.ReadKey();
        }
    }
}
