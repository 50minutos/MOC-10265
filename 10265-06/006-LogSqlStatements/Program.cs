using System;
using System.Data.Objects;
using System.Linq;
using _001_AW;

namespace _006_LogSqlStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var e = new AdventureWorksEntities())
            {
                #region 1
                var contatos = e.Contatos;

                Console.WriteLine(contatos.GetType());
                Console.WriteLine(contatos.ToTraceString());

                Console.WriteLine();
                #endregion

                #region 2
                var dezContatos = e.Contatos.Take(10);

                Console.WriteLine(dezContatos.GetType());
                Console.WriteLine(((ObjectQuery<Contato>)dezContatos).ToTraceString());

                Console.WriteLine();
                #endregion

                #region 3
                var contatosIniciadosPorA = e.Contatos.Where(c => c.Nome.StartsWith("A"));

                Console.WriteLine(contatosIniciadosPorA.GetType());
                Console.WriteLine(((ObjectQuery<Contato>)contatosIniciadosPorA).ToTraceString());

                Console.WriteLine();
                #endregion

                #region 4
                var contatosTerminadosPorA = e.Contatos.Where(c => c.Nome.EndsWith("A")).Select(c => c.Nome);

                Console.WriteLine(contatosTerminadosPorA.GetType());
                Console.WriteLine(((ObjectQuery<String>)contatosTerminadosPorA).ToTraceString());
                #endregion
            }

            Console.ReadKey();
        }
    }
}
