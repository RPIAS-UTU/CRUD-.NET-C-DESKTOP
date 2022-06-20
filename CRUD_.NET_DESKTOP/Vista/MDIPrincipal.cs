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
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void datosEmplaeadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDirectores frm_directores = frmDirectores.InstaciaUnica();
            frm_directores.MdiParent = this;
            // traer al frente
            frm_directores.BringToFront();
            // mostrar
            frm_directores.Show();

        }


        private bool FormIsOpen(String nombre_form) {
            bool retorno = false;
            foreach (var form_hijo in this.MdiChildren) {
                if (form_hijo.Text == nombre_form) {
                    // traer al frente
                    form_hijo.BringToFront();
                    retorno = true;
                }
            }
            return retorno;
        }

        private void datosAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormIsOpen("FrmAlumno") == false) {

                FrmAlumno frm_alu = new FrmAlumno();
                frm_alu.MdiParent = this;
                // traer al frente
                frm_alu.BringToFront();
                // mostrar
                frm_alu.Show();

            }

    
        }
    }
}
