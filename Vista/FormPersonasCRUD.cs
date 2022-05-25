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
using System.Web;

namespace Vista
{
    public partial class FormPersonasCRUD : Form
    {
        public List<Departamento> departamentos { get; set; }
        public FormPersonasCRUD()
        {
            InitializeComponent();
        }

        private void FormPersonasCRUD_Load(object sender, EventArgs e)
        {
            CargarComboDepartamentos();
        }

        private void CargarComboDepartamentos() {

            

        }
    }
}
