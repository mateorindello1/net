namespace WinFormsABM.Views
{
    partial class MainView
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
            lblTitulo = new Label();
            btnUsuario = new Button();
            btnAlumno = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(72, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(292, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ABM de Usuarios y Alumnos";
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(72, 92);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(75, 23);
            btnUsuario.TabIndex = 1;
            btnUsuario.Text = "Usuarios";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnAlumno
            // 
            btnAlumno.Location = new Point(289, 92);
            btnAlumno.Name = "btnAlumno";
            btnAlumno.Size = new Size(75, 23);
            btnAlumno.TabIndex = 2;
            btnAlumno.Text = "Alumnos";
            btnAlumno.UseVisualStyleBackColor = true;
            btnAlumno.Click += btnAlumno_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 228);
            Controls.Add(btnAlumno);
            Controls.Add(btnUsuario);
            Controls.Add(lblTitulo);
            Name = "MainView";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnUsuario;
        private Button btnAlumno;
    }
}