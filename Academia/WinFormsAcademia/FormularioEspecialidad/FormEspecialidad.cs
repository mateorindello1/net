using Entidades;
using WinFormsAcademia.Servicios;
using System.Windows.Forms;

namespace WinFormsAcademia.FormularioEspecialidad
{
    public partial class FormEspecialidad : Form
    {
        public FormEspecialidad()
        {
            InitializeComponent();
        }
        private async void List()
        {
            dgvEspecialidades.DataSource = await EspecialidadServicios.Get();
            dgvEspecialidades.Columns["Planes"].Visible = false;
            if (dgvEspecialidades.Rows.Count == 0)
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
            AgregarEditarEspecialidad agregar = new AgregarEditarEspecialidad();
            agregar.ShowDialog();
            this.List();
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            var especialidadId = Int32.Parse(dgvEspecialidades.SelectedRows[0].Cells["IdEspecialidad"].Value.ToString());
            var editEspecialidad = await EspecialidadServicios.GetOne(especialidadId);
            AgregarEditarEspecialidad editar = new AgregarEditarEspecialidad(editEspecialidad);
            editar.ShowDialog();
            this.List();
        }

        private async void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows.Count > 0)
            {
                int especialidadId = Int32.Parse(dgvEspecialidades.SelectedRows[0].Cells["IdEspecialidad"].Value.ToString());
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar esta especialidad?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await PlanServicios.Delete(especialidadId);
                }

            }
            this.List();
        }

        private void FormPlan_Load(object sender, EventArgs e)
        {
            this.List();
        }

    }
}
