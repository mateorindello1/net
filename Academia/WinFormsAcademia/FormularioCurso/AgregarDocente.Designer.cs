namespace WinFormsAcademia.FormularioCurso
{
    partial class AgregarDocente
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
            dgvDocentes = new DataGridView();
            btnAgregar = new Button();
            btnCancelar = new Button();
            checkBox1 = new CheckBox();
            txtLegajo = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            SuspendLayout();
            // 
            // dgvDocentes
            // 
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocentes.Location = new Point(34, 28);
            dgvDocentes.MultiSelect = false;
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDocentes.RowTemplate.Height = 25;
            dgvDocentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocentes.ShowCellErrors = false;
            dgvDocentes.ShowRowErrors = false;
            dgvDocentes.Size = new Size(223, 341);
            dgvDocentes.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(321, 227);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(321, 269);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(331, 62);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(53, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Filtro";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtLegajo
            // 
            txtLegajo.Enabled = false;
            txtLegajo.Location = new Point(309, 87);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.PlaceholderText = "Legajo";
            txtLegajo.Size = new Size(100, 23);
            txtLegajo.TabIndex = 4;
            txtLegajo.KeyPress += txtOnlyNumeric_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Principal", "Auxiliar" });
            comboBox1.Location = new Point(309, 175);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Location = new Point(309, 153);
            label1.Name = "label1";
            label1.Size = new Size(100, 19);
            label1.TabIndex = 6;
            label1.Text = "Cargo:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AgregarDocente
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(437, 397);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(txtLegajo);
            Controls.Add(checkBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvDocentes);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgregarDocente";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Agregar un docente";
            Load += AgregarDocente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDocentes;
        private Button btnAgregar;
        private Button btnCancelar;
        private CheckBox checkBox1;
        private TextBox txtLegajo;
        private ComboBox comboBox1;
        private Label label1;
    }
}