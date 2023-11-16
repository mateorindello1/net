using Entidades;
using WinFormsAcademia.Servicios;
using System.Windows.Forms;

namespace WinFormsAcademia.FormularioComision
{
    public partial class FormComision : Form
    {
        public FormComision()
        {
            InitializeComponent();

        }
        private async void List()
        {

            if (cmbPlan.SelectedValue is not null && int.TryParse(cmbPlan.SelectedValue.ToString(), out int selectedPlan) && selectedPlan != 0)
            {
                List<Comision> comisiones;
                if (cmbMateria.SelectedValue is not null && int.TryParse(cmbMateria.SelectedValue.ToString(), out int selectedMateria) && selectedMateria != 0)
                {
                    comisiones = await ComisionServicios.Get(selectedPlan, selectedMateria);
                }
                else comisiones = await ComisionServicios.Get(selectedPlan);
                dgvComisiones.DataSource = comisiones;
            }
            else dgvComisiones.DataSource = await ComisionServicios.Get();
            dgvComisiones.Columns["Cursos"].Visible = false;
            dgvComisiones.Columns["IdPlanNavigation"].Visible = false;
            dgvComisiones.Columns["IdMateriaNavigation"].Visible = false;
            if (dgvComisiones.Rows.Count == 0)
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
            AgregarEditarComision agregar = new AgregarEditarComision();
            agregar.ShowDialog();
            this.List();
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            var comisionId = Int32.Parse(dgvComisiones.SelectedRows[0].Cells["IdComision"].Value.ToString());
            var planId = Int32.Parse(dgvComisiones.SelectedRows[0].Cells["IdPlan"].Value.ToString());
            var materiaId = Int32.Parse(dgvComisiones.SelectedRows[0].Cells["IdMateria"].Value.ToString());
            var editComision = await ComisionServicios.GetOne(comisionId, planId, materiaId);
            AgregarEditarComision editar = new AgregarEditarComision(editComision);
            editar.ShowDialog();
            this.List();
        }

        private async void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvComisiones.SelectedRows.Count > 0)
            {
                int personaId = Int32.Parse(dgvComisiones.SelectedRows[0].Cells["IdComision"].Value.ToString());
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar esta comision?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await PersonaServicios.Delete(personaId);
                }

            }
            this.List();
        }

        private void FormComision_Load(object sender, EventArgs e)
        {
            CargarPlanes();
            this.List();
        }

        private async void CargarPlanes()
        {
            var planes = new List<Plan>
            {
                new Plan { IdPlan = 0, Descripcion = "<Todos los planes>" },
            };
            planes.AddRange(await PlanServicios.Get());
            cmbPlan.DataSource = planes;
            cmbPlan.DisplayMember = "Descripcion";
            cmbPlan.ValueMember = "IdPlan";
            cmbPlan.SelectedValue = 0;
        }

        private async void CargarMaterias(int idPlan)
        {
            var materias = new List<Materia>
            {
                new Materia { IdMateria = 0, Nombre = "<Todas las materias>" },
            };
            materias.AddRange(await MateriaServicios.Get(idPlan));
            cmbMateria.DataSource = materias;
            cmbMateria.DisplayMember = "Nombre";
            cmbMateria.ValueMember = "IdMateria";
            cmbMateria.SelectedValue = 0;
        }

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(cmbPlan.SelectedValue.ToString(), out int selectedValue);
            if (selectedValue == 0)
            {
                cmbMateria.DataSource = null;
                cmbMateria.Enabled = false;
            }
            else
            {
                cmbMateria.Enabled = true;
                CargarMaterias(selectedValue);
            }
            this.List();
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.List();
        }
    }
}
