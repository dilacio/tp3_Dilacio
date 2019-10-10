using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Dominio;

namespace Negocio
{
    public class ClienteNegocio
    {
        public Cliente Busco_Cliente_DNI(int DNI)
        {
            Cliente Cli = new Cliente();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearQuery("SELECT [Nombre],[Apellido],[Email],[Direccion],[Ciudad],[CodigoPostal],[FechaRegistro]FROM [TP_WEB].[dbo].[Clientes]  where [DNI] = " + DNI);

                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                   
                    Cli.Nombre = Datos.Lector.GetString(0);
                    Cli.Apellido = Datos.Lector.GetString(1);
                    Cli.Mail = Datos.Lector.GetString(2);
                    Cli.Direccion = Datos.Lector.GetString(3);
                    Cli.Ciudad = Datos.Lector.GetString(4);
                    Cli.CodigoPostal = Datos.Lector.GetString(5);
                    Cli.FechaRegistro = Datos.Lector.GetDateTime(6);
                    return Cli;
                }
            }
            catch (Exception)
            {


            }
            finally
            {
                Datos.CerrarConexion();
            }
            return null;
        }

        public bool GuardarCliente(Cliente Cli)
        {
            AccesoDatos Datos = new AccesoDatos();
            bool Resultado = false;

            try
            {
                Datos.SetearQuery(" INSERT INTO [dbo].[Clientes] ([DNI],[Nombre],[Apellido],[Email],[Direccion],[Ciudad],[CodigoPostal],[FechaRegistro]) VALUES ("+Cli.DNI+","+Cli.Nombre+","+Cli.Apellido+","+Cli.Mail+","+Cli.Direccion + ","+ Cli.Ciudad+","+Cli.CodigoPostal+","+Cli.FechaRegistro+")");
                Datos.Ejecucion_Accion();

                Resultado = true;
                return Resultado;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            return Resultado;
        }
    }
}
