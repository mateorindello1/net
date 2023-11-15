namespace WinFormsAcademia.FormularioEspecialidad
{
    partial class FormEspecialidad
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
            dgvEspecialidades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
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
            label1.Text = "Especialidades";
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
            // dgvEspecialidades
            // 
            dgvEspecialidades.AllowUserToAddRows = false;
            dgvEspecialidades.AllowUserToDeleteRows = false;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Location = new Point(51, 109);
            dgvEspecialidades.MultiSelect = false;
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowTemplate.Height = 25;
            dgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEspecialidades.Size = new Size(530, 308);
            dgvEspecialidades.TabIndex = 8;
            // 
            // FormEspecialidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(btEliminar);
            Controls.Add(btEditar);
            Controls.Add(btAgregar);
            Controls.Add(dgvEspecialidades);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEspecialidad";
            ShowInTaskbar = false;
            Text = "Especialidades";
            Load += FormPlan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Label label1;
        private Button btEliminar;
        private Button btEditar;
        private Button btAgregar;
        private DataGridView dgvEspecialidades;
    }
}