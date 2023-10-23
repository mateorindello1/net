using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsABM.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            AlumnosView alumnosView = new AlumnosView();
            alumnosView.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            UsuariosView usuariosView = new UsuariosView();
            usuariosView.Show();
        }
    }
}
