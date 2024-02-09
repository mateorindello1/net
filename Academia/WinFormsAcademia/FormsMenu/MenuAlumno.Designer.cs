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
            btnNotas = new Button();
            btnCursos = new Button();
            btnInscribirse = new Button();
            button3 = new Button();
            button8 = new Button();
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
            groupBox2.Controls.Add(btnNotas);
            groupBox2.Controls.Add(btnCursos);
            groupBox2.Controls.Add(btnInscribirse);
            groupBox2.Location = new Point(12, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(687, 312);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btnNotas
            // 
            btnNotas.Location = new Point(251, 201);
            btnNotas.Name = "btnNotas";
            btnNotas.Size = new Size(200, 44);
            btnNotas.TabIndex = 2;
            btnNotas.Text = "Mis notas";
            btnNotas.UseVisualStyleBackColor = true;
            btnNotas.Click += btnNotas_Click;
            // 
            // btnCursos
            // 
            btnCursos.Location = new Point(251, 129);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(200, 44);
            btnCursos.TabIndex = 1;
            btnCursos.Text = "Mis inscripciones";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // btnInscribirse
            // 
            btnInscribirse.Location = new Point(251, 59);
            btnInscribirse.Name = "btnInscribirse";
            btnInscribirse.Size = new Size(200, 44);
            btnInscribirse.TabIndex = 0;
            btnInscribirse.Text = "Inscripción a cursos";
            btnInscribirse.UseVisualStyleBackColor = true;
            btnInscribirse.Click += btnInscribirse_Click;
            // 
            // button3
            // 
            button3.Location = new Point(263, 407);
            button3.Name = "button3";
            button3.Size = new Size(96, 23);
            button3.TabIndex = 7;
            button3.Text = "Cerrar Sesión";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button8
            // 
            button8.DialogResult = DialogResult.Abort;
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.Location = new Point(367, 407);
            button8.Name = "button8";
            button8.Size = new Size(96, 23);
            button8.TabIndex = 8;
            button8.Text = "Salir";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // MenuAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button8;
            ClientSize = new Size(727, 457);
            Controls.Add(button8);
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
        private Button button8;
        private Button btnNotas;
        private Button btnCursos;
    }
}