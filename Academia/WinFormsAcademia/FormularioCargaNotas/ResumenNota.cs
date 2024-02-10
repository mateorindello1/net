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
    public partial class ResumenNota : Form
    {
        private Persona alumno;
        private Inscripcion inscripcion;
        public ResumenNota(Persona alumno, Inscripcion inscripcion)
        {
            this.alumno = alumno;
            this.inscripcion = inscripcion;
            InitializeComponent();
        }

        private void ResumenNota_Load(object sender, EventArgs e)
        {
            txtApellido.Text = alumno.Apellido;
            txtComision.Text = inscripcion.IdComision.ToString();
            txtLegajo.Text = alumno.Legajo.ToString();
            txtMateria.Text = inscripcion.IdMateria.ToString();
            txtNombre.Text = alumno.Nombre;
            txtNota.Text = inscripcion.Nota.ToString();
            txtCondicion.Text = inscripcion.Condicion;
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            await InscripcionServicios.Update(inscripcion);
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
