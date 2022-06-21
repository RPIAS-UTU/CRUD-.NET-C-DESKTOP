using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public abstract class Conexion
    {
        protected static MySqlConnection GetMySqlConnection()
        {
            return new MySqlConnection("SERVER=localhost; DATABASE=pruebas_2021; UID=root; PASSWORD=;");
        }
    }
}
