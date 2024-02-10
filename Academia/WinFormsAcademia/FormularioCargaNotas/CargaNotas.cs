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
using WinFormsAcademia.Servicios;

namespace WinFormsAcademia.FormularioCargaNotas
{
    public partial class CargaNotas : Form
    {
        private Persona docente;
        public CargaNotas(Persona docente)
        {
            InitializeComponent();
            this.docente = docente;
        }

        async private void List()
        {
            var cursos = await CursoServicios.Get();
            var dictados = await DictadoServicios.Get();
            dictados = dictados.Where(dictado => dictado.IdDocente == this.docente.Legajo).ToList();
            cursos = cursos.Where(curso => dictados
                .Any(dictado =>
                    dictado.IdComision == curso.IdComision &&
                    dictado.IdPlan == curso.IdPlan &&
                    dictado.IdMateria == curso.IdMateria &&
                    dictado.Anio == curso.Anio)
            ).ToList();

            dgvCursos.DataSource = cursos;
        }
        async private void dgvCursos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count > 0)
            {
                var idComision = (int)dgvCursos.SelectedRows[0].Cells["IdComision"].Value;
                var idPlan = (int)dgvCursos.SelectedRows[0].Cells["IdPlan"].Value;
                var idMateria = (int)dgvCursos.SelectedRows[0].Cells["IdMateria"].Value;
                var anio = (int)dgvCursos.SelectedRows[0].Cells["Anio"].Value;
                var inscripciones = await InscripcionServicios.Get();
                inscripciones = inscripciones.Where(inscripcion =>
                    inscripcion.IdComision == idComision &&
                    inscripcion.IdPlan == idPlan &&
                    inscripcion.IdMateria == idMateria &&
                    inscripcion.Anio == anio &&
                    inscripcion.Nota == null
                ).ToList();
                var alumnos = await PersonaServicios.Get(0);
                alumnos = alumnos.Where(alumno =>
                    inscripciones.Any(inscripcion => alumno.Legajo == inscripcion.IdAlumno)
                ).ToList();
                cmbAlumno.DataSource = null;
                cmbAlumno.DataSource = alumnos;
                cmbAlumno.DisplayMember = "Legajo";
                cmbAlumno.ValueMember = "Legajo";
                cmbAlumno.SelectedValue = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargaNotas_Load(object sender, EventArgs e)
        {
            this.List();
        }

        private void cmbAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAlumno.SelectedValue == null)
            {
                btnAgregar.Enabled = false;
            }
            else btnAgregar.Enabled = true;
        }

        async private void btnAgregar_Click(object sender, EventArgs e)
        {
            var alumno = await PersonaServicios.GetOne((int)cmbAlumno.SelectedValue, 0);
            var inscripcion = await InscripcionServicios.GetOne((int)alumno.Legajo, (int)dgvCursos.SelectedRows[0].Cells["IdComision"].Value, (int)dgvCursos.SelectedRows[0].Cells["IdPlan"].Value, (int)dgvCursos.SelectedRows[0].Cells["IdMateria"].Value, (int)dgvCursos.SelectedRows[0].Cells["Anio"].Value);
            inscripcion.Nota = (int)numNota.Value;
            if (inscripcion.Nota >= 6)
            {
                inscripcion.Condicion = "Aprobado";
            }
            else
            {
                inscripcion.Condicion = "Recursa";
            }

            ResumenNota resumenNotaForm = new ResumenNota(alumno, inscripcion);
            resumenNotaForm.Show();
            this.List();
        }
    }
}
