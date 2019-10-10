using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP3_Dilacio
{
    public partial class ErrorDNI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btn_VolverAlta(object sender, EventArgs e)
        {
            Response.Redirect("IngresoDatos.aspx");
        }
    }
}