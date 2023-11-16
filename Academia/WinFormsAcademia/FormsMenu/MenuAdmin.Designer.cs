namespace WinFormsAcademia
{
    partial class MenuAdmin
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
            btnAdmin = new Button();
            btnPlanes = new Button();
            btnEspecialidades = new Button();
            groupBox1 = new GroupBox();
            btnCursos = new Button();
            btnComisiones = new Button();
            btnMaterias = new Button();
            btnTodos = new Button();
            btnDocentes = new Button();
            btnAlumnos = new Button();
            btnReporteCursos = new Button();
            groupBox2 = new GroupBox();
            btnInscripcionMaterias = new Button();
            groupBox3 = new GroupBox();
            btnRegistroNotas = new Button();
            btnCerrarSesion = new Button();
            btnExit = new Button();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(703, 57);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Menú administrador";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(10, 47);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(189, 44);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Administradores";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnPlanes
            // 
            btnPlanes.Location = new Point(10, 33);
            btnPlanes.Name = "btnPlanes";
            btnPlanes.Size = new Size(189, 44);
            btnPlanes.TabIndex = 2;
            btnPlanes.Text = "Planes";
            btnPlanes.UseVisualStyleBackColor = true;
            btnPlanes.Click += btnPlanes_Click;
            // 
            // btnEspecialidades
            // 
            btnEspecialidades.Location = new Point(10, 89);
            btnEspecialidades.Name = "btnEspecialidades";
            btnEspecialidades.Size = new Size(189, 44);
            btnEspecialidades.TabIndex = 3;
            btnEspecialidades.Text = "Especialidades";
            btnEspecialidades.UseVisualStyleBackColor = true;
            btnEspecialidades.Click += btnEspecialidades_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCursos);
            groupBox1.Controls.Add(btnComisiones);
            groupBox1.Controls.Add(btnMaterias);
            groupBox1.Controls.Add(btnEspecialidades);
            groupBox1.Controls.Add(btnPlanes);
            groupBox1.Location = new Point(258, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 312);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administración de datos";
            // 
            // btnCursos
            // 
            btnCursos.Location = new Point(10, 253);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(189, 44);
            btnCursos.TabIndex = 9;
            btnCursos.Text = "Cursos";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // btnComisiones
            // 
            btnComisiones.Location = new Point(10, 199);
            btnComisiones.Name = "btnComisiones";
            btnComisiones.Size = new Size(189, 44);
            btnComisiones.TabIndex = 7;
            btnComisiones.Text = "Comisiones";
            btnComisiones.UseVisualStyleBackColor = true;
            // 
            // btnMaterias
            // 
            btnMaterias.Location = new Point(10, 144);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(189, 44);
            btnMaterias.TabIndex = 4;
            btnMaterias.Text = "Materias";
            btnMaterias.UseVisualStyleBackColor = true;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(10, 235);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(189, 44);
            btnTodos.TabIndex = 8;
            btnTodos.Text = "Todos los usuarios";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnDocentes
            // 
            btnDocentes.Location = new Point(10, 172);
            btnDocentes.Name = "btnDocentes";
            btnDocentes.Size = new Size(189, 44);
            btnDocentes.TabIndex = 6;
            btnDocentes.Text = "Docentes";
            btnDocentes.UseVisualStyleBackColor = true;
            btnDocentes.Click += btnDocentes_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.Location = new Point(10, 110);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(189, 44);
            btnAlumnos.TabIndex = 5;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // btnReporteCursos
            // 
            btnReporteCursos.Location = new Point(11, 109);
            btnReporteCursos.Name = "btnReporteCursos";
            btnReporteCursos.Size = new Size(189, 44);
            btnReporteCursos.TabIndex = 5;
            btnReporteCursos.Text = "Reporte de cursos";
            btnReporteCursos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnInscripcionMaterias);
            groupBox2.Location = new Point(487, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(212, 112);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alumnos";
            // 
            // btnInscripcionMaterias
            // 
            btnInscripcionMaterias.Location = new Point(11, 40);
            btnInscripcionMaterias.Name = "btnInscripcionMaterias";
            btnInscripcionMaterias.Size = new Size(189, 44);
            btnInscripcionMaterias.TabIndex = 0;
            btnInscripcionMaterias.Text = "Inscripción a materias";
            btnInscripcionMaterias.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnReporteCursos);
            groupBox3.Controls.Add(btnRegistroNotas);
            groupBox3.Location = new Point(487, 72);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(212, 184);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Profesores";
            // 
            // btnRegistroNotas
            // 
            btnRegistroNotas.Location = new Point(11, 43);
            btnRegistroNotas.Name = "btnRegistroNotas";
            btnRegistroNotas.Size = new Size(189, 44);
            btnRegistroNotas.TabIndex = 0;
            btnRegistroNotas.Text = "Registro de notas";
            btnRegistroNotas.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(263, 407);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(96, 23);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnExit
            // 
            btnExit.DialogResult = DialogResult.Abort;
            btnExit.Location = new Point(367, 407);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDocentes);
            groupBox4.Controls.Add(btnAdmin);
            groupBox4.Controls.Add(btnTodos);
            groupBox4.Controls.Add(btnAlumnos);
            groupBox4.Location = new Point(28, 72);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(210, 312);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Usuarios";
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(727, 457);
            Controls.Add(groupBox4);
            Controls.Add(btnExit);
            Controls.Add(btnCerrarSesion);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuAdmin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ACADEMIA";
            FormClosed += MenuAdmin_FormClosed;
            Load += MenuAdmin_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnAdmin;
        private Button btnPlanes;
        private Button btnEspecialidades;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnInscripcionMaterias;
        private GroupBox groupBox3;
        private Button btnRegistroNotas;
        private Button btnCerrarSesion;
        private Button btnMaterias;
        private Button btnReporteCursos;
        private Button btnExit;
        private Button btnComisiones;
        private Button btnDocentes;
        private Button btnAlumnos;
        private Button btnTodos;
        private Button btnCursos;
        private GroupBox groupBox4;
    }
}