using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Pokemon
    {
        public int Numero { get; set; }
        public string  Nombre { get; set; }
        public string Descripcion { get; set; }
        public string URLimgaen { get; set; }
        public FichaTecnica Ficha { get; set; }
        public Elemento Tipo { get; set; }
        public Elemento Debilidad { get; set; }
        public Pokemon Evolucion { get; set; }
    }
}
