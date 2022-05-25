using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal abstract class Persona
    {
        public int Id { get; set; }
        public string? Email { get; set; } // Ester parámetros admitirá valores NULL
        public string Nombre { get; set; }

        private string apellido;

        public string GetApellido()
        {
            return apellido;
        }

        public void SetApellido(string value)
        {
            apellido = value;
        }

        public string[]? Telefonos { get; set; }

        public Persona(int id, string? email, string nombre, string apellido, string[]? telefonos)
        {
            Id = id;
            Email = email;
         
            // Con la introducción del operador coalesing (??) nulo en C# 8
            // y la excepción throw en C# 7, puede reducir el código anterior a una sola expresión:
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));

            // usaremos this.propiedad para atributos declarados como private
            // nameof es un operador que acompaño a C# a partir de su versión 6.
            // Este devuelve el nombre de una variable Por ejemplo: apellido
            this.apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            Telefonos = telefonos;
        }

    }
}
