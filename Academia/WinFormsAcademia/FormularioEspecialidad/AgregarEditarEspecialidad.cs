using Entidades;
using WinFormsAcademia.Servicios;

namespace WinFormsAcademia.FormularioEspecialidad
{
    public partial class AgregarEditarEspecialidad : Form
    {
        private Especialidad? especialidadAEditar = null;
        private bool editMode = false;
        public AgregarEditarEspecialidad()
        {
            InitializeComponent();
            Text = "Agregar especialidad";
        }

        public AgregarEditarEspecialidad(Especialidad especialidad)
        {
            InitializeComponent();
            editMode = true;
            Text = "Editar especialidad";
            lblId.Visible = true;
            txtId.Visible = true;
            especialidadAEditar = especialidad;
            btnGuardar.Text = "Guardar";
            btnReestablecer.Visible = true;
            Rellenar();
        }

        private void Rellenar()
        {
            if (especialidadAEditar is not null)
            {
                txtId.Text = especialidadAEditar.IdEspecialidad.ToString();
                txtDescripcion.Text = especialidadAEditar.Descripcion;
            }
        }

        private bool ValidarCampos()
        {
            return ValidarDescripcion(txtDescripcion.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                //Crear nueva especialidad
                Especialidad nuevaEspecialidad = new Especialidad()
                {
                    IdEspecialidad = 0,
                    Descripcion = txtDescripcion.Text,
                };
                if (editMode)
                {
                    nuevaEspecialidad.IdEspecialidad = especialidadAEditar.IdEspecialidad;
                    var ok = await EspecialidadServicios.Update(nuevaEspecialidad);
                    if (ok) { this.Close(); }
                    else MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var especialidadAdded = await EspecialidadServicios.Create(nuevaEspecialidad);
                    if (especialidadAdded is not null) { this.Close(); }
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
            if (editMode && especialidadAEditar.Descripcion == txtDescripcion.Text)
            {
                return true;
            }
            else if (txtDescripcion.Text.Length >= 2)
            {
                var disponible = EspecialidadServicios.DescripcionDisponible(txtDescripcion.Text);
                lblErrDescripcion.Visible = !disponible;
                return disponible;
            }
            else return false;
        }
    }
}
