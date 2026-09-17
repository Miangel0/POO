using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Models
{
    class AntiHeroe : SuperHeroe
    {
        public string AccionAntiHeroe(string accion)
        {
            return $"El antiheroe {NombreIdentidadSecreta} esta realizando la accion: {accion}"; 
        }
    }
}
