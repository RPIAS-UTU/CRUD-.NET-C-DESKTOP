using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Profesor : Persona, IFuncionarios 
    {
        public double CantidadHorasMensuales { get; set; }
        public double PrecioHora { get; set; }
        public Profesor(
            int cedula,
            string primer_nombre,
            string segundo_nombre,
            string primer_apellido,
            string segundo_apellido,
            double cantidad_horas,
            double precio_hora) : base(cedula, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido)
        {
            this.CantidadHorasMensuales = cantidad_horas;
            this.PrecioHora = precio_hora;
        }

        double IFuncionarios.CalcularSueldo()
        {
            return CantidadHorasMensuales * PrecioHora;
        }
    }
}
