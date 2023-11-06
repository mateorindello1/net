using Entidades;
using WinFormsAcademia.Servicios;
namespace WinFormsAcademia
{
    public partial class Login : Form
    {
        public Persona? Persona { get; private set; }
        public int tipoIngreso { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            if (await login())
            {
                tipoIngreso = Persona.TipoUsuario;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblError.Visible = true;
                btnOK.Enabled = true;
            }
        }

        private void chkShowPw_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPw.Checked;
        }
        private async Task<bool> login()
        {
            var credenciales = new Credenciales()
            {
                userName = txtUsuario.Text,
                password = txtPassword.Text,
            };
            var prsn = await PersonaServicios.Login(credenciales);
            if (prsn is not null)
            {
                Persona = prsn;
                return true;
            }
            else return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
        }

        private void ValidateFields()
        {
            if (txtPassword.Text.Length >= 4 && txtUsuario.Text.Length >= 4) { btnOK.Enabled = true; }
            else { btnOK.Enabled = false; }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !".-_".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateFields();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                Form? form = null;
                switch (this.tipoIngreso)
                {
                    case 0:
                        form = new MenuAlumno(); break;
                    case 1:
                        form = new MenuDocente(); break;
                    case 2:
                        form = new MenuAdmin(); break;
                    default:
                        Application.Exit(); break;

                }
                if (form is not null)
                {
                    form.MdiParent = this.MdiParent;
                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = new Point(
                        MdiParent.Location.X + (MdiParent.Width - form.Width) / 2,
                        MdiParent.Location.Y + (MdiParent.Height - form.Height) / 2
                    );
                    form.MdiParent = this.MdiParent;
                    this.Dispose();
                    form.Show();
                }
            }
            else Application.Exit();
        }
    }
}
