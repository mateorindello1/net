namespace WinFormsAcademia.FormularioCursosDocente
{
    partial class MostrarCursosDocentes
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
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Retry;
            button2.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(669, 39);
            button2.Name = "button2";
            button2.Size = new Size(85, 39);
            button2.TabIndex = 28;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift", 35.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 21);
            label1.Name = "label1";
            label1.Size = new Size(530, 78);
            label1.TabIndex = 27;
            label1.Text = "Inscripciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.AllowUserToAddRows = false;
            dgvInscripciones.AllowUserToDeleteRows = false;
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Location = new Point(47, 121);
            dgvInscripciones.MultiSelect = false;
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.ReadOnly = true;
            dgvInscripciones.RowTemplate.Height = 25;
            dgvInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscripciones.Size = new Size(530, 308);
            dgvInscripciones.TabIndex = 26;
            // 
            // MostrarCursosDocentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dgvInscripciones);
            Name = "MostrarCursosDocentes";
            Text = "MostrarCursosDocentes";
            Load += MostrarCursosDocentes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Label label1;
        private DataGridView dgvInscripciones;
    }
}