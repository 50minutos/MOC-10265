using System;
using System.Data.SqlClient;

namespace _001_xxxConnectionStringBuilder
{
    class Program
    {
        static void Main()
        {
            var scsb = new SqlConnectionStringBuilder
            {
                DataSource = @".\SQLEXPRESS",
                InitialCatalog = "AdventureWorks",
                IntegratedSecurity = true
            };

            //scsb.IntegratedSecurity = true;
            //ou
            //csb.UserID = "usuarioDoBanco";
            //csb.Password = "senhaDoUsuarioDoBanco";

            Console.WriteLine(scsb.ToString());

            Console.ReadKey();
        }
    }
}
