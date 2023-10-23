using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApi.Models;
using WinFormsABM.Services;

namespace WinFormsABM
{
    public partial class AlumnoCreateUpdateView : Form
    {
        private Alumno? Alumno;
        public AlumnoCreateUpdateView()
        {
            InitializeComponent();
            lblTitulo.Text = "Alta de Alumno";
            lblError.Text = "";
            lblError.Visible = false;
            btnReset.Visible = false;
        }

        public AlumnoCreateUpdateView(Alumno user)
        {
            InitializeComponent();
            lblTitulo.Text = "Modificar Alumno";
            lblError.Text = "";
            lblError.Visible = false;
            this.Alumno = user;
            completeFields();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateControls())
            {
                lblError.Text = "Por favor, ingrese datos válidos";
                lblError.Visible = true;
            }
            else
            {
                var us = new Alumno(int.Parse(txtLegajo.Text), txtNombre.Text, txtApellido.Text, txtCorreo.Text);
                if (Alumno is not null)
                {
                    if (!us.Equals(Alumno))
                    {
                        var legajo = await AlumnoService.Update(us);
                        if (legajo == 0) MessageBox.Show("No se pudo guardar el Alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var createdUser = await AlumnoService.Create(us);
                    if (createdUser is null) MessageBox.Show("No se pudo guardar el Alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidateControls()
        {
            if (txtNombre.Text.Length == 0) return false;
            if (txtLegajo.Text.Length == 0) return false;
            if (!ValidarEmail(txtCorreo.Text)) return false;
            if (txtApellido.Text.Length == 0) return false;
            return true;
        }

        private void completeFields()
        {
            txtLegajo.Text = Alumno.Legajo.ToString();
            txtLegajo.Enabled = false;
            txtNombre.Text = Alumno.Nombre;
            txtApellido.Text = Alumno.Apellido;
            txtCorreo.Text = Alumno.Email;
        }
        private bool ValidarEmail(string email)
        {
            if (email.Length == 0) return false;
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, patron);
        }

        private void txtNombreApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            completeFields();
        }

        private async void txtLegajo_Leave(object sender, EventArgs e)
        {
            if (txtLegajo.Text.Length > 0 && await AlumnoService.GetOne(int.Parse(txtLegajo.Text)) is not null)
            {
                btnOk.Enabled = false;
                lblError.Text = "El legajo no está disponible";
                lblError.Visible = true;
            }
            else
            {
                lblError.Text = "";
                lblError.Visible = false;
                btnOk.Enabled = true;
            }
        }

        private void txtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
