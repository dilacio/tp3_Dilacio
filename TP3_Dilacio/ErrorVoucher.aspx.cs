using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP3_Dilacio
{
    public partial class ErrorVoucher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Boton_Siguiente(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("Index.aspx");
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }

}