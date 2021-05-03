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
        private AccesoDatos datos;
        public List<Pokemon> Listar()
        {
            List < Pokemon > Lista = new List<Pokemon>();
            datos = new AccesoDatos();

            try
             {
                datos.SetearConsulta("select P.ID IDPokemon, Numero, Nombre, p.Descripcion, UrlImagen, T.ID IDTipo, T.Descripcion Tipo, D.ID IDDebilidad, D.Descripcion Debilidad from Pokemons P, Elementos T, Elementos D where p.IdTipo = t.ID and D.ID = P.IdDebilidad");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.ID = (int) datos.Lector["IDPokemon"];
                    aux.Numero = (int)datos.Lector["Numero"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.URLImagen = (string)datos.Lector["UrlImagen"];
                    aux.Tipo = new Elemento((string)datos.Lector["Tipo"]);
                    aux.Tipo.ID = (int)datos.Lector["IDTipo"];
                    aux.Debilidad = new Elemento((string)datos.Lector["Debilidad"]);
                    aux.Debilidad.ID = (int)datos.Lector["IDDebilidad"];

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
                datos.CerrarConsulta();
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

        public void Modificar(Pokemon Modificar)
        {
            datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update Pokemons set Numero= @Numero, Nombre = @Nombre, Descripcion = @Descripcion, UrlImagen = @UrlImagen, IdTipo = @Tipo, IdDebilidad = @Debilidad where ID = @ID");

                datos.setearParametro("@ID", Modificar.ID);
                datos.setearParametro("@Numero", Modificar.Numero);
                datos.setearParametro("@Nombre", Modificar.Nombre);
                datos.setearParametro("@Descripcion", Modificar.Descripcion);
                datos.setearParametro("@UrlImagen", Modificar.URLImagen);
                datos.setearParametro("@Tipo", Modificar.Tipo.ID);
                datos.setearParametro("@Debilidad", Modificar.Debilidad.ID);

                datos.EjecutarAccion();
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

        public void Eliminar(int ID)
        {
            datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Delete From POKEMONS Where Id = " + ID);

                datos.EjecutarAccion();
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
