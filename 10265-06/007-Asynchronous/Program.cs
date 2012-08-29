using System;
using System.ComponentModel;
using _001_AW;

namespace _007_Asynchronous
{
    class Program
    {
        static void Main(string[] args)
        {
            var bw = new BackgroundWorker
                {
                    WorkerSupportsCancellation = false,
                    WorkerReportsProgress = false
                };

            bw.DoWork += BwDoWork;
            bw.RunWorkerCompleted += BwRunWorkerCompleted;

            Console.WriteLine("antes");

            bw.RunWorkerAsync();

            Console.WriteLine("depois");

            Console.ReadKey();
        }

        static void BwDoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("BwDoWork INI");

            using (var awe = new AdventureWorksEntities())
            {
                var c = new Contato()
                {
                    Nome = "Adão",
                    Sobrenome = "da Silva",
                    PasswordHash = "abc",
                    PasswordSalt = "xyz",
                    rowguid = Guid.NewGuid(),
                    ModifiedDate = DateTime.Now
                };

                awe.Contatos.AddObject(c);

                awe.SaveChanges();

                e.Result = c.ContactID;
            }

            Console.WriteLine("BwDoWork FIM");
        }

        static void BwRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("BwRunWorker INI");
            if (e.Error == null)
            {
                Console.WriteLine("Inseri o contato: {0}", e.Result);
            }
            else
            {
                Console.WriteLine(e.Error.Message);
            }

            Console.WriteLine("BwRunWorker FIM");
        }
    }
}
