using System;
using System.Data.Services.Client;
using System.Linq;
using _003_ConsomeWCFDataService.Proxy;

namespace _003_ConsomeWCFDataService
{
    class Program
    {
        static void Main(string[] args)
        {
            //MostrarConsultaUnicoObjeto();
            //MostrarConsultaNaoPaginada();
            //MostrarConsultaPaginada();
            //MostrarConsultaComFiltro();
            //MostrarConsultaOperacao();
            
            Console.ReadKey();
        }

        private static void MostrarConsultaOperacao()
        {
            var awe = new AdventureWorksEntities(new Uri("http://localhost:15047/AWDataService.svc"));

            awe.BeginExecute<Contato>(new Uri("/GetContato?id=1", UriKind.Relative), GetContatoCompleted, awe);
        }

        private static void GetContatoCompleted(IAsyncResult iar)
        {
            var awe = iar.AsyncState as AdventureWorksEntities;

            if (awe == null) return;

            var contatos = awe.EndExecute<Contato>(iar);

            if (contatos == null) return;
            
            foreach (var contato in contatos)
                Console.WriteLine("{0} -> {1}", contato.ContactID, contato.Nome);
        }

        private static void MostrarConsultaComFiltro()
        {
            var awe = new AdventureWorksEntities(new Uri("http://localhost:15047/AWDataService.svc"));

            var contatos = awe.Contatos.Where(c => c.ContactID >= 11 && c.ContactID <= 20);
            
            //var contatos = awe.Contatos
            //    .AddQueryOption("$filter", "ContactID ge 11 and ContactID le 20")
            //    .Select(c => new {c.ContactID, c.Nome});

            foreach (var contato in contatos)
                Console.WriteLine("{0} -> {1}", contato.ContactID, contato.Nome);
        }

        private static void MostrarConsultaPaginada()
        {
            var awe = new AdventureWorksEntities(new Uri("http://localhost:15047/AWDataService.svc"));

            DataServiceQueryContinuation<Contato> qc = null;

            var qor = awe.Contatos.Execute() as QueryOperationResponse<Contato>;

            do
            {
                Console.WriteLine("--------------------------------");
                
                if (qc != null) 
                    qor = awe.Execute(qc);

                if (qor != null)
                    foreach (var contato in qor)
                        Console.WriteLine("{0} -> {1}", contato.ContactID, contato.Nome);
            }
            while (qor != null && (qc = qor.GetContinuation()) != null);

        }

        private static void MostrarConsultaNaoPaginada()
        {
            var awe = new AdventureWorksEntities(new Uri("http://localhost:15047/AWDataService.svc"));

            foreach (var contato in awe.Contatos)
                Console.WriteLine("{0} -> {1}", contato.ContactID, contato.Nome);
        }

        private static void MostrarConsultaUnicoObjeto()
        {
            var awe = new AdventureWorksEntities(new Uri("http://localhost:15047/AWDataService.svc"));

            if (awe.Contatos == null) return;

            var contatos = awe.Contatos.Execute();

            if (contatos == null) return;
            
            var contato = contatos.FirstOrDefault(c => c.ContactID == 1);

            if (contato == null) return;
            
            Console.WriteLine("{0} -> {1}", contato.ContactID, contato.Nome);
        }
    }
}
