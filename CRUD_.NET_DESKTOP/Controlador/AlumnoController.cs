using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;

namespace Controlador
{
    public class AlumnoController
    {

        public static DataTable ObtenerAlumnos()
        {
            try
            {
                return AlumnosDao.GetAllAlumnos();
            }
            catch (Exception e)
            {

                throw e;
            }
          

        }
    }
}
