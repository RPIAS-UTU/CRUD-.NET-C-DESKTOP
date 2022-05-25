using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Autenticacion_Seguridad
{
    public class Usuario
    {
        public string? Password { get; set; }
        public string[]? Telefonos { get; set; }
        public Usuario(int id, string? email, string? password, string nombre, string apellido, string[]? telefonos)
        {
            Password = password;
        }
    }
}
