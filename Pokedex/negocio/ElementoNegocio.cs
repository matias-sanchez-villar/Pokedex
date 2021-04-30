using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> Listar()
        {
            List<Elemento> Lista = new List<Elemento>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select ID, Descripcion from Elementos");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Lista.Add (new Elemento((string)datos.Lector["Descripcion"], (int)datos.Lector["ID"]));
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConsulta();
            }
        }

    }
}
