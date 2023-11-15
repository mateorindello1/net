using Entidades;
using WinFormsAcademia.Servicios;
using System.Text.RegularExpressions;
using System.Globalization;

namespace WinFormsAcademia.FormularioMateria
{
    public partial class AgregarEditarMateria : Form
    {
        private Materia? materiaAEditar = null;
        private bool editMode = false;
        private const int multHorasCuatrimestre = 12;
        public AgregarEditarMateria()
        {
            InitializeComponent();
            CargarPlanes();
            Text = "Agregar materia";
            cmbTipo.SelectedIndex = 0;
        }

        public AgregarEditarMateria(Materia materia)
        {
            InitializeComponent();
            CargarPlanes();
            editMode = true;
            Text = "Editar materia";
            lblId.Visible = true;
            txtId.Visible = true;
            materiaAEditar = materia;
            btnGuardar.Text = "Guardar";
            btnReestablecer.Visible = true;
            Rellenar();
        }

        private void Rellenar()
        {
            if (materiaAEditar is not null)
            {
                txtId.Text = materiaAEditar.IdMateria.ToString();
                txtDescripcion.Text = materiaAEditar.Descripcion;
                txtNombre.Text = materiaAEditar.Nombre;
                txtHsSem.Text = materiaAEditar.HsSemanales.ToString();
                txtHsTot.Text = materiaAEditar.HsTotales.ToString();
                if (materiaAEditar.HsSemanales * multHorasCuatrimestre == materiaAEditar.HsTotales)
                {
                    cmbTipo.SelectedIndex = 1;
                }
                else cmbTipo.SelectedIndex = 0;
                cmbPlan.SelectedValue = materiaAEditar.IdPlan;
            }
        }

        private async void CargarPlanes()
        {
            // Obtiene las especialidades de la base de datos
            var planes = await PlanServicios.Get();
            // Enlaza la lista de especialidades al ComboBox
            cmbPlan.DataSource = planes;
            cmbPlan.DisplayMember = "Descripcion"; // Establece la propiedad que se mostrará en el ComboBox
            cmbPlan.ValueMember = "IdPlan"; // Establece la propiedad que se utilizará como valor seleccionado
            if (cmbPlan.Items.Count > 0) { cmbPlan.SelectedIndex = 0; } else { cmbPlan.Enabled = false; }
        }

        private bool ValidarCampos()
        {
            if (txtDescripcion.Text.Length < 2 ||
                txtNombre.Text.Length < 2 ||
                cmbPlan.SelectedItem.ToString().Length < 1 ||
                cmbTipo.SelectedItem.ToString().Length < 1)
            {
                return false; // Al menos uno de los campos está vacío o en blanco.
            }
            return true; // Todos los campos son válidos.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                //Crear nueva materia
                Materia nuevaMateria = await MateriaServicios.GetOne(Int32.Parse(txtId.Text));

                nuevaMateria.IdMateria = Int32.Parse(txtId.Text);
                nuevaMateria.Descripcion = txtDescripcion.Text;
                nuevaMateria.Nombre = txtNombre.Text;
                nuevaMateria.HsSemanales = Int32.Parse(txtHsSem.Text);
                nuevaMateria.HsTotales = Int32.Parse(txtHsTot.Text);
                nuevaMateria.IdPlan = (int)cmbPlan.SelectedValue;
                if (editMode)
                {
                    var ok = await MateriaServicios.Update(nuevaMateria);
                    if (ok) { this.Close(); }
                }
                else
                {
                    var materiaAdded = await MateriaServicios.Create(nuevaMateria);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            Rellenar();
        }

        private void txtOnlyAlpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !".-_".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOnlyNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtHsSem_Leave(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                txtHsTot.Text = (Int32.Parse(txtHsSem.Text) * multHorasCuatrimestre).ToString();
            }
            else txtHsTot.Text = (Int32.Parse(txtHsSem.Text) * multHorasCuatrimestre * 2).ToString();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                txtHsTot.Text = (Int32.Parse(txtHsSem.Text) * multHorasCuatrimestre).ToString();
            }
            else txtHsTot.Text = (Int32.Parse(txtHsSem.Text) * multHorasCuatrimestre * 2).ToString();
        }
    }
}
