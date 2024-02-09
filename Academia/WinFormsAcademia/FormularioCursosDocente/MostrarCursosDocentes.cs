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

namespace WinFormsAcademia.FormularioCursosDocente
{
    public partial class MostrarCursosDocentes : Form
    {
        private Persona docente;
        public MostrarCursosDocentes(Persona docente)
        {
            InitializeComponent();
            this.docente = docente;
        }

        private void MostrarCursosDocentes_Load(object sender, EventArgs e)
        {
            this.List();
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

            dgvInscripciones.DataSource = cursos;
        }
    }
}
