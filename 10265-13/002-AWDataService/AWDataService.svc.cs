using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Data.Services;
using System.Data.Services.Common;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

using AW;

namespace _002_AWDataService
{
    public class AWDataService : DataService<AdventureWorksEntities>
    {
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;

            config.SetEntitySetAccessRule("*", EntitySetRights.All);

            config.SetServiceOperationAccessRule("GetContato", ServiceOperationRights.ReadSingle);
            config.SetServiceOperationAccessRule("GetPedidosDoContato", ServiceOperationRights.ReadMultiple);
        }

        protected override void HandleException(HandleExceptionArgs args)
        {
            base.HandleException(args);

            Debug.Print("{0} {1} -> {2} {3}",
                DateTime.Now.ToShortDateString(),
                DateTime.Now.ToShortTimeString(),
                args.Exception.GetType().Name,
                args.Exception.Message);
        }

        [WebGet]
        [SingleResult]
        public Contato GetContato(int id)
        {
            return CurrentDataSource.Contatos.FirstOrDefault(c => c.ContactID == id);
        }

        [WebGet]
        public EntityCollection<Pedido> GetPedidosDoContato(int id)
        {
            var contato = CurrentDataSource.Contatos.FirstOrDefault(c => c.ContactID == id);

            return contato != null ? contato.Pedidos : null;
        }
    }
}
