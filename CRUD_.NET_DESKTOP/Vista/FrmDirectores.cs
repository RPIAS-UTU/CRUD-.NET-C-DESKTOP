using Modelo;
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
    // partial class: esta clase forma parte de otras clases llamadas de la misma forma
    // y bajo el mismo namespace.
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods?source=docs
    public partial class frmDirectores : Form
    {

        private static frmDirectores instancia = null;

        private List<Director> lista = new List<Director>();

        public static frmDirectores InstaciaUnica() {

            if (instancia == null) { 
                instancia = new frmDirectores();
            }
            return instancia;
        }

        public frmDirectores()
        {
            InitializeComponent();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarEntradaNumerica(txtCedula.Text, e.KeyChar, '-'))
                e.Handled = true;

        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // https://www.delftstack.com/es/howto/csharp/how-to-make-a-textbox-that-only-accepts-numbers-in-csharp/#:~:text=Puedes%20simplemente%20arrastrar%20y%20soltar,textbook%20que%20s%C3%B3lo%20acepte%20n%C3%BAmeros%20.
            // https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof?view=net-6.0#system-string-indexof(system-char)
            // https://docs.microsoft.com/en-us/dotnet/api/system.char.iscontrol?view=net-6.0#code-try-1

            // !char.IsControl : ejemplo de caracter de control '\n' 
            // !char.IsDigit : verdadero si (e.KeyChar) es un dígito decimal; en caso contrario, falso.

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solamente permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                MessageBox.Show("'" + e.KeyChar.ToString() + "' " + " Es un caracter NO numérico ");
            else if ((e.KeyChar == '.'))
                MessageBox.Show("'" + e.KeyChar.ToString() + "' " + " Es un caracter NO numérico PERMITIDO ");

        }

        private void mtxtCedula_KeyPress(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Solo números");
        }

        private void btnObtenerCedula_Click(object sender, EventArgs e)
        {
            string str_cedula = mtxtCedula.Text;
            int cedula = Utiles.DevolverEntero(str_cedula);

            MessageBox.Show("Cedula obtenida: " + str_cedula + " - Cédula en formato numérico: " + cedula);

        }

        private void btnObtenerFecha_Click(object sender, EventArgs e)
        {
            string str_fecha = mtxtFecha.Text;

            MessageBox.Show("Fecha obtenida: " +
                str_fecha + " - Fecha en formato válido: " +
                Utiles.DevolverFechaFormateada(str_fecha));
        }

        private void btnCrearDirector_Click(object sender, EventArgs e)
        {
            Director dire = new Director(1897475, "Juan", "Manuel", "Perez", "Britos", 25444.44, 2.5);
            MessageBox.Show("El Sueldo de este director es de : " + dire.CalcularSueldo().ToString());

            Profesor profe = new Profesor(38978547, "Maria", "Alicia", "Rodríguez", "Pereyra", 22, 55.2);
            MessageBox.Show("El Sueldo de esta Profesora es de : " + profe.CalcularSueldo().ToString());
        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {

            var notas = new List<int> { 10, 9, 8, 6, 11, 12, 12, 12, 12 };

            Alumno a = new Alumno(38978547, "Maria", "Alicia", "Rodríguez", "Pereyra");
            a.NotaFinal = a.NotaCurso(notas);

            MessageBox.Show("La Nota de este alumno es : " + a.NotaFinal);
        }

        private void btn_cargar_a_grilla_Click(object sender, EventArgs e)
        {

            dgv_datos.Columns.Add("cedula", "Cédula");

            dgv_datos.Columns.Add("n1", "Primer Nombre");
            dgv_datos.Columns.Add("n2", "Segundo Nombre");
            dgv_datos.Columns.Add("a1", "Primer Apellido");
            dgv_datos.Columns.Add("a2", "Segundo Apellido");

            dgv_datos.Columns[1].Width = 140;
            dgv_datos.Columns[2].Width = 140;
            dgv_datos.Columns[3].Width = 140;
            dgv_datos.Columns[4].Width = 140;

            int n = dgv_datos.Rows.Add();

            dgv_datos.Rows[n].Cells[0].Value = txtCedula.Text;
            dgv_datos.Rows[n].Cells[1].Value = txtPrimerNombre.Text;
            dgv_datos.Rows[n].Cells[2].Value = txtSegundoNombre.Text;
            dgv_datos.Rows[n].Cells[3].Value = txtPrimerApellido.Text;
            dgv_datos.Rows[n].Cells[4].Value = txtSegundoApellido.Text;

            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtCedula.Clear();
            txtPrimerNombre.Clear();
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Clear();
        }

        private void btn_cargar_grilla_Click(object sender, EventArgs e)
        {
           
            Director d = new Director(
               Convert.ToInt32(txtCedula.Text),
               txtPrimerNombre.Text,
               txtSegundoNombre.Text,
               txtPrimerApellido.Text,
               txtSegundoApellido.Text,
               32000,
               12
               );
            lista.Add(d);
            dgv_datos.DataSource = null;
            dgv_datos.DataSource = lista;
            
            LimpiarFormulario();
        }

        // cuando se esta cerrando
        private void frmDirectores_FormClosing(object sender, FormClosingEventArgs e)
        {
            // evitar error de show() al cerrar ventana
            instancia = null;
        }

     
    }
}
