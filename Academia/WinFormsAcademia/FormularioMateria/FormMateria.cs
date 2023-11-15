using Entidades;
using WinFormsAcademia.Servicios;
using System.Windows.Forms;

namespace WinFormsAcademia.FormularioMateria
{
    public partial class FormMateria : Form
    {
        public FormMateria()
        {
            InitializeComponent();

        }
        private async void List()
        {
            if (cmbPlan.SelectedValue is not null && int.TryParse(cmbPlan.SelectedValue.ToString(), out int selectedValue) && selectedValue != 00)
            {
                var materias = await MateriaServicios.Get(selectedValue);
                dgvMaterias.DataSource = materias;
            }
            else dgvMaterias.DataSource = await MateriaServicios.Get();
            dgvMaterias.Columns["Comisiones"].Visible = false;
            dgvMaterias.Columns["IdPlanNavigation"].Visible = false;
            if (dgvMaterias.Rows.Count == 0)
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
            AgregarEditarMateria agregar = new AgregarEditarMateria();
            agregar.ShowDialog();
            this.List();
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            var materiaId = Int32.Parse(dgvMaterias.SelectedRows[0].Cells["IdMateria"].Value.ToString());
            var editMateria = await MateriaServicios.GetOne(materiaId);
            AgregarEditarMateria editar = new AgregarEditarMateria(editMateria);
            editar.ShowDialog();
            this.List();
        }

        private async void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                int personaId = Int32.Parse(dgvMaterias.SelectedRows[0].Cells["IdMateria"].Value.ToString());
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar esta materia?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await PersonaServicios.Delete(personaId);
                }

            }
            this.List();
        }

        private void FormMateria_Load(object sender, EventArgs e)
        {
            CargarPlanes();
            this.List();
        }

        private async void CargarPlanes()
        {
            var planes = new List<Plan>
            {
                new Plan { IdPlan = 0, Descripcion = "<Todos>" },
            };
            planes.AddRange(await PlanServicios.Get());
            cmbPlan.DataSource = planes;
            cmbPlan.DisplayMember = "Descripcion";
            cmbPlan.ValueMember = "IdPlan";
            cmbPlan.SelectedValue = 0;
        }

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.List();
        }
    }
}
