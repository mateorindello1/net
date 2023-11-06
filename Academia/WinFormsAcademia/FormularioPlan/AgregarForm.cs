using Entidades;
using WinFormsAcademia.Servicios;

namespace WinFormsAcademia.FormularioPlan
{
    public partial class AgregarForm : Form
    {
        public AgregarForm()
        {
            InitializeComponent();
            CargarEspecialidad();
        }

        private async void CargarEspecialidad()
        {
            var especialidades = await EspecialidadServicios.Get();
            txtEspecialidad.DataSource = especialidades;
            txtEspecialidad.DisplayMember = "descEspecialidad"; // Establece la propiedad que se mostrará en el ComboBox
            txtEspecialidad.ValueMember = "idEspecialidad"; // Establece la propiedad que se utilizará como valor seleccionado
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                return false; // Al menos uno de los campos está vacío o en blanco.
            }


            return true; // Todos los campos son válidos.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Recopilar los datos
            if (ValidarCampos())
            {
                //Crear nueva persona
                Plan nuevoPlan = new Plan()
                {

                    Descripcion = txtDescripcion.Text,
                    IdEspecialidad = (int)txtEspecialidad.SelectedValue,
                };
                await PlanServicios.Create(nuevoPlan);
                this.Close();
            }
            else
            {
                MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
