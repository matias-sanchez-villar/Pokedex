using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Elemento
    {
        public int ID { get; set; }
        public string  Nombre { get; set; }

        public Elemento(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public Elemento (string Nombre, int ID)
        {
            this.Nombre = Nombre;
            this.ID = ID;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
