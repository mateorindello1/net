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
    public partial class UsuarioCreateUpdateView : Form
    {
        private Usuario? usuario;
        public UsuarioCreateUpdateView()
        {
            InitializeComponent();
            lblTitulo.Text = "Alta de usuario";
            lblError.Text = "";
            lblError.Visible = false;
            btnReset.Visible = false;
        }

        public UsuarioCreateUpdateView(Usuario user)
        {
            InitializeComponent();
            lblTitulo.Text = "Modificar usuario";
            lblError.Text = "";
            lblError.Visible = false;
            this.usuario = user;
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
                var us = new Usuario(txtUsuario.Text, txtClave.Text, int.Parse(txtTipo.Text), txtEmail.Text);
                if (usuario is not null)
                {
                    if (!us.SameFields(usuario))
                    {
                        var ok = await UsuarioService.Update(us);
                        if (!ok) MessageBox.Show("No se pudo guardar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var createdUser = await UsuarioService.Create(us);
                    if (createdUser is null) MessageBox.Show("No se pudo guardar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtClave.Text.Length < 4) return false;
            if (txtUsuario.Text.Length < 5) return false;
            if (!ValidarEmail(txtEmail.Text)) return false;
            if (txtTipo.Text.Length == 0) return false;
            return true;
        }

        private void completeFields()
        {
            txtUsuario.Text = usuario.NombreUsuario;
            txtUsuario.Enabled = false;
            txtClave.Text = usuario.Clave;
            txtTipo.Text = usuario.TipoUsuario.ToString();
            txtEmail.Text = usuario.Email;
        }
        private bool ValidarEmail(string email)
        {
            if (email.Length == 0) return false;
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, patron);
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            completeFields();
        }

        private async void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length > 0 && await UsuarioService.GetOne(txtUsuario.Text) is not null)
            {
                btnOk.Enabled = false;
                lblError.Text = "El nombre de usuario no está disponible";
                lblError.Visible = true;
            }
            else
            {
                lblError.Text = "";
                lblError.Visible = false;
                btnOk.Enabled = true;
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = !chkPassword.Checked;
        }
    }
}
