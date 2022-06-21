using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Persona
    {
      
        public int Cedula { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        protected Persona(int cedula, string primer_nombre, 
            string segundo_nombre, string primer_apellido, 
            string segundo_apellido)
        {
            this.Cedula = cedula;
            this.PrimerNombre = primer_nombre;
            this.SegundoNombre = segundo_nombre;
            this.PrimerApellido = primer_apellido;
            this.SegundoApellido = segundo_apellido;

            
        }

    }
}
