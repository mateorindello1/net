using Entidades;
using WinFormsAcademia.Servicios;

namespace WinFormsAcademia.FormularioEspecialidad
{
    public partial class FormEspecialidad : Form
    {
        private List<Especialidad> especialidadList = new List<Especialidad>();

        public FormEspecialidad()
        {
            InitializeComponent();
            dgvEspecialidades.CurrentCell = null;
        }

        private void FormEspecialidad_Load(object sender, EventArgs e)
        {

        }
        protected async Task List()
        {
            this.dgvEspecialidades.DataSource = await EspecialidadServicios.Get();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await this.List();
        }

        private async void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvEspecialidades.SelectedRows[0];

                // El nombre de la columna que contiene el ID es "idAlumno"
                // Acceder al valor del ID de la fila seleccionada:
                int id = (int)selectedRow.Cells["idEspecialidad"].Value;

                // Mostrar un MessageBox de confirmación
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar esta especialidad?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ahora, la variable 'id' contiene el ID de la fila seleccionada.

                    await EspecialidadServicios.Delete(id);
                }


            }

            await this.List();
        }

        private async void btConsultar_Click(object sender, EventArgs e)
        {
            BusquedaForm busqueda = new BusquedaForm();
            busqueda.ShowDialog();
            int idRecibido = int.Parse(busqueda.id);

            if (idRecibido!=0)
            {
                var especialidad = await EspecialidadServicios.GetOne(idRecibido);

                if (especialidad is not null)
                {
                    dgvEspecialidades.DataSource = especialidad;
                }
                else
                {
                    MessageBox.Show("Especialidad no encontrada", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private async void btAgregar_Click(object sender, EventArgs e)
        {
            AgregarForm agregar = new AgregarForm();
            agregar.ShowDialog();
            await this.List();
            
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            var nuevaEspecialidad = dgvEspecialidades.SelectedRows[0].DataBoundItem as Especialidad; ;
            EditarForm editar = new EditarForm(nuevaEspecialidad);
            editar.ShowDialog();
            await this.List();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
