namespace WinFormsABM
{
    partial class AlumnoCreateUpdateView
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtCorreo = new TextBox();
            lblEmail = new Label();
            btnReset = new Button();
            lblTitulo = new Label();
            lblError = new Label();
            lblLegajo = new Label();
            txtLegajo = new TextBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(312, 103);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(97, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Aceptar";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(312, 163);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 137);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(153, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(11, 141);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(100, 192);
            txtApellido.MaxLength = 20;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(153, 23);
            txtApellido.TabIndex = 6;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(11, 195);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido";
            lblApellido.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(100, 248);
            txtCorreo.MaxLength = 50;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(153, 23);
            txtCorreo.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(11, 251);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(43, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Correo";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(312, 221);
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
            lblError.Location = new Point(43, 308);
            lblError.Name = "lblError";
            lblError.Size = new Size(32, 15);
            lblError.TabIndex = 14;
            lblError.Text = "Error";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(11, 85);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(42, 15);
            lblLegajo.TabIndex = 15;
            lblLegajo.Text = "Legajo";
            lblLegajo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(100, 82);
            txtLegajo.MaxLength = 50;
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(153, 23);
            txtLegajo.TabIndex = 16;
            txtLegajo.KeyPress += txtNumeric_KeyPress;
            txtLegajo.Leave += txtLegajo_Leave;
            // 
            // AlumnoCreateUpdateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 345);
            Controls.Add(txtLegajo);
            Controls.Add(lblLegajo);
            Controls.Add(lblError);
            Controls.Add(lblTitulo);
            Controls.Add(btnReset);
            Controls.Add(lblEmail);
            Controls.Add(txtCorreo);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Name = "AlumnoCreateUpdateView";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtCorreo;
        private Label lblEmail;
        private Button btnReset;
        private Label lblTitulo;
        private Label lblError;
        private Label lblLegajo;
        private TextBox txtLegajo;
    }
}