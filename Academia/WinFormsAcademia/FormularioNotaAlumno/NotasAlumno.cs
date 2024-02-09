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

namespace WinFormsAcademia.FormularioNotaAlumno
{
    public partial class NotasAlumno : Form
    {
        Persona alumno;
        public NotasAlumno(Persona alumno)
        {
            this.alumno = alumno;
            InitializeComponent();
        }

        async private void NotasAlumno_Load(object sender, EventArgs e)
        {
            var inscripciones = await InscripcionServicios.Get();
            inscripciones = inscripciones.Where(inscripcion => inscripcion.IdAlumno == this.alumno.Legajo).ToList();
            dgvNotas.DataSource = inscripciones;
            dgvNotas.Columns["Curso"].Visible = false;
            dgvNotas.Columns["IdAlumnoNavigation"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
