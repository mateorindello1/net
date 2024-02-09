using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using MessagePack.Formatters;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using WinFormsAcademia.Servicios;

namespace WinFormsAcademia.FormularioInscripcion
{
    public partial class InscripcionCorrecta : Form
    {
        string descMateria;
        public InscripcionCorrecta(Inscripcion inscripcion)
        {
            InitializeComponent();

            txtCondicion.Text = inscripcion.Condicion;
            txtLegajo.Text = inscripcion.IdAlumno.ToString();
            GetMateria(inscripcion.IdMateria);
            GetPlan(inscripcion.IdPlan);
        }

        public async void GetMateria(int idMateria)
        {
            Materia materia = new Materia();
            materia = await MateriaServicios.GetOne(idMateria);
            txtMateria.Text = materia.Descripcion;
        }

        public async void GetPlan(int idPlan)
        {
            Plan plan = new Plan();
            plan = await PlanServicios.GetOne(idPlan);
            txtPlan.Text = plan.Descripcion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
