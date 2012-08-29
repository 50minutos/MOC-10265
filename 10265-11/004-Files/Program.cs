using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Files;

namespace _004_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("uso do aplicativo:");
                Console.WriteLine("\t_004_Files enderecoPasta1 enderecoPasta2");
                Console.ReadKey();
            }
            else
            {
                var pasta1 = args[0];
                var pasta2 = args[1];

                var filtro = new FileSyncScopeFilter();

                filtro.FileNameExcludes.Add("*.abc");
                filtro.FileNameExcludes.Add("*.xyz");

                GravarMetadados(pasta1, filtro);
                GravarMetadados(pasta2, filtro);

                Sincronizar(pasta1, pasta2, null);
                Sincronizar(pasta2, pasta1, null);

                Console.ReadKey();
            }
        }

        public static void Sincronizar(string pastaOrigem, 
            string pastaDestino,
            FileSyncScopeFilter filtro)
        {
            FileSyncProvider providerOrigem = null;
            FileSyncProvider providerDestino = null;

            try
            {
                const FileSyncOptions opcoes = FileSyncOptions.ExplicitDetectChanges |
                               FileSyncOptions.RecycleDeletedFiles |
                               FileSyncOptions.RecyclePreviousFileOnUpdates |
                               FileSyncOptions.RecycleConflictLoserFiles;

                providerOrigem = new FileSyncProvider(pastaOrigem, filtro, opcoes);

                providerDestino = new FileSyncProvider(pastaDestino, filtro, opcoes);

                providerDestino.AppliedChange += OnAppliedChange;
                providerDestino.SkippedChange += OnSkippedChange;

                var agent = new SyncOrchestrator
                {
                    LocalProvider = providerOrigem,
                    RemoteProvider = providerDestino,
                    Direction = SyncDirectionOrder.Upload
                };

                Console.WriteLine("Sincronizando: {0}", providerDestino.RootDirectoryPath);

                agent.Synchronize();
            }
            finally
            {
                if (providerOrigem != null) providerOrigem.Dispose();
                if (providerDestino != null) providerDestino.Dispose();
            }
        }

        private static void OnSkippedChange(object sender, SkippedChangeEventArgs e)
        {
            Console.WriteLine("-> aplicação de {0} para {1} deu erro", e.ChangeType, !String.IsNullOrEmpty(e.CurrentFilePath) ? e.CurrentFilePath : e.NewFilePath);
        }

        private static void OnAppliedChange(object sender, AppliedChangeEventArgs e)
        {
            var msg = String.Empty;

            switch (e.ChangeType)
            {
                case ChangeType.Create:
                    msg = String.Format("CREATE {0}", e.NewFilePath);
                    break;
                case ChangeType.Delete:
                    msg = String.Format("DELETE {0}", e.OldFilePath);
                    break;
                case ChangeType.Update:
                    msg = String.Format("UPDATE (overwrite) {0}", e.OldFilePath);
                    break;
                case ChangeType.Rename:
                    msg = String.Format("RENAME de {0} para {1}", e.OldFilePath, e.NewFilePath);
                    break;
            }

            Console.WriteLine(msg);
        }

        public static void GravarMetadados(string pasta, FileSyncScopeFilter filtro)
        {
            FileSyncProvider provider = null;
            
            const FileSyncOptions opcoes = FileSyncOptions.ExplicitDetectChanges |
                                           FileSyncOptions.RecycleDeletedFiles |
                                           FileSyncOptions.RecyclePreviousFileOnUpdates |
                                           FileSyncOptions.RecycleConflictLoserFiles;

            try
            {
                provider = new FileSyncProvider(pasta, filtro, opcoes);
                provider.DetectChanges();
            }
            finally
            {
                if (provider != null) provider.Dispose();
            }
        }
    }
}
