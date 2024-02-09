namespace WinFormsAcademia.FormularioCursosDocente
{
    partial class FormCursosDocente
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
            dgvCursos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
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
            label1.Text = "Mis Cursos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCursos
            // 
            dgvCursos.AllowUserToAddRows = false;
            dgvCursos.AllowUserToDeleteRows = false;
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Location = new Point(51, 109);
            dgvCursos.MultiSelect = false;
            dgvCursos.Name = "dgvCursos";
            dgvCursos.ReadOnly = true;
            dgvCursos.RowTemplate.Height = 25;
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCursos.Size = new Size(707, 308);
            dgvCursos.TabIndex = 8;
            // 
            // FormCursosDocente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dgvCursos);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCursosDocente";
            ShowInTaskbar = false;
            Text = "Usuarios";
            Load += FormCurso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Label label1;
        private DataGridView dgvCursos;
    }
}