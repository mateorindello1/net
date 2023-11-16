namespace WinFormsAcademia.FormularioComision
{
    partial class FormComision
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
            button2 = new Button();
            label1 = new Label();
            btEliminar = new Button();
            btEditar = new Button();
            btAgregar = new Button();
            dgvComisiones = new DataGridView();
            lblFilter = new Label();
            cmbPlan = new ComboBox();
            cmbMateria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Retry;
            button2.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(673, 27);
            button2.Name = "button2";
            button2.Size = new Size(85, 39);
            button2.TabIndex = 15;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift", 35.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(530, 78);
            label1.TabIndex = 13;
            label1.Text = "Comisiones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btEliminar
            // 
            btEliminar.BackColor = Color.IndianRed;
            btEliminar.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btEliminar.ForeColor = SystemColors.ButtonFace;
            btEliminar.Location = new Point(627, 362);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(134, 45);
            btEliminar.TabIndex = 12;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = false;
            btEliminar.Click += btEliminar_Click;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.Orange;
            btEditar.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btEditar.ForeColor = SystemColors.ButtonFace;
            btEditar.Location = new Point(627, 279);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(134, 45);
            btEditar.TabIndex = 11;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            btEditar.Click += btEditar_Click;
            // 
            // btAgregar
            // 
            btAgregar.BackColor = Color.YellowGreen;
            btAgregar.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btAgregar.ForeColor = SystemColors.ButtonFace;
            btAgregar.Location = new Point(627, 196);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(134, 45);
            btAgregar.TabIndex = 10;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // dgvComisiones
            // 
            dgvComisiones.AllowUserToAddRows = false;
            dgvComisiones.AllowUserToDeleteRows = false;
            dgvComisiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComisiones.Location = new Point(51, 109);
            dgvComisiones.MultiSelect = false;
            dgvComisiones.Name = "dgvComisiones";
            dgvComisiones.ReadOnly = true;
            dgvComisiones.RowTemplate.Height = 25;
            dgvComisiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComisiones.Size = new Size(530, 308);
            dgvComisiones.TabIndex = 8;
            // 
            // lblFilter
            // 
            lblFilter.Location = new Point(622, 109);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(146, 23);
            lblFilter.TabIndex = 21;
            lblFilter.Text = "Filtrar por plan y materia:";
            lblFilter.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbPlan
            // 
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Location = new Point(628, 133);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(134, 23);
            cmbPlan.TabIndex = 22;
            cmbPlan.SelectedIndexChanged += cmbPlan_SelectedIndexChanged;
            // 
            // cmbMateria
            // 
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(628, 164);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(134, 23);
            cmbMateria.TabIndex = 23;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // FormComision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbMateria);
            Controls.Add(cmbPlan);
            Controls.Add(lblFilter);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(btEliminar);
            Controls.Add(btEditar);
            Controls.Add(btAgregar);
            Controls.Add(dgvComisiones);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormComision";
            ShowInTaskbar = false;
            Text = "Usuarios";
            Load += FormComision_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Label label1;
        private Button btEliminar;
        private Button btEditar;
        private Button btAgregar;
        private DataGridView dgvComisiones;
        private Label lblFilter;
        private ComboBox cmbPlan;
        private ComboBox cmbMateria;
    }
}