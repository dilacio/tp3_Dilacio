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
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VoucherNegocio Voucher = new VoucherNegocio();

            try
            {
                if (Voucher.Verifica_Existencia(txbIngresoVoucher.Text))
                {
                    Response.Redirect("EleccionPremio.aspx");
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public void Btn_Siguiente(object sender, EventArgs e)
        {
            VoucherNegocio Voucher = new VoucherNegocio();
            try
            {
                if (Voucher.Verifica_Existencia(txbIngresoVoucher.Text))
                {
                    
                    Response.Redirect("EleccionPremio.aspx");
                }
                else
                {
                    Response.Redirect("ErrorVoucher.aspx");
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

    }


}