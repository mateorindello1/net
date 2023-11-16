using Entidades;
using WinFormsAcademia.Servicios;
using System.Text.RegularExpressions;
using System.Globalization;

namespace WinFormsAcademia.FormularioComision
{
    public partial class AgregarEditarComision : Form
    {
        private Comision? comisionAEditar = null;
        private bool editMode = false;
        public AgregarEditarComision()
        {
            InitializeComponent();
            CargarPlanes();
            Text = "Agregar comision";
        }

        public AgregarEditarComision(Comision comision)
        {
            InitializeComponent();
            comisionAEditar = comision;
            editMode = true;
            CargarPlanes();
            Text = "Editar comision";
            cmbPlan.Enabled = false;
            cmbMateria.Enabled = false;
            txtNumero.Enabled = false;
            comisionAEditar = comision;
            btnGuardar.Text = "Guardar";
            btnReestablecer.Visible = true;
            Rellenar();
        }

        private void Rellenar()
        {
            if (comisionAEditar is not null)
            {
                txtNumero.Text = comisionAEditar.IdComision.ToString();
                txtDescripcion.Text = comisionAEditar.Descripcion;
                txtAnioEsp.Text = comisionAEditar.AnioEspecialidad.ToString();
            }
        }

        private async void CargarPlanes()
        {
            // Obtiene los planes de la base de datos
            var planes = await PlanServicios.Get();
            // Enlaza la lista de planes al ComboBox
            cmbPlan.DataSource = planes;
            cmbPlan.DisplayMember = "Descripcion"; // Establece la propiedad que se mostrará en el ComboBox
            cmbPlan.ValueMember = "IdPlan"; // Establece la propiedad que se utilizará como valor seleccionado
            if (cmbPlan.Items.Count > 0) { cmbPlan.SelectedIndex = 0; } else { cmbPlan.Enabled = false; }
            if (editMode) { cmbPlan.SelectedValue = comisionAEditar.IdPlan; }
            CargarMaterias();
        }

        private async void CargarMaterias()
        {
            // Obtiene las especialidades de la base de datos
            int.TryParse(cmbPlan.SelectedValue.ToString(), out int selectedPlan);
            var materias = await MateriaServicios.Get(selectedPlan);
            // Enlaza la lista de especialidades al ComboBox
            cmbMateria.DataSource = materias;
            cmbMateria.DisplayMember = "Nombre"; // Establece la propiedad que se mostrará en el ComboBox
            cmbMateria.ValueMember = "IdMateria"; // Establece la propiedad que se utilizará como valor seleccionado
            if (cmbMateria.Items.Count > 0) { cmbMateria.SelectedIndex = 0; cmbMateria.Enabled = true; } else { cmbMateria.Enabled = false; }
            if (editMode) { cmbMateria.SelectedValue = comisionAEditar.IdMateria; }
        }

        private bool ValidarCampos()
        {
            if (txtDescripcion.Text.Length < 2 ||
                txtNumero.Text.Length < 2 ||
                cmbPlan.SelectedItem.ToString().Length < 1 ||
                cmbMateria.SelectedItem.ToString().Length < 1)
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
                Comision nuevaComision = new Comision()
                {
                    IdComision = Int32.Parse(txtNumero.Text),
                    IdMateria = (int)cmbMateria.SelectedValue,
                    IdPlan = (int)cmbPlan.SelectedValue,
                    Descripcion = txtDescripcion.Text,
                    AnioEspecialidad = Int32.Parse(txtAnioEsp.Text),
                };
                if (editMode)
                {
                    var ok = await ComisionServicios.Update(nuevaComision);
                    if (ok) { this.Close(); }
                    else MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var comisionAdded = await ComisionServicios.Create(nuevaComision);
                    if (comisionAdded is not null) { this.Close(); }
                    else MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            Rellenar();
        }

        private void txtOnlyAlpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !".-_ ".Contains(e.KeyChar))
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

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias();
        }
    }
}
