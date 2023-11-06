using Entidades;
using WinFormsAcademia.Servicios;
using System.Data;

namespace WinFormsAcademia.FormularioMateria
{
    public partial class FormMateria : Form
    {
        private List<Materia> MateriaList = new List<Materia>();
        public FormMateria()
        {
            InitializeComponent();
        }

        private async void List()
        {
            dgvPersonas.DataSource = await MateriaServicios.Get();
        }

        protected async Task<int> ObtenerUltimoId()
        {
            if (MateriaList.Any())
            {
                // Ordena la lista de personas por ID de manera descendente y toma el primer elemento
                Materia ultimaPersona = (await MateriaServicios.Get()).OrderByDescending(m => m.IdMateria).First();
                return ultimaPersona.IdMateria;
            }
            else
            {
                // Si la lista está vacía, devuelve un valor inicial
                return 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.List();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
