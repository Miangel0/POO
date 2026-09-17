using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Models
{
    class SuperHeroe
    {
        private string _Nombre;
        public int Id;
        public string Nombre 
        {
            get
            {
                return _Nombre; 
            }
            set
            {
                _Nombre = value.Trim();
            } 
        }
        public string NombreIdentidadSecreta
        {
            get
            {
                return $"{Nombre} ({IdentidadSecreta})";
            }
        }
        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var poder in SuperPoderes)
            {
                sb.AppendLine($"el superheroe {NombreIdentidadSecreta} esta usando el superpoder: {poder.Nombre} - {poder.Descripcion} - Nivel: {poder.Nivel}");
            }

            return sb.ToString();
        }
    }
}
