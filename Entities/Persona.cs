using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public string Estado { get; set; }
        public string Maneja { get; set; }
        public string UsaLentes { get; set; }
        public string Diabetico { get; set; }
        public string Enfermedad { get; set; }
    }
}
