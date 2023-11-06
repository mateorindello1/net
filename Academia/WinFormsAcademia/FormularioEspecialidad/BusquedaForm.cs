using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAcademia.FormularioEspecialidad
{
    public partial class BusquedaForm : Form
    {
        public String id { get; set; }
        public BusquedaForm()
        {
            InitializeComponent();
        }

        private void BusquedaForm_Load(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            id = this.tbId.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
