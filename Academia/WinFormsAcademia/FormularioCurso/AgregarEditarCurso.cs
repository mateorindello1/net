using Entidades;
using WinFormsAcademia.Servicios;
using System.Text.RegularExpressions;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormsAcademia.FormularioCurso
{
    public partial class AgregarEditarCurso : Form
    {
        private Curso? cursoAEditar = null;
        private bool editMode = false;
        private List<int> legajoDocentes;
        private List<docenteCargo> docentesCargos;
        private List<Dictado> dictadosIniciales;
        public AgregarEditarCurso()
        {
            InitializeComponent();
            Text = "Agregar curso";
            legajoDocentes = new List<int>();
            docentesCargos = new List<docenteCargo>();
        }

        public class docenteCargo
        {
            public int legajo { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string cargo { get; set; }
        }
        public AgregarEditarCurso(Curso curso)
        {
            InitializeComponent();
            cursoAEditar = curso;
            legajoDocentes = new List<int>();
            docentesCargos = new List<docenteCargo>();
            dictadosIniciales = new List<Dictado>();
            editMode = true;
            Text = "Editar curso";
            cmbPlan.Enabled = false;
            cmbMateria.Enabled = false;
            cmbComision.Enabled = false;
            txtAnio.Enabled = false;
            btnGuardar.Text = "Guardar";
            btnReestablecer.Visible = true;
        }

        private async void Rellenar()
        {
            if (cursoAEditar is not null)
            {
                txtAnio.Text = cursoAEditar.Anio.ToString();
                nudCupo.Value = cursoAEditar.Cupo;
                await CargarPlanes();
                cargarDocentes();
            }
        }

        private async Task CargarPlanes()
        {
            // Obtiene los planes de la base de datos
            var planes = await PlanServicios.Get();
            var displayList = planes.Select(plan => new
            {
                DisplayText = $"ID: {plan.IdPlan} - {plan.Descripcion}",
                plan.IdPlan
            }).ToList();
            // Enlaza la lista de planes al ComboBox
            cmbPlan.DataSource = displayList;
            cmbPlan.DisplayMember = "DisplayText"; // Establece la propiedad que se mostrará en el ComboBox
            cmbPlan.ValueMember = "IdPlan"; // Establece la propiedad que se utilizará como valor seleccionado
            if (cmbPlan.Items.Count > 0)
            {
                cmbPlan.SelectedIndex = 0;
                if (editMode) cmbPlan.SelectedValue = cursoAEditar.IdPlan;
                await CargarMaterias();
            }
        }

        private async Task CargarMaterias()
        {
            // Obtiene las materias de la base de datos

            if (cmbPlan.SelectedValue is not null)
            {
                List<Materia> materias = new List<Materia>();
                int.TryParse(cmbPlan.SelectedValue.ToString(), out int selectedPlan);
                materias = await MateriaServicios.Get(selectedPlan);
                var displayList = materias.Select(materia => new
                {
                    DisplayText = $"ID: {materia.IdMateria} - {materia.Nombre}",
                    materia.IdMateria
                }).ToList();
                cmbMateria.DataSource = displayList;
                cmbMateria.DisplayMember = "DisplayText"; // Establece la propiedad que se mostrará en el ComboBox
                cmbMateria.ValueMember = "IdMateria"; // Establece la propiedad que se utilizará como valor seleccionado
                if (cmbMateria.Items.Count > 0)
                {
                    cmbMateria.SelectedIndex = 0;
                    if (editMode) cmbMateria.SelectedValue = cursoAEditar.IdMateria;
                    await CargarComisiones();
                }
            }
            // Enlaza la lista de materias al ComboBox
        }

        private async Task CargarComisiones()
        {
            // Obtiene las comisiones de la base de datos
            if (cmbPlan.SelectedValue is not null && cmbMateria.SelectedValue is not null)
            {
                List<Comision> comisiones = new List<Comision>();
                int.TryParse(cmbPlan.SelectedValue.ToString(), out int selectedPlan);
                int.TryParse(cmbMateria.SelectedValue.ToString(), out int selectedMateria);
                comisiones = await ComisionServicios.Get(selectedPlan, selectedMateria);
                var displayList = comisiones.Select(comision => new
                {
                    DisplayText = $"ID: {comision.IdComision} - {comision.Descripcion}",
                    comision.IdComision
                }).ToList();
                // Enlaza la lista de comisiones al ComboBox
                cmbComision.DataSource = comisiones;
                cmbComision.DisplayMember = "Descripcion"; // Establece la propiedad que se mostrará en el ComboBox
                cmbComision.ValueMember = "IdComision"; // Establece la propiedad que se utilizará como valor seleccionado
                if (cmbComision.Items.Count > 0)
                {
                    cmbComision.SelectedIndex = 0;
                    if (editMode) cmbComision.SelectedValue = cursoAEditar.IdComision;
                }
            }
        }

        private bool ValidarCampos()
        {
            if ((int)nudCupo.Value == 0 ||
                txtAnio.Text.Length < 2 ||
                cmbPlan.SelectedItem.ToString().Length < 1 ||
                cmbMateria.SelectedItem.ToString().Length < 1 ||
                cmbComision.SelectedItem.ToString().Length < 1 ||
                dgvDocentes.Rows.Count == 0)
            {
                return false; // Al menos uno de los campos está vacío o en blanco.
            }
            return true; // Todos los campos son válidos.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                List<Dictado> lista = new List<Dictado>();
                foreach (DataGridViewRow row in dgvDocentes.Rows)
                {
                    lista.Add(
                        new Dictado()
                        {
                            IdComision = (int)cmbComision.SelectedValue,
                            IdMateria = (int)cmbMateria.SelectedValue,
                            IdPlan = (int)cmbPlan.SelectedValue,
                            Anio = Int32.Parse(txtAnio.Text),
                            IdDocente = Int32.Parse(row.Cells["legajo"].Value.ToString()),
                            Cargo = row.Cells["cargo"].Value.ToString(),
                        });
                }
                Curso nuevoCurso = new Curso()
                {
                    IdComision = (int)cmbComision.SelectedValue,
                    IdMateria = (int)cmbMateria.SelectedValue,
                    IdPlan = (int)cmbPlan.SelectedValue,
                    Anio = Int32.Parse(txtAnio.Text),
                    Cupo = (int)nudCupo.Value,
                    Dictados = lista,
                };
                if (editMode)
                {
                    var ok = await CursoServicios.Update(nuevoCurso);
                    if (ok) 
                    {
                        await DictadoServicios.GroupDelete(dictadosIniciales);
                        var okCreate = await DictadoServicios.GroupCreate(nuevoCurso.Dictados.ToList());
                        this.Close();
                    }
                    else MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var cursoAdded = await CursoServicios.Create(nuevoCurso);
                    if (cursoAdded is not null) { this.Close(); }
                    else MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Completa todos los campos antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            Rellenar();

        }

        private void txtOnlyNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private async void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlan.SelectedValue is not null) await CargarMaterias();
        }

        private async void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlan.SelectedValue is not null && cmbMateria.SelectedValue is not null) await CargarComisiones();
        }

        private async void AgregarEditarCurso_Load(object sender, EventArgs e)
        {
            if (editMode) Rellenar();
            if (!editMode) CargarPlanes();
        }
        private async void cargarDocentes()
        {
            var dictados = await DictadoServicios.Get(cursoAEditar.IdPlan, cursoAEditar.IdMateria, cursoAEditar.IdComision, cursoAEditar.Anio);
            dictadosIniciales = dictados;
            if (dictados is not null)
            {
                foreach (Dictado d in dictados)
                {
                    docentesCargos.Add(
                        new docenteCargo()
                        {
                            legajo = d.IdDocenteNavigation.Legajo,
                            nombre = d.IdDocenteNavigation.Nombre,
                            apellido = d.IdDocenteNavigation.Apellido,
                            cargo = d.Cargo,
                        });
                }
                dgvDocentes.DataSource = docentesCargos;
                legajoDocentes = new List<int>(docentesCargos.Select(doc => doc.legajo));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarDocente form = new AgregarDocente(legajoDocentes);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                dgvDocentes.DataSource = null;
                docentesCargos.Add(
                        new docenteCargo()
                        {
                            legajo = form.docenteAGuardar.Legajo,
                            nombre = form.docenteAGuardar.Nombre,
                            apellido = form.docenteAGuardar.Apellido,
                            cargo = form.cargo,
                        });
                dgvDocentes.DataSource =docentesCargos;
            }
            form.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var docenteAEliminar = dgvDocentes.SelectedRows[0].DataBoundItem as docenteCargo;
            docentesCargos.Remove(docenteAEliminar);
            legajoDocentes.Remove(docenteAEliminar.legajo);
            dgvDocentes.DataSource = null;
            if (docentesCargos.Count > 0) dgvDocentes.DataSource = docentesCargos;
        }
    }
}
