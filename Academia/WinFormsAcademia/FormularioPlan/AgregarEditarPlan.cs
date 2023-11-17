using Entidades;
using WinFormsAcademia.Servicios;

namespace WinFormsAcademia.FormularioPlan
{
    public partial class AgregarEditarPlan : Form
    {
        private Plan? planAEditar = null;
        private bool editMode = false;
        public AgregarEditarPlan()
        {
            InitializeComponent();
            CargarEspecialidades();
            Text = "Agregar plan";
        }

        public AgregarEditarPlan(Plan plan)
        {
            InitializeComponent();
            CargarEspecialidades();
            editMode = true;
            Text = "Editar plan";
            lblId.Visible = true;
            txtId.Visible = true;
            planAEditar = plan;
            btnGuardar.Text = "Guardar";
            btnReestablecer.Visible = true;
            Rellenar();
        }

        private void Rellenar()
        {
            if (planAEditar is not null)
            {
                txtId.Text = planAEditar.IdPlan.ToString();
                txtDescripcion.Text = planAEditar.Descripcion;
                cmbEspecialidades.SelectedValue = planAEditar.IdEspecialidad;
            }
        }

        private async void CargarEspecialidades()
        {
            var especialidades = await EspecialidadServicios.Get();
            var displayList = especialidades.Select(especialidad => new
            {
                DisplayText = $"ID: {especialidad.IdEspecialidad} - {especialidad.Descripcion}",
                especialidad.IdEspecialidad
            }).ToList();
            cmbEspecialidades.DataSource = displayList;
            cmbEspecialidades.DisplayMember = "DisplayText";
            cmbEspecialidades.ValueMember = "IdEspecialidad";
            if (cmbEspecialidades.Items.Count > 0) { cmbEspecialidades.SelectedIndex = 0; } else { cmbEspecialidades.Enabled = false; }
        }

        private bool ValidarCampos()
        {
            if (cmbEspecialidades.SelectedItem.ToString().Length < 1 || !ValidarDescripcion(txtDescripcion.Text))
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
                //Crear nuevo plan
                Plan nuevoPlan = new Plan()
                {
                    IdPlan = 0,
                    IdEspecialidad = (int)cmbEspecialidades.SelectedValue,
                    Descripcion = txtDescripcion.Text,
                };
                if (editMode)
                {
                    nuevoPlan.IdPlan = planAEditar.IdPlan;
                    var ok = await PlanServicios.Update(nuevoPlan);
                    if (ok) { this.Close(); }
                    else MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var planAdded = await PlanServicios.Create(nuevoPlan);
                    if (planAdded is not null) { this.Close(); }
                    else MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void txtOnlyAlphanumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !".-_ ".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            var a = ValidarDescripcion(txtDescripcion.Text);
        }

        private bool ValidarDescripcion(string text)
        {
            if (txtDescripcion.Text.Length < 2) return false;
            if (editMode && planAEditar.Descripcion == txtDescripcion.Text)
            {
                return true;
            }
            else if (txtDescripcion.Text.Length >= 2)
            {
                var disponible = PlanServicios.DescripcionDisponible(txtDescripcion.Text);
                lblErrDescripcion.Visible = !disponible;
                return disponible;
            }
            else return false;
        }
    }
}
