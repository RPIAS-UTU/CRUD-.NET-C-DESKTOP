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
                DataTable dt = new DataTable();

                DataColumn col_cedula = new DataColumn();
                col_cedula.DataType = System.Type.GetType("System.Int32");
                col_cedula.ColumnName = "Cédula";
                dt.Columns.Add(col_cedula);

                DataColumn col_primer_nombre = new DataColumn();
                col_primer_nombre.DataType = System.Type.GetType("System.String");
                col_primer_nombre.ColumnName = "Primer Nombre";
                dt.Columns.Add(col_primer_nombre);

                DataColumn col_primer_apellido = new DataColumn();
                col_primer_apellido.DataType = System.Type.GetType("System.String");
                col_primer_apellido.ColumnName = "Primer Apellido";
                dt.Columns.Add(col_primer_apellido);


                DataColumn col_nota = new DataColumn();
                col_nota.DataType = System.Type.GetType("System.Int32");
                col_nota.ColumnName = "Nota Final";
                dt.Columns.Add(col_nota);

                foreach (DataRow dr in AlumnosDao.GetAllAlumnos().Rows)
                {
                    DataRow row;
                    row = dt.NewRow();
                    row["Cédula"] = dr["cedula"];
                    row["Primer Nombre"] = dr["primer_nombre"];
                    row["Primer Apellido"] = dr["primer_apellido"];
                    row["Nota Final"] = dr["nota_final"];
                    dt.Rows.Add(row);
                }

                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }
          

        }
    }
}
