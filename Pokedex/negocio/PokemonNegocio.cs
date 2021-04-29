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
            SqlConnection Conexion = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Lector;

            try
             {
                Conexion.ConnectionString = "Data Source=DESKTOP-K54EB4U\\SQLEXPRESS; Initial Catalog=Pokedex; integrated security=true;";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "select Nombre, p.Descripcion, UrlImagen, T.Descripcion Tipo, D.Descripcion Debilidad from Pokemons P, Elementos T, Elementos D where p.IdTipo = t.ID and D.ID = P.IdDebilidad";
                Comando.Connection = Conexion;

                Conexion.Open();
                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Nombre = (string)Lector["Nombre"];
                    aux.Descripcion = (string)Lector["Descripcion"];
                    aux.URLImagen = (string)Lector["UrlImagen"];
                    aux.Tipo = new Elemento((string)Lector["Tipo"]);
                    aux.Debilidad = new Elemento((string)Lector["Debilidad"]);

                    Lista.Add(aux);
                }

                return Lista;
             }
             catch (Exception e)
             {
                throw e;
             }

        }
    }
}
