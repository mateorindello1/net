using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAcademia.FormularioPlan
{
    public partial class EditarForm : Form
    {
        private Plan planEditar;
        public EditarForm(Plan plan)
        {
            InitializeComponent();
            this.planEditar = plan;
            txtDescripcion.Text = plan.Descripcion;
            txtID.Text = plan.IdPlan.ToString();
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                return false; // Al menos uno de los campos está vacío o en blanco.
            }


            return true; // Todos los campos son válidos.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                planEditar.Descripcion = txtDescripcion.Text;
                planEditar.IdEspecialidad = Convert.ToInt32(txtEspecialidad.Text);
                this.Close();

            }
            else
            {
                MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
