using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vista
{
    public static class Utiles
    {

        public static int DevolverEntero(string entrada) 
        { 
            int salida = 0;
        // https://docs.microsoft.com/es-es/dotnet/standard/base-types/regular-expression-language-quick-reference
            try
            {
                string pattern = @"\b[,.-]\b"; // busca letras minusculas y mayusculas
                entrada = entrada.Trim(); // quito los espacios en blanco
                entrada = Regex.Replace(entrada, pattern, string.Empty);
                salida = int.Parse(entrada);

            }
            catch (Exception)
            { 
            
            }
                       
            return salida;
        
        }

        public static string DevolverFechaFormateada(string entrada)
        {
            string salida = "";
            // https://docs.microsoft.com/es-es/dotnet/standard/base-types/regular-expression-language-quick-reference
            try
            {
                string pattern = @"\b[/]\b"; // busca letras minusculas y mayusculas
                entrada = entrada.Trim(); // quito los espacios en blanco
                entrada = Regex.Replace(entrada, pattern, string.Empty);

                //12062022
                //string dia = entrada.Substring(0, 2);
                //string mes = entrada.Substring(2, 2);
                //string anio = entrada.Substring(4, 4);
                //entrada = dia + mes + anio;

                salida = entrada.Substring(4, 4) + entrada.Substring(2, 2) + entrada.Substring(0,2);

            }
            catch (Exception)
            {

            }

            return salida;

        }


    }
}
