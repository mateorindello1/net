namespace WinFormsAcademia.FormularioPlan
{
    partial class AgregarEditarPlan
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
            btnCancelar = new Button();
            btnGuardar = new Button();
            groupBox3 = new GroupBox();
            lblErrDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblId = new Label();
            txtId = new TextBox();
            btnReestablecer = new Button();
            groupBox2 = new GroupBox();
            cmbEspecialidades = new ComboBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(401, 386);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 35);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(198, 386);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(111, 35);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblErrDescripcion);
            groupBox3.Controls.Add(txtDescripcion);
            groupBox3.Location = new Point(198, 136);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(311, 97);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Descripción del plan";
            // 
            // lblErrDescripcion
            // 
            lblErrDescripcion.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrDescripcion.ForeColor = Color.IndianRed;
            lblErrDescripcion.Location = new Point(6, 62);
            lblErrDescripcion.Name = "lblErrDescripcion";
            lblErrDescripcion.Size = new Size(299, 15);
            lblErrDescripcion.TabIndex = 0;
            lblErrDescripcion.Text = "La descripción coincide con otro plan";
            lblErrDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            lblErrDescripcion.Visible = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(15, 36);
            txtDescripcion.MaxLength = 20;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(284, 23);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.Leave += txtDescripcion_Leave;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(249, 80);
            lblId.Name = "lblId";
            lblId.Size = new Size(99, 15);
            lblId.TabIndex = 72;
            lblId.Text = "Número de plan:";
            lblId.Visible = false;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(354, 77);
            txtId.Name = "txtId";
            txtId.Size = new Size(104, 23);
            txtId.TabIndex = 0;
            txtId.Visible = false;
            // 
            // btnReestablecer
            // 
            btnReestablecer.Location = new Point(287, 22);
            btnReestablecer.Name = "btnReestablecer";
            btnReestablecer.Size = new Size(132, 31);
            btnReestablecer.TabIndex = 14;
            btnReestablecer.Text = "Reestablecer datos";
            btnReestablecer.UseVisualStyleBackColor = true;
            btnReestablecer.Visible = false;
            btnReestablecer.Click += btnReestablecer_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbEspecialidades);
            groupBox2.Location = new Point(198, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(311, 75);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Especialidad";
            // 
            // cmbEspecialidades
            // 
            cmbEspecialidades.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidades.FormattingEnabled = true;
            cmbEspecialidades.Items.AddRange(new object[] { "2008", "2016", "2023" });
            cmbEspecialidades.Location = new Point(51, 30);
            cmbEspecialidades.Name = "cmbEspecialidades";
            cmbEspecialidades.Size = new Size(209, 23);
            cmbEspecialidades.TabIndex = 11;
            // 
            // AgregarEditarPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 443);
            Controls.Add(btnReestablecer);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "AgregarEditarPlan";
            Text = "Agregar/editar plan";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btnCancelar;
        private Button btnGuardar;
        private GroupBox groupBox3;
        private TextBox txtDescripcion;
        private Label lblId;
        private TextBox txtId;
        private Button btnReestablecer;
        private Label lblErrDescripcion;
        private GroupBox groupBox2;
        private ComboBox cmbEspecialidades;
    }
}