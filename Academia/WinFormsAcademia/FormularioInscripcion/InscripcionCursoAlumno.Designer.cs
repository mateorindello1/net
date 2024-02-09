namespace WinFormsAcademia.FormsMenu
{
    partial class InscripcionCursoAlumno
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
            dvgCursos = new DataGridView();
            btn_vovler = new Button();
            btnInscribirse = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgCursos).BeginInit();
            SuspendLayout();
            // 
            // dvgCursos
            // 
            dvgCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCursos.Location = new Point(12, 12);
            dvgCursos.Name = "dvgCursos";
            dvgCursos.RowTemplate.Height = 25;
            dvgCursos.Size = new Size(742, 150);
            dvgCursos.TabIndex = 6;
            // 
            // btn_vovler
            // 
            btn_vovler.Location = new Point(680, 180);
            btn_vovler.Name = "btn_vovler";
            btn_vovler.Size = new Size(75, 23);
            btn_vovler.TabIndex = 5;
            btn_vovler.Text = "Volver";
            btn_vovler.UseVisualStyleBackColor = true;
            btn_vovler.Click += btn_vovler_Click;
            // 
            // btnInscribirse
            // 
            btnInscribirse.Location = new Point(12, 180);
            btnInscribirse.Name = "btnInscribirse";
            btnInscribirse.Size = new Size(75, 23);
            btnInscribirse.TabIndex = 8;
            btnInscribirse.Text = "Inscribirse";
            btnInscribirse.UseVisualStyleBackColor = true;
            btnInscribirse.Click += btnInscribirse_Click;
            // 
            // InscripcionCursoAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 209);
            Controls.Add(btnInscribirse);
            Controls.Add(dvgCursos);
            Controls.Add(btn_vovler);
            Name = "InscripcionCursoAlumno";
            Text = "InscripcionCursoAlumno";
            Load += InscripcionCursoAlumno_Load;
            ((System.ComponentModel.ISupportInitialize)dvgCursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgCursos;
        private Button btn_vovler;
        private Button btnInscribirse;
    }
}