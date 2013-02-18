using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _008_DropDownListGridView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var awe = new AdventureWorksEntities())
                {
                    var contatos = awe.Contacts.Take(10).Select(c => new { c.ContactID, c.FirstName });

                    Contatos.DataSource = contatos.ToList();
  
                    Contatos.DataTextField = "FirstName";
                    Contatos.DataValueField = "ContactID";

                    Contatos.DataBind();
             
                    AtualizarGrid();
                }
            }
        }

        protected void Contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            using (var awe = new AdventureWorksEntities())
            {
                var id = Convert.ToInt32(Contatos.SelectedValue);

                var pedidos = awe.Contacts
                    .FirstOrDefault(c => c.ContactID == id)
                    .SalesOrderHeaders
                    .Select(p => new { p.OrderDate, p.SubTotal });

                Pedidos.DataSource = pedidos.ToList();
                Pedidos.DataBind();
            }
        }
    }
}