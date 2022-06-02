using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Listas
    {

        public static void CargarMostrarLista() {

            // https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/concepts/collections#BKMK_SimpleCollection
            // Crear una lista de strings.
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            // Iterar la lista.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }



        }

    }
}
