namespace WinFormsAcademia
{
    partial class MenuAlumno
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            groupBox2 = new GroupBox();
            btnMostrarInscripciones = new Button();
            btnNotas = new Button();
            btnInscribirse = new Button();
            button3 = new Button();
            btnExit = new Button();
            lblBienvenido = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(703, 57);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Menú alumno";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMostrarInscripciones);
            groupBox2.Controls.Add(btnNotas);
            groupBox2.Controls.Add(btnInscribirse);
            groupBox2.Location = new Point(12, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(703, 312);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btnMostrarInscripciones
            // 
            btnMostrarInscripciones.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMostrarInscripciones.Location = new Point(254, 129);
            btnMostrarInscripciones.Name = "btnMostrarInscripciones";
            btnMostrarInscripciones.Size = new Size(200, 44);
            btnMostrarInscripciones.TabIndex = 4;
            btnMostrarInscripciones.Text = "Mis inscripciones";
            btnMostrarInscripciones.UseVisualStyleBackColor = true;
            btnMostrarInscripciones.Click += btnMostrarInscripciones_Click;
            // 
            // btnNotas
            // 
            btnNotas.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNotas.Location = new Point(251, 201);
            btnNotas.Name = "btnNotas";
            btnNotas.Size = new Size(200, 44);
            btnNotas.TabIndex = 2;
            btnNotas.Text = "Mis notas";
            btnNotas.UseVisualStyleBackColor = true;
            btnNotas.Click += btnNotas_Click;
            // 
            // btnInscribirse
            // 
            btnInscribirse.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscribirse.Location = new Point(254, 59);
            btnInscribirse.Name = "btnInscribirse";
            btnInscribirse.Size = new Size(200, 44);
            btnInscribirse.TabIndex = 0;
            btnInscribirse.Text = "Inscripción a cursos";
            btnInscribirse.UseVisualStyleBackColor = true;
            btnInscribirse.Click += btnInscribirse_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(243, 429);
            button3.Name = "button3";
            button3.Size = new Size(118, 26);
            button3.TabIndex = 7;
            button3.Text = "Cerrar Sesión";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnExit
            // 
            btnExit.DialogResult = DialogResult.Abort;
            btnExit.FlatAppearance.BorderColor = Color.Black;
            btnExit.Font = new Font("Bahnschrift SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(367, 429);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 26);
            btnExit.TabIndex = 8;
            btnExit.Text = "Salir";
            btnExit.Click += btnExit_Click;
            // 
            // lblBienvenido
            // 
            lblBienvenido.BorderStyle = BorderStyle.Fixed3D;
            lblBienvenido.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBienvenido.Location = new Point(12, 399);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(703, 23);
            lblBienvenido.TabIndex = 9;
            lblBienvenido.Text = "Bienvenido, nombre y apellido";
            lblBienvenido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(727, 470);
            Controls.Add(lblBienvenido);
            Controls.Add(btnExit);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuAlumno";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ACADEMIA";
            FormClosed += MenuAdmin_FormClosed;
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private GroupBox groupBox2;
        private Button btnInscribirse;
        private Button button3;
        private Button btnExit;
        private Button btnNotas;
        private Label lblBienvenido;
        private Button btnMostrarInscripciones;
    }
}