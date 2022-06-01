using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Alumno : Persona, IAlumnos
    {
        public int NotaFinal { get; set; }

        public Alumno(int cedula, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido) : base(cedula, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido)
        {
        }

        public int NotaCurso(List<int> notas)
        {
            int salida = 0;

            foreach (var nota in notas)
            {
                salida += nota;

            }
            salida = (int) salida / notas.Count;
            return salida;

        }
    }
}
