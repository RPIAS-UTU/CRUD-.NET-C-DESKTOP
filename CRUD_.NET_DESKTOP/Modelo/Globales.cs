using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Globales
    {
        public const int CANTIDAD_NOTAS = 9;

        private double[,] Notas = new double[3, 3];

        public double this[int row, int column]
        {
            // The embedded array will throw out of range exceptions as appropriate.
            get { return Notas[row, column]; }
            set { Notas[row, column] = value; }
        }

        public void CrearMostrarObjetos() {

            var pet = new { Age = 5, Name = "Lola"};
            _ = new { Age = 2, Name = "Pepito" };
            _ = new { Age = 3, Name = "Juancito" };



        }

        public void CrearMostrarObjetosConListas()
        {

            var pet = new { Age = 5, Name = "Lola" };
            _ = new { Age = 2, Name = "Pepito" };
            _ = new { Age = 3, Name = "Juancito" };



        }

    }
}
