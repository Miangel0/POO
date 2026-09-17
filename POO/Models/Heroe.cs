using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Models
{
    internal abstract class Heroe
    {
        public abstract string Nombre { get; set; }

        public abstract string SalvarElMundo();

        public virtual string SalvarLaTierra()
        {
            return $"{Nombre} ha salvado la tierra"; 
        }
    }
}
