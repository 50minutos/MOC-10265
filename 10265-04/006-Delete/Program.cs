using System;
using System.Linq;
using _001_AW;

namespace _006_Delete
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var e = new AdventureWorksEntities())
            {
                var c =
                    e.Contatos.FirstOrDefault(
                        x =>
                        x.Nome.Equals("Adão", /*APAGAR O ADÃO#@*/ StringComparison.InvariantCultureIgnoreCase) &&
                        x.Sobrenome.Equals("da Silva", StringComparison.InvariantCultureIgnoreCase));

                if (c == null) return;

                //e.DeleteObject(c);
                e.Contatos.DeleteObject(c);
                
                e.SaveChanges();

                Console.WriteLine(e.Contatos.FirstOrDefault(
                        x =>
                        x.Nome.Equals("Adão", /*VERIFICAR O ADÃO#@*/StringComparison.InvariantCultureIgnoreCase) &&
                        x.Sobrenome.Equals("da Silva", StringComparison.InvariantCultureIgnoreCase)) == null
                        );
            }

            Console.ReadKey();
        }
    }
}
