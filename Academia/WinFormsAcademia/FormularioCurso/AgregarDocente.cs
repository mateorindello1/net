using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using WinFormsAcademia.Servicios;
using Microsoft.EntityFrameworkCore;

namespace WinFormsAcademia.FormularioCurso
{
    public partial class AgregarDocente : Form
    {
        private List<int> docentes;
        public Persona? docenteAGuardar = null;
        public string? cargo = null;
        public AgregarDocente(List<int> docentes)
        {
            InitializeComponent();
            this.docentes = docentes;
        }

        private async void AgregarDocente_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            await cargarDocentes();
        }
        private async Task cargarDocentes()
        {
            List<Persona> docentesObtenidos = new List<Persona>();

            if (txtLegajo.Text.Length > 0)
            {
                var docenteBuscado = await PersonaServicios.GetOne(Int32.Parse(txtLegajo.Text), 1);
                docentesObtenidos = new List<Persona>();
                if (docenteBuscado is not null) docentesObtenidos.Add(docenteBuscado);
            }
            else if (docentes.Count > 0)
            {
                //docentesObtenidos = (await PersonaServicios.Get(1)
                //.Where(p => !docentes.Contains(p.Legajo))
                //.ToList();
                var doc = await PersonaServicios.Get(1);
                foreach (var d in doc)
                {
                    if (!docentes.Contains(d.Legajo)) docentesObtenidos.Add(d);
                }
            }
            else docentesObtenidos = (await PersonaServicios.Get(1));
            dgvDocentes.DataSource = docentesObtenidos;
            foreach (DataGridViewColumn columna in dgvDocentes.Columns)
            {
                columna.Visible = false;
            }
            dgvDocentes.Columns["Legajo"].Visible = true;
            dgvDocentes.Columns["Nombre"].Visible = true;
            dgvDocentes.Columns["Apellido"].Visible = true;
            if (dgvDocentes.RowCount > 0)
            {
                btnAgregar.Enabled = true;
                dgvDocentes.Rows[0].Selected = true;
            } else btnAgregar.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtLegajo.Enabled = checkBox1.Checked;
            if (!checkBox1.Checked) txtLegajo.Text = "";
        }

        private void txtOnlyNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            docenteAGuardar = dgvDocentes.SelectedRows[0].DataBoundItem as Persona;
            cargo = comboBox1.SelectedItem.ToString();
        }
    }
}
