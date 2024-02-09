using Entidades;
using WinFormsAcademia.Servicios;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System.Diagnostics;

namespace WinFormsAcademia.FormularioPlan
{
    public partial class FormPlan : Form
    {
        private Persona administrador;
        public FormPlan(Persona persona)
        {
            InitializeComponent();
            administrador = persona;
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
            var editPlan = await PlanServicios.GetOne(planId);
            AgregarEditarPlan editar = new AgregarEditarPlan(editPlan);
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
                new Especialidad { IdEspecialidad = 0, Descripcion = "<Todas>" },
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<Plan> lista = await PlanServicios.Get();
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = $"Planes_{administrador.Nombre}-{administrador.Apellido}_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            guardar.Filter = "Archivos pdf (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            //guardar.ShowDialog();
            string paginahtml_text = Properties.Resources.PlantillaPlanes.ToString();
            paginahtml_text = paginahtml_text.Replace("@nombre_usuario", administrador.NombreUsuario);
            paginahtml_text = paginahtml_text.Replace("@nombreapellido", administrador.Apellido + ", " + administrador.Nombre);
            paginahtml_text = paginahtml_text.Replace("@fecha", DateTime.Now.ToString("dd/MM/yyyy"));
            paginahtml_text = paginahtml_text.Replace("<meta charset=\"UTF-8\">", "<meta charset=\"UTF-8\"></meta>");

            string filas = string.Empty;
            foreach (Plan p in lista)
            {
                var esp = await EspecialidadServicios.GetOne(p.IdEspecialidad);
                filas += "<tr>";
                filas += "<td>" + p.IdPlan + "</td>";
                filas += "<td>" + p.Descripcion + "</td>";
                filas += "<td>" + esp.Descripcion + "</td>";
                filas += "</tr>";
            }
            paginahtml_text = paginahtml_text.Replace("@filas", filas);

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.pngwing_com, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);
                    using (StringReader sr = new StringReader(paginahtml_text))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = guardar.FileName,
                        UseShellExecute = true
                    };

                    Process.Start(startInfo);
                }
            }
        }
    }
}
