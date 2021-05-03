using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection Conexion;
        private SqlCommand Comando;
        private SqlDataReader lector;

        public AccesoDatos()
        {
            Conexion = new SqlConnection("Data Source=DESKTOP-K54EB4U\\SQLEXPRESS; Initial Catalog=Pokedex; integrated security=true;");
            Comando = new SqlCommand();
        }

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public void SetearConsulta(string Consulta)
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = Consulta;
        }

        public void setearParametro(string nombre, object valor)
        {
            Comando.Parameters.AddWithValue(nombre, valor);
        }

        public void EjecutarLectura()
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            lector = Comando.ExecuteReader();
        }

        internal void EjecutarAccion()
        {
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.ExecuteNonQuery();
        }

        public void CerrarConsulta()
        {
            if (lector != null) lector.Close();

            Conexion.Close();
        }
    }
}
