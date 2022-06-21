using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAlumno : Form
    {
        public FrmAlumno()
        {
            InitializeComponent();
        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_alumnos.DataSource = AlumnoController.ObtenerAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Alumnos :: " + ex.Message);
            }

          
        }
    }
}
