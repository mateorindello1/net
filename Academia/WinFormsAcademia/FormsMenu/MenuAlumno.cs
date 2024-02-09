using WinFormsAcademia.FormularioEspecialidad;
using WinFormsAcademia.FormularioMateria;
using WinFormsAcademia.FormularioPersona;
using WinFormsAcademia.FormularioPlan;
using WinFormsAcademia.FormularioInscripcion;
using Entidades;
using System.Windows.Forms;
using WinFormsAcademia.FormsMenu;
using WinFormsAcademia.Servicios;
using WinFormsAcademia.FormularioNotaAlumno;

namespace WinFormsAcademia
{
    public partial class MenuAlumno : Form
    {
        private Persona alumno;
        public MenuAlumno(Persona persona)
        {
            InitializeComponent();
            this.alumno = persona;
            this.lblBienvenido.Text = $"Bienvenido, {persona.Nombre} {persona.Apellido}";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            InscripcionCursoAlumno inscripcionForm = new InscripcionCursoAlumno(this.alumno);
            inscripcionForm.Show();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            NotasAlumno notasAlumnoForm = new NotasAlumno(this.alumno);
            notasAlumnoForm.Show();
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
        private void btnMostrarInscripciones_Click(object sender, EventArgs e)
        {
            MostrarInscripciones mostrarInscripcionesForm = new MostrarInscripciones(this.alumno);
            mostrarInscripcionesForm.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}