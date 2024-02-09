namespace WinFormsAcademia.FormularioInscripcion
{
    partial class InscripcionCorrecta
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
            label1 = new Label();
            txtLegajo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMateria = new TextBox();
            label5 = new Label();
            txtCondicion = new TextBox();
            txtPlan = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 23);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Inscripcion correcta";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(105, 55);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(100, 23);
            txtLegajo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 58);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Legajo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 145);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Plan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 116);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 7;
            label4.Text = "Materia";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(105, 113);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(100, 23);
            txtMateria.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 87);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 9;
            label5.Text = "Condicion";
            // 
            // txtCondicion
            // 
            txtCondicion.Location = new Point(105, 84);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(100, 23);
            txtCondicion.TabIndex = 8;
            // 
            // txtPlan
            // 
            txtPlan.Location = new Point(105, 142);
            txtPlan.Name = "txtPlan";
            txtPlan.Size = new Size(100, 23);
            txtPlan.TabIndex = 10;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(77, 180);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // InscripcionCorrecta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 237);
            Controls.Add(btnAceptar);
            Controls.Add(txtPlan);
            Controls.Add(label5);
            Controls.Add(txtCondicion);
            Controls.Add(label4);
            Controls.Add(txtMateria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLegajo);
            Controls.Add(label1);
            Name = "InscripcionCorrecta";
            Text = "InscripcionCorrecta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLegajo;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMateria;
        private Label label5;
        private TextBox txtCondicion;
        private TextBox txtPlan;
        private Button btnAceptar;
    }
}