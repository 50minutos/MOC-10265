using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Diagnostics;
using System.Linq;
using System.Text;
using _001_AW;

namespace _003_CompiledLinqQuery
{
    class Program
    {
        private readonly static Func<AdventureWorksEntities, IQueryable<Contato>> Query =
            CompiledQuery.Compile<AdventureWorksEntities, IQueryable<Contato>>(e => from c in e.Contatos select c);

        static void Main(string[] args)
        {
            using (var e = new AdventureWorksEntities())
            {
                var s = new Stopwatch();

                s.Start();

                var contatos = Query(e);

                foreach (var contato in contatos)
                {
                    contato.Nome = contato.Nome;
                }

                Console.WriteLine(s.ElapsedMilliseconds);
            }
        }
    }
}
