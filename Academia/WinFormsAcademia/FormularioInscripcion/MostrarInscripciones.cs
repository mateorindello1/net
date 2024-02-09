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

namespace WinFormsAcademia.FormularioInscripcion
{
    public partial class MostrarInscripciones : Form
    {
        private Persona alumno = null;
        public MostrarInscripciones(Persona alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void List()
        {
            var inscripciones = await InscripcionServicios.Get();
            if (cmbMateria.SelectedValue is not null && int.TryParse(cmbMateria.SelectedValue.ToString(), out int selectedMateria) && selectedMateria != 0)
            {
                if (cmbComision.SelectedValue is not null && int.TryParse(cmbComision.SelectedValue.ToString(), out int selectedComision) && selectedComision != 0)
                {
                    inscripciones = inscripciones.Where(inscripcion => inscripcion.IdAlumno == this.alumno.Legajo && inscripcion.IdMateria == selectedMateria && inscripcion.IdComision == selectedComision).ToList();
                }
                else inscripciones = inscripciones.Where(inscripcion => inscripcion.IdAlumno == this.alumno.Legajo && inscripcion.IdMateria == selectedMateria).ToList();
            }
            else inscripciones = inscripciones.Where(inscripcion => inscripcion.IdAlumno == this.alumno.Legajo).ToList();

            dgvInscripciones.DataSource = inscripciones;
        }

        async private void MostrarInscripciones_Load(object sender, EventArgs e)
        {
            await CargarMaterias(this.alumno.IdPlan);
            this.List();
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
            comisiones.AddRange(await ComisionServicios.Get(idPlan, idMateria));
            cmbComision.DataSource = comisiones;
            cmbComision.DisplayMember = "Descripcion";
            cmbComision.ValueMember = "IdComision";
            cmbComision.SelectedValue = 0;
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
                    await CargarComisiones((int)this.alumno.IdPlan, selectedMateria);
                }
                this.List();
            }
        }

        private void cmbComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.List();
        }
    }
}
