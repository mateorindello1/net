using WebApi.Models;
using WinFormsABM.Services;

namespace WinFormsABM
{
    public partial class AlumnosView : Form
    {
        private List<Alumno> Alumnos;
        private string filtroApellidoAlumno = "";
        public AlumnosView()
        {
            InitializeComponent();
            Alumnos = new List<Alumno>();
            lblError.Text = "";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await this.List();
        }
        private async Task List()
        {
            Alumnos = await AlumnoService.Get(filtroApellidoAlumno);
            dataGridView1.DataSource = Alumnos;
            if (dataGridView1.Rows.Count == 0)
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                lblError.Visible = true;
                if (filtroApellidoAlumno != "") lblError.Text = "No se encontraron Alumnos.";
            }
            else
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                lblError.Visible = false;
                lblError.Text = "";
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedLegajo = int.Parse(dataGridView1.SelectedRows[0].Cells["Legajo"].Value.ToString());
            var Alumno = await AlumnoService.GetOne(selectedLegajo);
            if (Alumno != null)
            {
                var form2 = new AlumnoCreateUpdateView(Alumno);
                form2.ShowDialog();
                await this.List();
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedLegajo = int.Parse(dataGridView1.SelectedRows[0].Cells["Legajo"].Value.ToString());
            var alumno = new Alumno(0,dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString(), 
                                    dataGridView1.SelectedRows[0].Cells["Apellido"].Value.ToString(),
                                    selectedLegajo,
                                    dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString());
            string cadena = $"¿Desea eliminar al siguente Alumno?\nApellido y nombre: {alumno.Apellido}, {alumno.Nombre}\nLegajo {alumno.Legajo}";

            DialogResult resultado = MessageBox.Show(cadena, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                var legajo = await AlumnoService.Delete(selectedLegajo);
                if (legajo==0)
                {
                    MessageBox.Show("No se pudo eliminar el Alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Alumno eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await this.List();
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var form2 = new AlumnoCreateUpdateView();
            form2.ShowDialog();
            await this.List();
        }

        private async void textBox1_Leave(object sender, EventArgs e)
        {
            filtroApellidoAlumno = textBox1.Text;
            await this.List();
        }
    }
}