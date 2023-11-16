using Entidades;
using WinFormsAcademia.Servicios;
using System.Windows.Forms;

namespace WinFormsAcademia.FormularioPersona
{
    public partial class FormPersona : Form
    {
        int? rol = null;
        public FormPersona(int? tipo=null)
        {
            InitializeComponent();
            if (tipo is not null) { rol = tipo; }

        }
        private async void List()
        {
            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                List<Persona> list = new List<Persona>();
                list.Add(await PersonaServicios.GetOne(Int32.Parse(txtFilter.Text), rol));
                dgvPersonas.DataSource = list;
            }
            else dgvPersonas.DataSource = await PersonaServicios.Get(rol);
            //dgvPersonas.Columns["Dictados"].Visible = false;
            //dgvPersonas.Columns["IdPlanNavigation"].Visible = false;
            //dgvPersonas.Columns["Inscripciones"].Visible = false;
            if (dgvPersonas.Rows.Count == 0)
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
            AgregarEditarPersona agregar = new AgregarEditarPersona();
            agregar.ShowDialog();
            this.List();
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            var personaId = Int32.Parse(dgvPersonas.SelectedRows[0].Cells["Legajo"].Value.ToString());
            var editPersona = await PersonaServicios.GetOne(personaId,null);
            AgregarEditarPersona editar = new AgregarEditarPersona(editPersona);
            editar.ShowDialog();
            this.List();
        }

        private async void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0)
            {
                int personaId = Int32.Parse(dgvPersonas.SelectedRows[0].Cells["Legajo"].Value.ToString());
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar esta persona?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await PersonaServicios.Delete(personaId);
                }

            }
            this.List();
        }

        private void FormPersona_Load(object sender, EventArgs e)
        {
            this.List();
            if (rol is not null)
            {
                switch (rol)
                {
                    case 0:
                        this.Text = "Alumnos";
                        label1.Text = "Alumnos";
                        break;
                    case 1:
                        this.Text = "Docentes";
                        label1.Text = "Docentes";
                        break;
                    case 2:
                        this.Text = "Administradores";
                        label1.Text = "Administradores";
                        break;
                    default:
                        break;
                }
            }
        }

        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilter.Checked)
            {
                txtFilter.Enabled = true;
            }
            else
            {
                txtFilter.Enabled = false;
                txtFilter.Text = string.Empty;
                this.List();
            }
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            this.List();
        }
    }
}
