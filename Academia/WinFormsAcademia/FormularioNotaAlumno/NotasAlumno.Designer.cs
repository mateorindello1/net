namespace WinFormsAcademia.FormularioNotaAlumno
{
    partial class NotasAlumno
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
            dgvNotas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Retry;
            button2.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(669, 39);
            button2.Name = "button2";
            button2.Size = new Size(85, 39);
            button2.TabIndex = 34;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift", 35.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 21);
            label1.Name = "label1";
            label1.Size = new Size(530, 78);
            label1.TabIndex = 33;
            label1.Text = "Notas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvNotas
            // 
            dgvNotas.AllowUserToAddRows = false;
            dgvNotas.AllowUserToDeleteRows = false;
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Location = new Point(47, 121);
            dgvNotas.MultiSelect = false;
            dgvNotas.Name = "dgvNotas";
            dgvNotas.ReadOnly = true;
            dgvNotas.RowTemplate.Height = 25;
            dgvNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotas.Size = new Size(530, 308);
            dgvNotas.TabIndex = 32;
            // 
            // NotasAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dgvNotas);
            Name = "NotasAlumno";
            Text = "NotasAlumno";
            Load += NotasAlumno_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Label label1;
        private DataGridView dgvNotas;
    }
}