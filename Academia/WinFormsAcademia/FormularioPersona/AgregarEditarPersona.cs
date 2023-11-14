using Entidades;
using WinFormsAcademia.Servicios;
using System.Text.RegularExpressions;
using System.Globalization;

namespace WinFormsAcademia.FormularioPersona
{
    public partial class AgregarEditarPersona : Form
    {
        private Persona? personaAEditar = null;
        private bool editMode = false;
        public AgregarEditarPersona()
        {
            InitializeComponent();
            CargarPlanes();
            Text = "Agregar persona";
            cmbTipo.SelectedIndex = 0;
        }

        public AgregarEditarPersona(Persona persona)
        {
            InitializeComponent();
            CargarPlanes();
            editMode = true;
            Text = "Editar persona";
            lblId.Visible = true;
            txtId.Visible = true;
            personaAEditar = persona;
            btnGuardar.Text = "Guardar";
            btnReestablecer.Visible = true;
            Rellenar();
        }

        private void Rellenar()
        {
            if (personaAEditar is not null)
            {
                txtId.Text = personaAEditar.Legajo.ToString();
                txtApellido.Text = personaAEditar.Apellido;
                txtNombre.Text = personaAEditar.Nombre;
                txtDireccion.Text = personaAEditar.Direccion;
                txtEmail.Text = personaAEditar.Email;
                txtTelefono.Text = personaAEditar.Telefono;
                cmbTipo.SelectedIndex = personaAEditar.TipoUsuario;
                txtUsuario.Text = personaAEditar.NombreUsuario;
                txtContraseña.Text = personaAEditar.Password;
                cmbPlan.SelectedValue = personaAEditar.IdPlan;
                maskedTextBox1.Text = personaAEditar.FechaNacimiento.ToString("dd/MM/yyyy");
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
            if (txtApellido.Text.Length < 2 ||
                txtDireccion.Text.Length < 2 ||
                txtNombre.Text.Length < 2 ||
                !ValidarEmail(txtEmail.Text) ||
                !ValidarFecha(maskedTextBox1.Text) ||
                cmbPlan.SelectedItem.ToString().Length < 1 ||
                cmbTipo.SelectedItem.ToString().Length < 1 ||
                txtTelefono.Text.Length < 2 ||
                !ValidarUsuario(txtUsuario.Text) ||
                txtContraseña.Text.Length < 5)
            {
                return false; // Al menos uno de los campos está vacío o en blanco.
            }
            return true; // Todos los campos son válidos.
        }

        private bool ValidarFecha(string fecha)
        {
            string fechaIngresada = maskedTextBox1.Text;
            DateTime fechaConvertida;
            if (DateTime.TryParseExact(fechaIngresada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaConvertida))
            {
                return true;
            }
            else return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                //Crear nueva persona
                Persona nuevaPersona = await PersonaServicios.GetOne(Int32.Parse(txtId.Text), null);

                nuevaPersona.Legajo = Int32.Parse(txtId.Text);
                nuevaPersona.Apellido = txtApellido.Text;
                nuevaPersona.Nombre = txtNombre.Text;
                nuevaPersona.Direccion = txtDireccion.Text;
                nuevaPersona.Email = txtEmail.Text;
                DateTime fechaNac;
                fechaNac = DateTime.Parse(maskedTextBox1.Text);
                nuevaPersona.FechaNacimiento = fechaNac;
                nuevaPersona.IdPlan = (int)cmbPlan.SelectedValue;
                nuevaPersona.Telefono = txtTelefono.Text;
                nuevaPersona.NombreUsuario = txtUsuario.Text;
                nuevaPersona.Password = txtContraseña.Text;
                nuevaPersona.TipoUsuario = cmbTipo.SelectedIndex;
                if (editMode)
                {
                    var ok = await PersonaServicios.Update(nuevaPersona);
                    if (ok) { this.Close(); }
                }
                else
                {
                    var personaAdded = await PersonaServicios.Create(nuevaPersona);
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(txtEmail.Text))
            {
                lblErrorEmail.Visible = false;
            }
            else
            {
                lblErrorEmail.Visible = true;
            }
        }
        private bool ValidarEmail(string email)
        {
            if (email.Length == 0) return false;
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, patron);
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
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            lblErrUser.Visible = !ValidarUsuario(txtUsuario.Text);
        }

        private bool ValidarUsuario(string text)
        {
            if (txtUsuario.Text.Length < 5) return false;
            if (editMode && personaAEditar.NombreUsuario == txtUsuario.Text)
            {
                return true;
            }
            else if (txtUsuario.Text.Length >= 5)
            {
                return PersonaServicios.UsuarioDisponible(txtUsuario.Text);
            }
            else return false;
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !chkPass.Checked;
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            string fechaIngresada = maskedTextBox1.Text;
            if (fechaIngresada.Contains("-"))
            {
                maskedTextBox1.Text = string.Empty;
            }
        }
    }
}
