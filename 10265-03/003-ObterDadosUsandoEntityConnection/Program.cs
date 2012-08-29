using System;
using System.Data;
using System.Data.EntityClient;

namespace _003_ObterDadosUsandoEntityConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new EntityConnection("name=AdventureWorksEntities"))
            {
                c.StateChange += EStateChange;

                var cmd = "SELECT VALUE C FROM AdventureWorksEntities.Contatos AS C WHERE C.ContactID=@ContactID";

                using (var k = new EntityCommand(cmd, c))
                {
                    k.Parameters.AddWithValue("ContactID", 1);

                    c.Open();

                    var dr = k.ExecuteReader(CommandBehavior.SequentialAccess);

                    if (dr.Read()) //while se existir mais de um registro
                    {
                        Console.WriteLine(dr["Nome"]);
                    }

                    if (c.State != ConnectionState.Closed) c.Close();
                }
            }

            Console.ReadKey();
        }

        static void EStateChange(object sender, StateChangeEventArgs e)
        {
            Console.WriteLine("{0} -> {1}", e.OriginalState, e.CurrentState);
            ;
        }
    }
}
