using Entidades;
using WinFormsAcademia.Servicios;
using System.Windows.Forms;

namespace WinFormsAcademia.FormularioCurso
{
    public partial class FormCurso : Form
    {
        public FormCurso()
        {
            InitializeComponent();
        }
        private async void List()
        {

            if (cmbPlan.SelectedValue is not null && int.TryParse(cmbPlan.SelectedValue.ToString(), out int selectedPlan) && selectedPlan != 0)
            {
                if (cmbMateria.SelectedValue is not null && int.TryParse(cmbMateria.SelectedValue.ToString(), out int selectedMateria) && selectedMateria != 0)
                {
                    if (cmbComision.SelectedValue is not null && int.TryParse(cmbComision.SelectedValue.ToString(), out int selectedComision) && selectedComision != 0)
                    {
                        dgvCursos.DataSource = await CursoServicios.Get(selectedPlan, selectedMateria, selectedComision);
                    } else dgvCursos.DataSource = await CursoServicios.Get(selectedPlan, selectedMateria);
                }
                else dgvCursos.DataSource = await CursoServicios.Get(selectedPlan);
            }
            else dgvCursos.DataSource = await CursoServicios.Get();
            dgvCursos.Columns["Dictados"].Visible = false;
            dgvCursos.Columns["Id"].Visible = false;
            dgvCursos.Columns["Inscripciones"].Visible = false;
            if (dgvCursos.Rows.Count == 0)
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
            AgregarEditarCurso agregar = new AgregarEditarCurso();
            agregar.ShowDialog();
            this.List();
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            var comisionId = Int32.Parse(dgvCursos.SelectedRows[0].Cells["IdComision"].Value.ToString());
            var planId = Int32.Parse(dgvCursos.SelectedRows[0].Cells["IdPlan"].Value.ToString());
            var materiaId = Int32.Parse(dgvCursos.SelectedRows[0].Cells["IdMateria"].Value.ToString());
            var anio = Int32.Parse(dgvCursos.SelectedRows[0].Cells["Anio"].Value.ToString());
            var editCurso = await CursoServicios.GetOne(comisionId, planId, materiaId,anio);
            AgregarEditarCurso editar = new AgregarEditarCurso(editCurso);
            editar.ShowDialog();
            this.List();
        }

        private async void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar este curso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var comisionId = Int32.Parse(dgvCursos.SelectedRows[0].Cells["IdComision"].Value.ToString());
                    var planId = Int32.Parse(dgvCursos.SelectedRows[0].Cells["IdPlan"].Value.ToString());
                    var materiaId = Int32.Parse(dgvCursos.SelectedRows[0].Cells["IdMateria"].Value.ToString());
                    var anio = Int32.Parse(dgvCursos.SelectedRows[0].Cells["Anio"].Value.ToString());
                    var editCurso = await CursoServicios.GetOne(comisionId, planId, materiaId, anio);
                    var ok = await CursoServicios.Delete(comisionId, planId, materiaId, anio);
                    if (!ok) { MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }

            }
            this.List();
        }

        private async void FormCurso_Load(object sender, EventArgs e)
        {
            await CargarPlanes();
            this.List();
        }

        private async Task CargarPlanes()
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

        private async Task CargarMaterias(int idPlan)
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

        private async Task CargarComisiones(int idPlan, int idMateria)
        {
            var comisiones = new List<Comision>
            {
                new Comision { IdComision = 0, Descripcion = "<Todas las comisiones>" },
            };
            comisiones.AddRange(await ComisionServicios.Get(idPlan,idMateria));
            cmbComision.DataSource = comisiones;
            cmbComision.DisplayMember = "Descripcion";
            cmbComision.ValueMember = "IdComision";
            cmbComision.SelectedValue = 0;
        }

        private async void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlan.SelectedValue is not null)
            {
                int.TryParse(cmbPlan.SelectedValue.ToString(), out int selectedValue);
                if (selectedValue == 0)
                {
                    cmbMateria.DataSource = null;
                    cmbMateria.Enabled = false;
                    cmbComision.DataSource = null;
                    cmbComision.Enabled = false;
                }
                else
                {
                    cmbMateria.Enabled = true;
                    await CargarMaterias(selectedValue);
                }
                this.List();
            }
        }

        private async void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMateria.SelectedValue is not null)
            {
                int.TryParse(cmbMateria.SelectedValue.ToString(), out int selectedMateria);
                if (selectedMateria == 0)
                {
                    cmbComision.DataSource = null;
                    cmbComision.Enabled = false;
                }
                else
                {
                    cmbComision.Enabled = true;
                    await CargarComisiones((int)cmbPlan.SelectedValue, selectedMateria);
                }
                this.List();
            }
        }
    }
}
