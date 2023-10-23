namespace WinFormsABM
{
    partial class UsuarioCreateUpdateView
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
            btnOk = new Button();
            btnCancel = new Button();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            lblPassword = new Label();
            txtTipo = new TextBox();
            labelTipo = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            label1 = new Label();
            label2 = new Label();
            btnReset = new Button();
            lblTitulo = new Label();
            lblError = new Label();
            chkPassword = new CheckBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(317, 105);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(97, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Aceptar";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(317, 165);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(11, 83);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(100, 79);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(153, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(100, 138);
            txtClave.MaxLength = 20;
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(153, 23);
            txtClave.TabIndex = 4;
            txtClave.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(11, 142);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(36, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Clave";
            lblPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(100, 193);
            txtTipo.MaxLength = 1;
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(153, 23);
            txtTipo.TabIndex = 6;
            txtTipo.KeyPress += txtTipo_KeyPress;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(11, 196);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(73, 15);
            labelTipo.TabIndex = 7;
            labelTipo.Text = "Tipo Usuario";
            labelTipo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 249);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(153, 23);
            txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(11, 252);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(43, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Correo";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(100, 164);
            label1.Name = "label1";
            label1.Size = new Size(153, 13);
            label1.TabIndex = 10;
            label1.Text = "4-20 caract. Números y letras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(100, 105);
            label2.Name = "label2";
            label2.Size = new Size(153, 13);
            label2.TabIndex = 11;
            label2.Text = "8-20 caract. Números y letras";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(317, 223);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(97, 23);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reestablecer";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(100, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(60, 25);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "titulo";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.DarkRed;
            lblError.Location = new Point(46, 306);
            lblError.Name = "lblError";
            lblError.Size = new Size(32, 15);
            lblError.TabIndex = 14;
            lblError.Text = "Error";
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            chkPassword.Location = new Point(259, 142);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(57, 16);
            chkPassword.TabIndex = 15;
            chkPassword.Text = "Mostrar";
            chkPassword.UseVisualStyleBackColor = true;
            chkPassword.CheckedChanged += chkPassword_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 359);
            Controls.Add(chkPassword);
            Controls.Add(lblError);
            Controls.Add(lblTitulo);
            Controls.Add(btnReset);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(labelTipo);
            Controls.Add(txtTipo);
            Controls.Add(lblPassword);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label lblPassword;
        private TextBox txtTipo;
        private Label labelTipo;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label label1;
        private Label label2;
        private Button btnReset;
        private Label lblTitulo;
        private Label lblError;
        private CheckBox chkPassword;
    }
}