namespace WinFormsAcademia.FormularioPersona
{
    partial class AgregarEditarPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            cmbPlan = new ComboBox();
            groupBox1 = new GroupBox();
            lblErrorEmail = new Label();
            label1 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            chkPass = new CheckBox();
            pictureBox1 = new PictureBox();
            lblErrUser = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label11 = new Label();
            label10 = new Label();
            groupBoxTipoUsuario = new GroupBox();
            cmbTipo = new ComboBox();
            lblId = new Label();
            txtId = new TextBox();
            button3 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxTipoUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbPlan);
            groupBox2.Location = new Point(378, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 75);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Plan de estudio";
            groupBox2.Visible = false;
            // 
            // cmbPlan
            // 
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Items.AddRange(new object[] { "2008", "2016", "2023" });
            cmbPlan.Location = new Point(36, 30);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(209, 23);
            cmbPlan.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblErrorEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(25, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 205);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorEmail.ForeColor = Color.IndianRed;
            lblErrorEmail.Location = new Point(86, 176);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(205, 13);
            lblErrorEmail.TabIndex = 0;
            lblErrorEmail.Text = "Por favor, ingrese un e-mail válido";
            lblErrorEmail.TextAlign = ContentAlignment.MiddleCenter;
            lblErrorEmail.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 95);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 0;
            label3.Text = "Direccion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 35);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(183, 23);
            txtNombre.TabIndex = 3;
            txtNombre.KeyPress += txtOnlyAlpha_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(96, 92);
            txtDireccion.MaxLength = 50;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(183, 23);
            txtDireccion.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 66);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Apellido";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(96, 121);
            txtTelefono.MaxLength = 20;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(183, 23);
            txtTelefono.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 153);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(96, 63);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(183, 23);
            txtApellido.TabIndex = 4;
            txtApellido.KeyPress += txtOnlyAlpha_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(96, 150);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 7;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 124);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 0;
            label7.Text = "Telefono";
            // 
            // button2
            // 
            button2.Location = new Point(554, 327);
            button2.Name = "button2";
            button2.Size = new Size(108, 35);
            button2.TabIndex = 13;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(378, 328);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 12;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkPass);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(lblErrUser);
            groupBox3.Controls.Add(txtContraseña);
            groupBox3.Controls.Add(txtUsuario);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(25, 57);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(313, 130);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Autenticación";
            // 
            // chkPass
            // 
            chkPass.AutoSize = true;
            chkPass.Location = new Point(285, 89);
            chkPass.Name = "chkPass";
            chkPass.Size = new Size(15, 14);
            chkPass.TabIndex = 3;
            chkPass.TextAlign = ContentAlignment.MiddleCenter;
            chkPass.UseVisualStyleBackColor = true;
            chkPass.CheckedChanged += chkPass_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.mostrar_contrasena;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(281, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblErrUser
            // 
            lblErrUser.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrUser.ForeColor = Color.IndianRed;
            lblErrUser.Location = new Point(96, 56);
            lblErrUser.Name = "lblErrUser";
            lblErrUser.Size = new Size(181, 15);
            lblErrUser.TabIndex = 0;
            lblErrUser.Text = "Nombre de usuario no disponible";
            lblErrUser.TextAlign = ContentAlignment.MiddleCenter;
            lblErrUser.Visible = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(96, 84);
            txtContraseña.MaxLength = 20;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "4-20 caracteres [a-Z] [0-9] y [-_.]";
            txtContraseña.Size = new Size(183, 23);
            txtContraseña.TabIndex = 2;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(96, 30);
            txtUsuario.MaxLength = 20;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "4-20 caracteres [a-Z] [0-9] y [-_.]";
            txtUsuario.Size = new Size(183, 23);
            txtUsuario.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 87);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 1;
            label11.Text = "Contraseña";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 33);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 0;
            label10.Text = "Usuario";
            // 
            // groupBoxTipoUsuario
            // 
            groupBoxTipoUsuario.Controls.Add(cmbTipo);
            groupBoxTipoUsuario.Location = new Point(378, 101);
            groupBoxTipoUsuario.Name = "groupBoxTipoUsuario";
            groupBoxTipoUsuario.Size = new Size(284, 78);
            groupBoxTipoUsuario.TabIndex = 0;
            groupBoxTipoUsuario.TabStop = false;
            groupBoxTipoUsuario.Text = "Tipo de Usuario";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Alumno", "Docente", "Administrador" });
            cmbTipo.Location = new Point(36, 34);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(209, 23);
            cmbTipo.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(48, 25);
            lblId.Name = "lblId";
            lblId.Size = new Size(46, 15);
            lblId.TabIndex = 72;
            lblId.Text = "Legajo:";
            lblId.Visible = false;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(97, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(94, 23);
            txtId.TabIndex = 0;
            txtId.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(515, 17);
            button3.Name = "button3";
            button3.Size = new Size(132, 31);
            button3.TabIndex = 14;
            button3.Text = "Reestablecer datos";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // AgregarEditarPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 443);
            Controls.Add(button3);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(groupBoxTipoUsuario);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AgregarEditarPersona";
            Text = "Agregar/editar persona";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxTipoUsuario.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox cmbPlan;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Label label2;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private Label label7;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label11;
        private Label label10;
        private GroupBox groupBoxTipoUsuario;
        private Label lblId;
        private TextBox txtId;
        private Button button3;
        private Label lblErrUser;
        private Label lblErrorEmail;
        private ComboBox cmbTipo;
        private CheckBox chkPass;
        private PictureBox pictureBox1;
    }
}