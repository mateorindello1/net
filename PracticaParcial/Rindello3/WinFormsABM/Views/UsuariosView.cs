using WebApi.Models;
using WinFormsABM.Services;

namespace WinFormsABM
{
    public partial class UsuariosView : Form
    {
        private List<Usuario> Usuarios;
        private string filtroUsuario = "";
        public UsuariosView()
        {
            InitializeComponent();
            Usuarios = new List<Usuario>();
            lblError.Text = "";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await this.List();
        }
        private async Task List()
        {
            Usuarios = await UsuarioService.Get(filtroUsuario);
            dataGridView1.DataSource = Usuarios;
            if (dataGridView1.Rows.Count == 0)
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                lblError.Visible = true;
                if (filtroUsuario != "") lblError.Text = "No se encontraron usuarios.";
            }
            else
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                lblError.Visible = false;
                lblError.Text = "";
                dataGridView1.Columns["Clave"].Visible = false;
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedId = dataGridView1.SelectedRows[0].Cells["NombreUsuario"].Value.ToString();
            var usuario = await UsuarioService.GetOne(selectedId);
            if (usuario != null)
            {
                var form2 = new UsuarioCreateUpdateView(usuario);
                form2.ShowDialog();
                await this.List();
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedId = dataGridView1.SelectedRows[0].Cells["NombreUsuario"].Value.ToString();
            DialogResult resultado = MessageBox.Show($"¿Desea eliminar al usuario {selectedId}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                var ok = await UsuarioService.Delete(selectedId);
                if (!ok)
                {
                    MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await this.List();
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var form2 = new UsuarioCreateUpdateView();
            form2.ShowDialog();
            await this.List();
        }

        private async void textBox1_Leave(object sender, EventArgs e)
        {
            filtroUsuario = textBox1.Text;
            await this.List();
        }
    }
}