﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pokemon
    {
        public int ID { get; set; }
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string URLImagen { get; set; }
        public FichaTecnica Ficha { get; set; }
        public Elemento Tipo { get; set; }
        public Elemento Debilidad { get; set; }
        public Pokemon Evolucion { get; set; }

    }
}
