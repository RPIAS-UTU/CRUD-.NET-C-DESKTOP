using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Director : Persona, IFuncionarios
    {

        public double SueldoBase { get; set; }
        public double AñosAntiguedad { get; set; }

        public Director(
            int cedula, 
            string primer_nombre, 
            string segundo_nombre, 
            string primer_apellido, 
            string segundo_apellido,
            double sueldo_base,
            double antiguedad) : base(cedula, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido)
        {
            this.SueldoBase = sueldo_base;
            this.AñosAntiguedad = antiguedad;
        }

        public double CalcularSueldo()
        {
            return SueldoBase * AñosAntiguedad;
        }
    }
}
