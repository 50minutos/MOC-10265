using System;
using System.Data.Objects;

namespace _002_ObterDadosUsandoEntitySql
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var e = new AdventureWorksEntities())
            {
                //http://msdn.microsoft.com/pt-br/library/vstudio/bb387145.aspx
                
                const String cmd = "SELECT VALUE C FROM AdventureWorksEntities.Contatos AS C WHERE C.ContactID <= 15";

                var contatos = new ObjectQuery<Contato>(cmd, e);

                foreach (var contato in contatos)
                {
                    Console.WriteLine(contato.Nome);
                }
            }

            Console.ReadKey();
        }
    }
}
