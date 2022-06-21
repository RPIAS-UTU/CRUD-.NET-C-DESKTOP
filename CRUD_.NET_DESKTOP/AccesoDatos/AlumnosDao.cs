using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class AlumnosDao : Conexion
    {

        public static DataTable GetAllAlumnos()
        {

            DataTable dt = new DataTable();

            using (var connection = GetMySqlConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM persona";
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);

                }


            }

            return dt;
        }


        public DataTable GetAllAlumnoByNombre(string nombre, string error)
        {

            DataTable dt = new DataTable();
            try
            {
                using (var connection = GetMySqlConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM persona WHERE nombre LIKE @nombre";
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.CommandType = CommandType.Text;
                        MySqlDataReader reader = command.ExecuteReader();
                        dt.Load(reader);
                    }

                }

            }
            catch (Exception e)
            {
                throw e;
            }

            return dt;
        }

    }
}
