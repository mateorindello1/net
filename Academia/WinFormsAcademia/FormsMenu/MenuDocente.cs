using Entidades;
using WinFormsAcademia.Servicios;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.text;
using PdfiumViewer;
using System.Windows.Forms;
using System.Diagnostics;
using WinFormsAcademia.FormularioPersona;
using WinFormsAcademia.FormularioCursosDocente;

namespace WinFormsAcademia
{
    public partial class MenuDocente : Form
    {
        private Persona docente;
        public MenuDocente(Persona persona)
        {
            InitializeComponent();
            this.docente = persona;
            this.lblBienvenido.Text = $"Bienvenido, {persona.Nombre} {persona.Apellido}";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void MenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.Retry)
            {
                var login = new Login();
                login.MdiParent = this.MdiParent;
                login.StartPosition = FormStartPosition.Manual;
                login.Location = new Point(
                    MdiParent.Location.X + (MdiParent.Width - login.Width) / 2,
                    MdiParent.Location.Y + (MdiParent.Height - login.Height) / 2
                );
                this.Dispose();
                login.Show();
            }
        }

        private async void btnInscribirse_Click(object sender, EventArgs e)
        {
            List<Curso> lista = await CursoServicios.GetByDocente(docente.Legajo);
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = $"Cursos_{docente.Nombre}-{docente.Apellido}_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            guardar.Filter = "Archivos pdf (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            //guardar.ShowDialog();
            string paginahtml_text = Properties.Resources.Plantilla.ToString();
            paginahtml_text = paginahtml_text.Replace("@nombre_usuario", docente.NombreUsuario);
            paginahtml_text = paginahtml_text.Replace("@nombreapellido", docente.Apellido + ", " + docente.Nombre);
            paginahtml_text = paginahtml_text.Replace("@fecha", DateTime.Now.ToString("dd/MM/yyyy"));
            paginahtml_text = paginahtml_text.Replace("<meta charset=\"UTF-8\">", "<meta charset=\"UTF-8\"></meta>");

            string filas = string.Empty;
            foreach (Curso c in lista)
            {
                var materia = await MateriaServicios.GetOne(c.IdMateria);
                var comision = await ComisionServicios.GetOne(c.IdComision,c.IdPlan,c.IdMateria);
                filas += "<tr>";
                filas += "<td>" + c.Anio.ToString() + "</td>";
                filas += "<td>" + materia.Nombre + "</td>";
                filas += "<td>" + comision.Descripcion + "</td>";
                filas += "<td>" + c.Cupo.ToString() + "</td>";
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

        private void btnCursos_Click(object sender, EventArgs e)
        {
            mostrarForm(new FormCursosDocente(docente));
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {

        }
        private void mostrarForm(Form form)
        {
            this.Hide();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                MdiParent.Location.X + (MdiParent.Width - form.Width) / 2,
                MdiParent.Location.Y + (MdiParent.Height - form.Height) / 2
            );
            form.ShowDialog();
            this.Show();
        }
    }
}