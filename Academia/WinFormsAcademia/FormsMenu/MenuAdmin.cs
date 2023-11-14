using WinFormsAcademia.FormularioEspecialidad;
using WinFormsAcademia.FormularioMateria;
using WinFormsAcademia.FormularioPersona;
using WinFormsAcademia.FormularioPlan;
using Entidades;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;

namespace WinFormsAcademia
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPlan planesCrud = new FormPlan();
            planesCrud.StartPosition = FormStartPosition.Manual;
            planesCrud.Location = new Point(
                MdiParent.Location.X + (MdiParent.Width - planesCrud.Width) / 2,
                MdiParent.Location.Y + (MdiParent.Height - planesCrud.Height) / 2
            );
            planesCrud.ShowDialog();
            this.Show();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            FormEspecialidad especialidadesCrud = new FormEspecialidad();
            especialidadesCrud.ShowDialog();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FormMateria materiasCrud = new FormMateria();
            materiasCrud.ShowDialog();
        }
        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPersona todosCrud = new FormPersona(null);
            todosCrud.StartPosition = FormStartPosition.Manual;
            todosCrud.Location = new Point(
                MdiParent.Location.X + (MdiParent.Width - todosCrud.Width) / 2,
                MdiParent.Location.Y + (MdiParent.Height - todosCrud.Height) / 2
            );
            todosCrud.ShowDialog();
            this.Show();
        }
        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPersona alumnosCrud = new FormPersona(0);
            alumnosCrud.StartPosition = FormStartPosition.Manual;
            alumnosCrud.Location = new Point(
                MdiParent.Location.X + (MdiParent.Width - alumnosCrud.Width) / 2,
                MdiParent.Location.Y + (MdiParent.Height - alumnosCrud.Height) / 2
            );
            alumnosCrud.ShowDialog();
            this.Show();
        }
        private void btnDocentes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPersona docentesCrud = new FormPersona(1);
            docentesCrud.StartPosition = FormStartPosition.Manual;
            docentesCrud.Location = new Point(
                MdiParent.Location.X + (MdiParent.Width - docentesCrud.Width) / 2,
                MdiParent.Location.Y + (MdiParent.Height - docentesCrud.Height) / 2
            );
            docentesCrud.ShowDialog();
            this.Show();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPersona adminCrud = new FormPersona(2);
            adminCrud.StartPosition = FormStartPosition.Manual;
            adminCrud.Location = new Point(
                MdiParent.Location.X + (MdiParent.Width - adminCrud.Width) / 2,
                MdiParent.Location.Y + (MdiParent.Height - adminCrud.Height) / 2
            );
            adminCrud.ShowDialog();
            this.Show();
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
    }
}