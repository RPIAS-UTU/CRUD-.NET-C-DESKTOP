﻿using Modelo;
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
            Director d = new Director(1897475, "Juan", "Manuel", "Perez", "Britos",25444.44, 2.5 );
            MessageBox.Show("El Sueldo de este director es de : " + d.CalcularSueldo().ToString());
        }
    }
}
