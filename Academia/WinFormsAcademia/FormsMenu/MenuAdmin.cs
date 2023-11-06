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
            FormPersona alumnosCrud = new FormPersona(0);
            alumnosCrud.ShowDialog();
        }
        private void btnDocentes_Click(object sender, EventArgs e)
        {
            FormPersona docentesCrud = new FormPersona(1);
            docentesCrud.ShowDialog();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormPersona adminCrud = new FormPersona(2);
            adminCrud.ShowDialog();
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