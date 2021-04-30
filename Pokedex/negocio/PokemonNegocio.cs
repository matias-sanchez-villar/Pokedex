using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> Listar()
        {
            List < Pokemon > Lista = new List<Pokemon>();
            AccesoDatos Datos = new AccesoDatos();

            try
             {
                Datos.SetearConsulta("select Nombre, p.Descripcion, UrlImagen, T.Descripcion Tipo, D.Descripcion Debilidad from Pokemons P, Elementos T, Elementos D where p.IdTipo = t.ID and D.ID = P.IdDebilidad");
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Nombre = (string)Datos.Lector["Nombre"];
                    aux.Descripcion = (string)Datos.Lector["Descripcion"];
                    aux.URLImagen = (string)Datos.Lector["UrlImagen"];
                    aux.Tipo = new Elemento((string)Datos.Lector["Tipo"]);
                    aux.Debilidad = new Elemento((string)Datos.Lector["Debilidad"]);

                    Lista.Add(aux);
                }

                return Lista;
             }
             catch (Exception e)
             {
                throw e;
             }
            finally
            {
                Datos.CerrarConsulta();
            }

        }

        public void Agregar(Pokemon pokemon)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {

                string valores = "values(" + pokemon.Numero + ", '" + pokemon.Nombre + "', '" + pokemon.Descripcion + "', '" + pokemon.URLImagen + "', " + pokemon.Tipo.ID + ", " + pokemon.Debilidad.ID + ")";
                Datos.SetearConsulta("insert into Pokemons (Numero, Nombre, Descripcion, UrlImagen, IdTipo, IdDebilidad) " + valores);


                Datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Datos.CerrarConsulta();
            }
        }
    }
}
