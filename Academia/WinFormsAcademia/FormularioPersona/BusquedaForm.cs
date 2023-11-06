using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAcademia.FormularioPersona
{
    public partial class BusquedaForm : Form
    {
        public String id { get; set; }
        public BusquedaForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            id = this.tbId.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
