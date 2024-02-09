using Entidades;
using WinFormsAcademia.Servicios;
using System.Windows.Forms;

namespace WinFormsAcademia.FormularioCursosDocente
{
    public partial class FormCursosDocente : Form
    {
        private Persona docente;
        private List<Curso> cursoList;
        public FormCursosDocente(Persona docente)
        {
            InitializeComponent();
            this.docente = docente;
        }
        private async void List()
        {
            dgvCursos.DataSource = await CursoServicios.GetByDocente(docente.Legajo);
            dgvCursos.Columns["Dictados"].Visible = false;
            dgvCursos.Columns["Id"].Visible = false;
            dgvCursos.Columns["Inscripciones"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FormCurso_Load(object sender, EventArgs e)
        {
            this.List();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarNotas_Click(object sender, EventArgs e)
        {

        }
    }
}
