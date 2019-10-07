using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProductoNegocio
    {

        public bool Modificar(Producto Prod)
        {

            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearQuery("update[Productos] set[Titulo] = @Titulo,[Descripcion] = @Descripcion,[URLImagen] = @URL where ID = @ID");



                Datos.AgregarParametro("@ID", Prod.ID.ToString());
                Datos.AgregarParametro("@Titulo", Prod.Titulo);
                Datos.AgregarParametro("@Descripcion", Prod.Descripcion);
                Datos.AgregarParametro("@URL", Prod.URLImagen);
               
                Datos.Ejecucion_Accion();

                return true;


            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

       
              public List<Producto> Listar()
        {
            List<Producto> Lista = new List<Producto>();

            AccesoDatos Datos = new AccesoDatos();

            Producto Aux;

            try
            {
                Datos.SetearQuery("SELECT a.Id, a.titulo, a.Descripcion,a.URLImagen FROM[TP_WEB].dbo.Productos as a");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Aux = new Producto();
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Descripcion = Datos.Lector.GetString(1);
                    Aux.Titulo = Datos.Lector.GetString(2);
                    Aux.URLImagen = Datos.Lector.GetString(3);
                    Lista.Add(Aux);
                }
                return Lista;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                Datos.CerrarConexion();

            }
        }
    }
}
