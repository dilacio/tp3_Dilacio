using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TP3_Dilacio
{
    public partial class EleccionPremio : System.Web.UI.Page
    {
        public List<Producto> ListaProductos { get; set; }
        public Producto producto = new Producto();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ProductoNegocio Negocio = new ProductoNegocio();
                ListaProductos = Negocio.Listar();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}