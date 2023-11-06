using Entidades;
using WinFormsAcademia.Servicios;

namespace WinFormsAcademia.FormularioPlan
{
    public partial class FormPlan : Form
    {
        public FormPlan()
        {
            InitializeComponent();
        }

        protected async Task List()
        {
            this.dgvPlanes.DataSource = await PlanServicios.Get();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            await this.List();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btConsultar_Click(object sender, EventArgs e)
        {
            BusquedaForm busqueda = new BusquedaForm();
            busqueda.ShowDialog();
            int idRecibido = int.Parse(busqueda.id);

            if (idRecibido != 0)
            {
                var plan = await PlanServicios.GetOne(idRecibido);

                if (plan is not null)
                {
                    dgvPlanes.DataSource = plan;
                }
                else
                {
                    MessageBox.Show("Plan no encontrado", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            var editPlan = dgvPlanes.SelectedRows[0].DataBoundItem as Plan; ;
            EditarForm editar = new EditarForm(editPlan);
            await this.List();
        }

        private async void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlanes.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvPlanes.SelectedRows[0];

                // El nombre de la columna que contiene el ID es "idAlumno"
                // Acceder al valor del ID de la fila seleccionada:
                int id = (int)selectedRow.Cells["idPlan"].Value;

                // Mostrar un MessageBox de confirmación
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar este plan?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ahora, la variable 'id' contiene el ID de la fila seleccionada.

                    await PlanServicios.Delete(id);
                }


            }

            await this.List();
        }

        private async void FormPlan_Load(object sender, EventArgs e)
        {
            await this.List();
        }
    }
}
