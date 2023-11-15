namespace WinFormsAcademia.FormularioMateria
{
    partial class AgregarEditarMateria
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
            cmbPlan = new ComboBox();
            groupBox1 = new GroupBox();
            txtHsTot = new TextBox();
            lblHorasTot = new Label();
            cmbTipo = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtHsSem = new TextBox();
            label2 = new Label();
            txtDescripcion = new TextBox();
            lblHorasSem = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            lblId = new Label();
            txtId = new TextBox();
            btnReestablecer = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbPlan);
            groupBox2.Location = new Point(181, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 75);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Plan de estudio";
            // 
            // cmbPlan
            // 
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Items.AddRange(new object[] { "2008", "2016", "2023" });
            cmbPlan.Location = new Point(58, 30);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(234, 23);
            cmbPlan.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHsTot);
            groupBox1.Controls.Add(lblHorasTot);
            groupBox1.Controls.Add(cmbTipo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtHsSem);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(lblHorasSem);
            groupBox1.Location = new Point(181, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 189);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la materia";
            // 
            // txtHsTot
            // 
            txtHsTot.Enabled = false;
            txtHsTot.Location = new Point(224, 141);
            txtHsTot.MaxLength = 50;
            txtHsTot.Name = "txtHsTot";
            txtHsTot.Size = new Size(84, 23);
            txtHsTot.TabIndex = 8;
            // 
            // lblHorasTot
            // 
            lblHorasTot.AutoSize = true;
            lblHorasTot.Location = new Point(163, 144);
            lblHorasTot.Name = "lblHorasTot";
            lblHorasTot.Size = new Size(46, 15);
            lblHorasTot.TabIndex = 7;
            lblHorasTot.Text = "Hs. Tot:";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Anual", "Cuatrimestral" });
            cmbTipo.Location = new Point(117, 103);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(183, 23);
            cmbTipo.TabIndex = 6;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 39);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 106);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 0;
            label3.Text = "Tipo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(117, 36);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(183, 23);
            txtNombre.TabIndex = 3;
            txtNombre.KeyPress += txtOnlyAlpha_KeyPress;
            // 
            // txtHsSem
            // 
            txtHsSem.Location = new Point(83, 141);
            txtHsSem.MaxLength = 50;
            txtHsSem.Name = "txtHsSem";
            txtHsSem.Size = new Size(57, 23);
            txtHsSem.TabIndex = 5;
            txtHsSem.KeyPress += txtOnlyNumeric_KeyPress;
            txtHsSem.Leave += txtHsSem_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 72);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 0;
            label2.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(117, 69);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(183, 23);
            txtDescripcion.TabIndex = 4;
            txtDescripcion.KeyPress += txtOnlyAlpha_KeyPress;
            // 
            // lblHorasSem
            // 
            lblHorasSem.AutoSize = true;
            lblHorasSem.Location = new Point(26, 144);
            lblHorasSem.Name = "lblHorasSem";
            lblHorasSem.Size = new Size(53, 15);
            lblHorasSem.TabIndex = 0;
            lblHorasSem.Text = "Hs. Sem:";
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
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(48, 25);
            lblId.Name = "lblId";
            lblId.Size = new Size(67, 15);
            lblId.TabIndex = 72;
            lblId.Text = "Id Materia:";
            lblId.Visible = false;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(121, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(94, 23);
            txtId.TabIndex = 0;
            txtId.Visible = false;
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
            // AgregarEditarMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 443);
            Controls.Add(btnReestablecer);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "AgregarEditarMateria";
            Text = "Agregar/editar materia";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtHsSem;
        private Label label2;
        private TextBox txtTelefono;
        private TextBox txtDescripcion;
        private Label lblHorasSem;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblId;
        private TextBox txtId;
        private Button btnReestablecer;
        private ComboBox cmbTipo;
        private TextBox txtHsTot;
        private Label lblHorasTot;
    }
}