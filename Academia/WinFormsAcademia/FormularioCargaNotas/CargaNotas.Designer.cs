namespace WinFormsAcademia.FormularioCargaNotas
{
    partial class CargaNotas
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
            lblFilter = new Label();
            cmbAlumno = new ComboBox();
            button2 = new Button();
            label1 = new Label();
            btnAgregar = new Button();
            dgvCursos = new DataGridView();
            numNota = new NumericUpDown();
            Nota = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNota).BeginInit();
            SuspendLayout();
            // 
            // lblFilter
            // 
            lblFilter.Location = new Point(622, 119);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(134, 23);
            lblFilter.TabIndex = 26;
            lblFilter.Text = "Elegir legajo:";
            // 
            // cmbAlumno
            // 
            cmbAlumno.FormattingEnabled = true;
            cmbAlumno.Location = new Point(622, 145);
            cmbAlumno.Name = "cmbAlumno";
            cmbAlumno.Size = new Size(133, 23);
            cmbAlumno.TabIndex = 25;
            cmbAlumno.SelectedIndexChanged += cmbAlumno_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Retry;
            button2.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(667, 39);
            button2.Name = "button2";
            button2.Size = new Size(85, 39);
            button2.TabIndex = 24;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift", 35.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 21);
            label1.Name = "label1";
            label1.Size = new Size(530, 78);
            label1.TabIndex = 23;
            label1.Text = "Cargar Nota";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.YellowGreen;
            btnAgregar.Enabled = false;
            btnAgregar.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ButtonFace;
            btnAgregar.Location = new Point(622, 209);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 45);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Verificar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvCursos
            // 
            dgvCursos.AllowUserToAddRows = false;
            dgvCursos.AllowUserToDeleteRows = false;
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Location = new Point(45, 145);
            dgvCursos.MultiSelect = false;
            dgvCursos.Name = "dgvCursos";
            dgvCursos.ReadOnly = true;
            dgvCursos.RowTemplate.Height = 25;
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCursos.Size = new Size(530, 284);
            dgvCursos.TabIndex = 20;
            dgvCursos.SelectionChanged += dgvCursos_SelectionChanged;
            // 
            // numNota
            // 
            numNota.Location = new Point(691, 180);
            numNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numNota.Name = "numNota";
            numNota.Size = new Size(65, 23);
            numNota.TabIndex = 27;
            numNota.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Nota
            // 
            Nota.AutoSize = true;
            Nota.Location = new Point(623, 182);
            Nota.Name = "Nota";
            Nota.Size = new Size(62, 15);
            Nota.TabIndex = 28;
            Nota.Text = "Nota final:";
            // 
            // label2
            // 
            label2.Location = new Point(45, 119);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 29;
            label2.Text = "Elegir curso:";
            // 
            // CargaNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(Nota);
            Controls.Add(numNota);
            Controls.Add(lblFilter);
            Controls.Add(cmbAlumno);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(dgvCursos);
            Name = "CargaNotas";
            Text = "CargaNotas";
            Load += CargaNotas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFilter;
        private ComboBox cmbAlumno;
        private Button button2;
        private Label label1;
        private Button btnAgregar;
        private DataGridView dgvCursos;
        private NumericUpDown numNota;
        private Label Nota;
        private Label label2;
    }
}