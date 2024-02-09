namespace WinFormsAcademia.FormularioInscripcion
{
    partial class MostrarInscripciones
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
            dgvInscripciones = new DataGridView();
            cmbComision = new ComboBox();
            cmbMateria = new ComboBox();
            lblFilter = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Retry;
            button2.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(667, 39);
            button2.Name = "button2";
            button2.Size = new Size(85, 39);
            button2.TabIndex = 25;
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
            label1.TabIndex = 24;
            label1.Text = "Inscripciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.AllowUserToAddRows = false;
            dgvInscripciones.AllowUserToDeleteRows = false;
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Location = new Point(45, 121);
            dgvInscripciones.MultiSelect = false;
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.ReadOnly = true;
            dgvInscripciones.RowTemplate.Height = 25;
            dgvInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscripciones.Size = new Size(530, 308);
            dgvInscripciones.TabIndex = 20;
            // 
            // cmbComision
            // 
            cmbComision.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComision.FormattingEnabled = true;
            cmbComision.Location = new Point(618, 186);
            cmbComision.Name = "cmbComision";
            cmbComision.Size = new Size(134, 23);
            cmbComision.TabIndex = 31;
            cmbComision.SelectedIndexChanged += cmbComision_SelectedIndexChanged;
            // 
            // cmbMateria
            // 
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(618, 156);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(134, 23);
            cmbMateria.TabIndex = 30;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // lblFilter
            // 
            lblFilter.Location = new Point(618, 121);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(134, 32);
            lblFilter.TabIndex = 29;
            lblFilter.Text = "Filtrar por \r\nmateria y comisión:";
            lblFilter.TextAlign = ContentAlignment.TopCenter;
            // 
            // MostrarInscripciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbComision);
            Controls.Add(cmbMateria);
            Controls.Add(lblFilter);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dgvInscripciones);
            Name = "MostrarInscripciones";
            Text = "MostrarInscripciones";
            Load += MostrarInscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Label label1;
        private DataGridView dgvInscripciones;
        private ComboBox cmbComision;
        private ComboBox cmbMateria;
        private Label lblFilter;
    }
}