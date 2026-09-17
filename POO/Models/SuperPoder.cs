using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Models
{
    class SuperPoder
    {
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;

        public SuperPoder()
        {
            Nivel = NivelPoder.NivelUno;
        }
    }
}
