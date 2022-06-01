using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Alumno : Persona, IAlumnos
    {
        public int Nota { get; set; }

        public Alumno(int cedula, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, int nota) : base(cedula, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido)
        {
            this.Nota = nota;
        }

        public int NotaCurso()
        {
           return Nota * 2;

        }
    }
}
