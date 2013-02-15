using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Data.Services;
using System.Data.Services.Common;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using AW;

namespace _002_WCFDataService
{
    public class AWDataService : DataService<AdventureWorksEntities>
    {
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;

            //config.SetEntitySetAccessRule("Contatos", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);

            config.SetServiceOperationAccessRule("GetContato", ServiceOperationRights.ReadSingle);
            config.SetServiceOperationAccessRule("GetPedidosDoContato", ServiceOperationRights.ReadMultiple);

            //config.MaxExpandDepth = 1;
            //config.MaxExpandCount = 1;
            config.SetEntitySetPageSize("Contatos", 5);
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
/*
http://localhost:15047/AWDataService.svc 
http://localhost:15047/AWDataService.svc/Contatos(1)/  
http://localhost:15047/AWDataService.svc/Contatos(1)/Nome
http://localhost:15047/AWDataService.svc/Contatos(1)/Pedidos 
http://localhost:15047/AWDataService.svc/Contatos(1)/Pedidos(44132)/
http://localhost:15047/AWDataService.svc/Contatos(1)/Pedidos(44132)/TotalDue
http://localhost:15047/AWDataService.svc/Contatos(1)/Pedidos?$select=OrderDate,ShipDate,DueDate
http://localhost:15047/AWDataService.svc/Contatos(1)?$expand=Pedidos
http://localhost:15047/AWDataService.svc/$metadata
http://localhost:15047/AWDataService.svc/Contatos/$count
http://localhost:15047/AWDataService.svc/Contatos?$filter=ContactID%20le%2010&$select=Nome,Sobrenome
http://localhost:15047/AWDataService.svc/Contatos?$filter=ContactID%20le%2010&$select=Nome,Sobrenome&$orderby=Sobrenome,Nome
http://localhost:15047/AWDataService.svc/Contatos?$filter=ContactID%20le%2010%20and%20startswith(Sobrenome,%20'Ad')&$select=Nome,Sobrenome
http://localhost:15047/AWDataService.svc/Contatos?$filter=ContactID%20lt%2010%20and%20substringof('be',Sobrenome)
http://localhost:15047/AWDataService.svc/Contatos?$top=5 
http://localhost:15047/AWDataService.svc/Contatos?$skip=10&$top=10
http://localhost:15047/AWDataService.svc/Contatos?$skiptoken=5
http://localhost:15047/AWDataService.svc/GetContato?id=1
http://localhost:15047/AWDataService.svc/GetPedidosDoContato?id=1
*/