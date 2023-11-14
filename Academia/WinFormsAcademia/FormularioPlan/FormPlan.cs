using Entidades;
using WinFormsAcademia.Servicios;
using System.Windows.Forms;

namespace WinFormsAcademia.FormularioPlan
{
    public partial class FormPlan : Form
    {
        public FormPlan()
        {
            InitializeComponent();
        }
        private async void List()
        {
            if (cmbEspecialidad.SelectedValue is not null && int.TryParse(cmbEspecialidad.SelectedValue.ToString(), out int selectedValue) && selectedValue != 00)
            {
                var planes = await PlanServicios.Get(selectedValue);
                dgvPlanes.DataSource = planes;
            }
            else dgvPlanes.DataSource = await PlanServicios.Get();
            dgvPlanes.Columns["Comisiones"].Visible = false;
            dgvPlanes.Columns["IdEspecialidadNavigation"].Visible = false;
            dgvPlanes.Columns["Materia"].Visible = false;
            dgvPlanes.Columns["Personas"].Visible = false;
            if (dgvPlanes.Rows.Count == 0)
            {
                btEliminar.Enabled = false;
                btEditar.Enabled = false;
            }
            else
            {
                btEliminar.Enabled = true;
                btEditar.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarPlan agregar = new AgregarEditarPlan();
            agregar.ShowDialog();
            this.List();
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            var planId = Int32.Parse(dgvPlanes.SelectedRows[0].Cells["IdPlan"].Value.ToString());
            var editPersona = await PlanServicios.GetOne(planId);
            AgregarEditarPlan editar = new AgregarEditarPlan(editPersona);
            editar.ShowDialog();
            this.List();
        }

        private async void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlanes.SelectedRows.Count > 0)
            {
                int planId = Int32.Parse(dgvPlanes.SelectedRows[0].Cells["IdPlan"].Value.ToString());
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar este plan?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await PlanServicios.Delete(planId);
                }

            }
            this.List();
        }

        private void FormPlan_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
            this.List();
        }

        private async void CargarEspecialidades()
        {
            var especialidades = new List<Especialidad>
            {
                new Especialidad { IdEspecialidad = 0, Descripcion = "Todas" },
            };
            especialidades.AddRange(await EspecialidadServicios.Get());
            cmbEspecialidad.DataSource = especialidades;
            cmbEspecialidad.DisplayMember = "Descripcion";
            cmbEspecialidad.ValueMember = "IdEspecialidad";
            cmbEspecialidad.SelectedValue = 0;
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.List();
        }
    }
}
