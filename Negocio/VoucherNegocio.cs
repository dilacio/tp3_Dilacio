using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class VoucherNegocio
    {
        public bool Verifica_Existencia(string Codigo)
        {
            int Count = 0;
            AccesoDatos Datos;
            Datos = new AccesoDatos();

            try
            {
                Datos.SetearQuery("SELECT ID FROM[TP_WEB].[dbo].[Vouchers] where[CodigoVoucher] = @Codigo and Estado = 0");
                Datos.AgregarParametro("@Codigo", Codigo);
                Datos.EjecutarLector();
                while (Datos.Lector.Read())
                {
                    Count++;
                }
                if (Count > 0 )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Operacion_exitosa()
        {
            
        }
    }
}
