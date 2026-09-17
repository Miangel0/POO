using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Models
{
    class SuperHeroe : Heroe
    {
        private string _Nombre;
        public int Id;
        public override string Nombre
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

        public override string SalvarElMundo()
        {
            return $"{NombreIdentidadSecreta} ha salvado el mundo";
        }

        public override string SalvarLaTierra()
        {
           // return base.SalvarLaTierra();
           return $"{NombreIdentidadSecreta} ha salvado la tierra";
        }
    }
}
