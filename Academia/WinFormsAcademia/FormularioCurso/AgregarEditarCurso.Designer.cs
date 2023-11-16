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
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCupo).BeginInit();
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
            groupBox2.Location = new Point(152, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(408, 140);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selección de comisión";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 103);
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
            cmbComision.Location = new Point(125, 100);
            cmbComision.Name = "cmbComision";
            cmbComision.Size = new Size(234, 23);
            cmbComision.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 67);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 13;
            label5.Text = "Materia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 33);
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
            cmbMateria.Location = new Point(125, 64);
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
            cmbPlan.Location = new Point(125, 30);
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
            groupBox1.Location = new Point(198, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 112);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del curso";
            // 
            // nudCupo
            // 
            nudCupo.Location = new Point(156, 70);
            nudCupo.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCupo.Name = "nudCupo";
            nudCupo.Size = new Size(78, 23);
            nudCupo.TabIndex = 4;
            nudCupo.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 39);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Año:";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(156, 36);
            txtAnio.MaxLength = 50;
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(78, 23);
            txtAnio.TabIndex = 3;
            txtAnio.KeyPress += txtOnlyNumeric_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 72);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Cupo:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(401, 376);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 35);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(198, 376);
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
            // AgregarEditarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 443);
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
            ResumeLayout(false);
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
    }
}