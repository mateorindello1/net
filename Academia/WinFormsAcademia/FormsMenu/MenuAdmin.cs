using WinFormsAcademia.FormularioEspecialidad;
using WinFormsAcademia.FormularioMateria;
using WinFormsAcademia.FormularioPersona;
using WinFormsAcademia.FormularioPlan;
using WinFormsAcademia.FormularioComision;
using WinFormsAcademia.FormularioCurso;
using Entidades;

namespace WinFormsAcademia
{
    public partial class MenuAdmin : Form
    {
        private const int alumno = 0;
        private const int docente = 1;
        private const int admin = 2;
        private Persona administrador;
        public MenuAdmin(Persona persona)
        {
            InitializeComponent();
            this.administrador = persona;
            this.lblBienvenido.Text = $"Bienvenido, {persona.Nombre} {persona.Apellido}";
        }
        //USUARIOS
        private void btnTodos_Click(object sender, EventArgs e)
        {
            mostrarForm(new FormPersona());
        }
        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            mostrarForm(new FormPersona(alumno));
        }
        private void btnDocentes_Click(object sender, EventArgs e)
        {
            mostrarForm(new FormPersona(docente));
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            mostrarForm(new FormPersona(admin));
        }
        // ADMINISTRACION DE DATOS
        private void btnPlanes_Click(object sender, EventArgs e)
        {
            mostrarForm(new FormPlan());
        }
        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            mostrarForm(new FormEspecialidad());
        }
        private void btnMaterias_Click(object sender, EventArgs e)
        {
            mostrarForm(new FormMateria());
        }
        private void btnComisiones_Click(object sender, EventArgs e)
        {
            mostrarForm(new FormComision());
        }
        private void btnCursos_Click(object sender, EventArgs e)
        {
            mostrarForm(new FormCurso());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void MenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.Retry)
            {
                var login = new Login();
                login.MdiParent = this.MdiParent;
                login.StartPosition = FormStartPosition.Manual;
                login.Location = new Point(
                    MdiParent.Location.X + (MdiParent.Width - login.Width) / 2,
                    MdiParent.Location.Y + (MdiParent.Height - login.Height) / 2
                );
                this.Dispose();
                login.Show();
            }
        }

        private void mostrarForm(Form form)
        {
            this.Hide();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                MdiParent.Location.X + (MdiParent.Width - form.Width) / 2,
                MdiParent.Location.Y + (MdiParent.Height - form.Height) / 2
            );
            form.ShowDialog();
            this.Show();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}