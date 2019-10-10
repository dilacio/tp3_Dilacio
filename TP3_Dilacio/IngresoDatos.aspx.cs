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
    public partial class IngresoDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ID;
            txbDNI.Attributes.Add("onkeypress", "return ValidNum(event);");
            
            ID = Request.QueryString["ValorProducto"].ToString(); 

        }
        protected void Valido_IngredoDNI()
        {
            if(txbDNI.Text == "")
            {
                Response.Redirect("ErrorDNI.aspx");
            }
        }
        protected void Btn_BuscaDNI(object sender, EventArgs e )
        {
       
            ClienteNegocio CliNeg = new ClienteNegocio();
            Cliente Cli = new Cliente();
            Cli = null;

            try
            {
                Cli = CliNeg.Busco_Cliente_DNI(Convert.ToInt32(txbDNI.Text));

                if (Cli != null)
                {
                    txbDireccion.Text = Cli.Direccion;
                    TxbApellido.Text = Cli.Apellido;
                    txbNombre.Text = Cli.Nombre;
                    txbCiudad.Text = Cli.Ciudad;
                    txbCP.Text = Cli.CodigoPostal;
                    txbEmail.Text = Cli.Mail;
                   
                }
                else
                {
                    txbDireccion.Text = "";
                    TxbApellido.Text = "";
                    txbNombre.Text = "";
                    txbCiudad.Text = "";
                    txbCP.Text = "";
                    txbEmail.Text = "";
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        protected void Participar (object sender, EventArgs e)
        {
            Cliente Cli = new Cliente();
            ClienteNegocio Neg = new ClienteNegocio();
            bool Ban_Termino = false;

            Cli = null;

            Cli = Neg.Busco_Cliente_DNI(Convert.ToInt32(txbDNI.Text));

            if(checkTerminos.Checked == true)
            {
                if( Cli.ID == null)
                {
                    Cli.Apellido = TxbApellido.Text;
                    Cli.Ciudad = txbCiudad.Text;
                    Cli.CodigoPostal = txbCP.Text;
                    Cli.Direccion = txbDireccion.Text;
                    Cli.DNI = Convert.ToInt32(txbDNI.Text);
                    Cli.FechaRegistro = DateTime.Today;
                    Cli.Mail = txbEmail.Text;
                    Cli.Nombre = txbNombre.Text;

                    if (Neg.GuardarCliente(Cli))
                    {
                        Response.Redirect("OperacionExitosa.aspx");
                    }
                }
                else
                {
                    VoucherNegocio VouNeg = new VoucherNegocio();

                    Response.Redirect("OperacionExitosa.aspx");


                }
            }
            else
            {

            }
        }
    }
}