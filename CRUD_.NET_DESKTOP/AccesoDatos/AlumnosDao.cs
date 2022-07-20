using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
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
                    command.CommandText = "SELECT * FROM alumno AS A INNER JOIN persona AS P " +
                        " ON P.id_persona = A.id_persona";
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
                        command.CommandText = "SELECT * FROM alumno AS A INNER JOIN persona AS P " +
                            " ON P.id_persona = A.id_persona WHERE P.primer_nombre LIKE @nombre";
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



        public int GetIdAlumnoByCedula(int cedula)
        {
            int id_obtenido = 0;
            try
            {
                using (var connection = GetMySqlConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM alumno AS A INNER JOIN persona AS P " +
                            " ON P.id_persona = A.id_persona WHERE P.cedula = @cedula";
                        command.Parameters.AddWithValue("@cedula", cedula);
                        command.CommandType = CommandType.Text;
                        MySqlDataReader reader = command.ExecuteReader();
                        DataSet ds = new DataSet();
                        id_obtenido = Convert.ToInt32(ds.Tables[0].Columns["id"]);
                    }

                }

            }
            catch (Exception e)
            {
                throw e;
            }

            return id_obtenido;
        }

        public DataSet GetAlumnoByCedula(int cedula)
        {
            DataSet ds = new DataSet();
            try
            {
                using (var connection = GetMySqlConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM alumno AS A INNER JOIN persona AS P " +
                            " ON P.id_persona = A.id_persona WHERE P.cedula = @cedula";
                        command.Parameters.AddWithValue("@cedula", cedula);
                        command.CommandType = CommandType.Text;
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return ds;
        }

        public bool AgregarAlumno(int id_persona, int nota)
        {
            bool ingresado = false;
            try
            {
                using (var connection = GetMySqlConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO alumno ( id_persona, nota_final ) VALUES ( @id_persona, @nota )";
                        command.Parameters.AddWithValue("@id_persona", id_persona);
                        command.Parameters.AddWithValue("@nota", nota);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        ingresado = true;
                    }
                }

            }
            catch (Exception e)
            {
                throw e;
            }

            return ingresado;
        }

    }
}
