namespace WinFormsAcademia.FormularioCurso
{
    partial class AgregarEditarCurso
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
            label3 = new Label();
            cmbComision = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            cmbMateria = new ComboBox();
            cmbPlan = new ComboBox();
            groupBox1 = new GroupBox();
            nudCupo = new NumericUpDown();
            label1 = new Label();
            txtAnio = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnReestablecer = new Button();
            dgvDocentes = new DataGridView();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCupo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbComision);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cmbMateria);
            groupBox2.Controls.Add(cmbPlan);
            groupBox2.Location = new Point(43, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 123);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selección de comisión";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 92);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 15;
            label3.Text = "Comisión:";
            // 
            // cmbComision
            // 
            cmbComision.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComision.FormattingEnabled = true;
            cmbComision.Items.AddRange(new object[] { "2008", "2016", "2023" });
            cmbComision.Location = new Point(87, 89);
            cmbComision.Name = "cmbComision";
            cmbComision.Size = new Size(234, 23);
            cmbComision.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 56);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 13;
            label5.Text = "Materia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 22);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Plan:";
            // 
            // cmbMateria
            // 
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Items.AddRange(new object[] { "2008", "2016", "2023" });
            cmbMateria.Location = new Point(87, 53);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(234, 23);
            cmbMateria.TabIndex = 12;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // cmbPlan
            // 
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Items.AddRange(new object[] { "2008", "2016", "2023" });
            cmbPlan.Location = new Point(87, 19);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(234, 23);
            cmbPlan.TabIndex = 11;
            cmbPlan.SelectedIndexChanged += cmbPlan_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudCupo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAnio);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(426, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 123);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del curso";
            // 
            // nudCupo
            // 
            nudCupo.Location = new Point(82, 82);
            nudCupo.Name = "nudCupo";
            nudCupo.Size = new Size(78, 23);
            nudCupo.TabIndex = 4;
            nudCupo.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 39);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Año:";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(82, 36);
            txtAnio.MaxLength = 50;
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(78, 23);
            txtAnio.TabIndex = 3;
            txtAnio.KeyPress += txtOnlyNumeric_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 84);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Cupo:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(397, 390);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 35);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(197, 390);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(111, 35);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnReestablecer
            // 
            btnReestablecer.Location = new Point(515, 17);
            btnReestablecer.Name = "btnReestablecer";
            btnReestablecer.Size = new Size(132, 31);
            btnReestablecer.TabIndex = 14;
            btnReestablecer.Text = "Reestablecer datos";
            btnReestablecer.UseVisualStyleBackColor = true;
            btnReestablecer.Visible = false;
            btnReestablecer.Click += btnReestablecer_Click;
            // 
            // dgvDocentes
            // 
            dgvDocentes.AllowUserToAddRows = false;
            dgvDocentes.AllowUserToDeleteRows = false;
            dgvDocentes.AllowUserToResizeColumns = false;
            dgvDocentes.AllowUserToResizeRows = false;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocentes.Location = new Point(126, 60);
            dgvDocentes.MultiSelect = false;
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.ReadOnly = true;
            dgvDocentes.RowTemplate.Height = 25;
            dgvDocentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocentes.ShowEditingIcon = false;
            dgvDocentes.Size = new Size(384, 168);
            dgvDocentes.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(126, 36);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 65;
            label6.Text = "Docentes:";
            // 
            // button1
            // 
            button1.Location = new Point(530, 110);
            button1.Name = "button1";
            button1.Size = new Size(51, 23);
            button1.TabIndex = 66;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(530, 164);
            button2.Name = "button2";
            button2.Size = new Size(51, 23);
            button2.TabIndex = 67;
            button2.Text = "Quitar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AgregarEditarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 443);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dgvDocentes);
            Controls.Add(btnReestablecer);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "AgregarEditarCurso";
            Text = "Agregar/editar curso";
            Load += AgregarEditarCurso_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCupo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
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
        private TextBox txtAnio;
        private Label label2;
        private TextBox txtTelefono;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnReestablecer;
        private ComboBox cmbMateria;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cmbComision;
        private NumericUpDown nudCupo;
        private DataGridView dgvDocentes;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}