using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAcademia.FormularioInscripcion;
using WinFormsAcademia.Servicios;

namespace WinFormsAcademia.FormsMenu
{
    public partial class InscripcionCursoAlumno : Form
    {
        private Persona alumno = null;
        public InscripcionCursoAlumno(Persona alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
        }


        private void btn_vovler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        async private void InscripcionCursoAlumno_Load(object sender, EventArgs e)
        {
            var cursos = await CursoServicios.Get(this.alumno.IdPlan);
            var inscripciones = await InscripcionServicios.Get();
            inscripciones = inscripciones.Where(inscripcion => inscripcion.IdAlumno == this.alumno.Legajo).ToList();
            var materiasIds = inscripciones.Select(inscripcion => inscripcion.IdMateria).ToList();

            cursos = cursos.Where(curso => !materiasIds.Contains(curso.IdMateria) && curso.Cupo>0).ToList();

            dvgCursos.DataSource = cursos;
            dvgCursos.Columns["Dictados"].Visible = false;
            dvgCursos.Columns["Id"].Visible = false;
            dvgCursos.Columns["Inscripciones"].Visible = false;
            if (dvgCursos.Rows.Count == 0)
            {
                btnInscribirse.Enabled = false;
            }
            else
            {
                btnInscribirse.Enabled = true;
            }
        }

        async private void btnInscribirse_Click(object sender, EventArgs e)
        {
            if (dvgCursos.SelectedRows.Count > 0)
            {
                int idComision = Int32.Parse(dvgCursos.SelectedRows[0].Cells["IdComision"].Value.ToString());
                int idPlan = Int32.Parse(dvgCursos.SelectedRows[0].Cells["IdPlan"].Value.ToString());
                int idMateria = Int32.Parse(dvgCursos.SelectedRows[0].Cells["IdMateria"].Value.ToString());
                int anio = Int32.Parse(dvgCursos.SelectedRows[0].Cells["Anio"].Value.ToString());
                Curso curso = await CursoServicios.GetOne(idComision, idPlan, idMateria, anio);
                curso.Cupo -= 1;
                await CursoServicios.Update(curso);

                Inscripcion inscripcion = new Inscripcion();
                inscripcion.IdAlumno = this.alumno.Legajo;
                inscripcion.IdComision = idComision;
                inscripcion.IdPlan = idPlan;
                inscripcion.IdMateria = idMateria;
                inscripcion.Anio = anio;
                inscripcion.Condicion = "Inscripto";

                await InscripcionServicios.Create(inscripcion);

                InscripcionCorrecta inscripcionCorrecta = new InscripcionCorrecta(inscripcion);
                inscripcionCorrecta.Show();

                this.Close();
            }
        }
    }
}
