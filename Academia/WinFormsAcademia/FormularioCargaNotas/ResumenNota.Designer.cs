namespace WinFormsAcademia.FormularioCargaNotas
{
    partial class ResumenNota
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
            txtNota = new TextBox();
            label2 = new Label();
            txtLegajo = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            txtComision = new TextBox();
            label6 = new Label();
            txtMateria = new TextBox();
            label7 = new Label();
            btnAgregar = new Button();
            button1 = new Button();
            txtCondicion = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 67);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Nota:";
            // 
            // txtNota
            // 
            txtNota.Enabled = false;
            txtNota.Location = new Point(128, 64);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(100, 23);
            txtNota.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 32);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Verificacion nota";
            // 
            // txtLegajo
            // 
            txtLegajo.Enabled = false;
            txtLegajo.Location = new Point(128, 180);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(100, 23);
            txtLegajo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 183);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Legajo";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(128, 151);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 154);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(128, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 125);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 7;
            label5.Text = "Nombre:";
            // 
            // txtComision
            // 
            txtComision.Enabled = false;
            txtComision.Location = new Point(128, 240);
            txtComision.Name = "txtComision";
            txtComision.Size = new Size(100, 23);
            txtComision.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 243);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 9;
            label6.Text = "Comision:";
            // 
            // txtMateria
            // 
            txtMateria.Enabled = false;
            txtMateria.Location = new Point(128, 211);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(100, 23);
            txtMateria.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 214);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 11;
            label7.Text = "Materia:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.IndianRed;
            btnAgregar.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ButtonFace;
            btnAgregar.Location = new Point(149, 269);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 45);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Cancelar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(9, 269);
            button1.Name = "button1";
            button1.Size = new Size(134, 45);
            button1.TabIndex = 23;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtCondicion
            // 
            txtCondicion.Enabled = false;
            txtCondicion.Location = new Point(128, 93);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(100, 23);
            txtCondicion.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 96);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 24;
            label8.Text = "Condicion:";
            // 
            // ResumenNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 327);
            Controls.Add(txtCondicion);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(btnAgregar);
            Controls.Add(txtMateria);
            Controls.Add(label7);
            Controls.Add(txtComision);
            Controls.Add(label6);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(txtLegajo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNota);
            Controls.Add(label1);
            Name = "ResumenNota";
            Text = "ResumenNota";
            Load += ResumenNota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNota;
        private Label label2;
        private TextBox txtLegajo;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtNombre;
        private Label label5;
        private TextBox txtComision;
        private Label label6;
        private TextBox txtMateria;
        private Label label7;
        private Button btnAgregar;
        private Button button1;
        private TextBox txtCondicion;
        private Label label8;
    }
}