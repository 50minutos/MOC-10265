using System;
using System.Data.Objects;
using System.Diagnostics;
using _001_AW;

namespace _002_MergeOption
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMergeOption(MergeOption.AppendOnly);
            //MostrarMergeOption(MergeOption.PreserveChanges);
            //MostrarMergeOption(MergeOption.OverwriteChanges);
            //MostrarMergeOption(MergeOption.NoTracking);

            Console.ReadKey();
        }

        private static void MostrarMergeOption(MergeOption mo)
        {
            using (var e = new AdventureWorksEntities())
            {
                var s = new Stopwatch();

                s.Start();

                var contatos = new ObjectQuery<Contato>("SELECT VALUE C FROM AdventureWorksEntities.Contatos AS C", e, mo);

                foreach (var contato in contatos)
                {
                    contato.Nome = contato.Nome;
                }

                Console.WriteLine(s.ElapsedMilliseconds);
            }
        }
    }
}
