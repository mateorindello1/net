namespace WinFormsAcademia.FormularioPlan
{
    partial class EditarForm
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
            groupBox1 = new GroupBox();
            txtEspecialidad = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtDescripcion = new TextBox();
            txtID = new TextBox();
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEspecialidad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Location = new Point(16, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 111);
            groupBox1.TabIndex = 67;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEspecialidad.FormattingEnabled = true;
            txtEspecialidad.Location = new Point(131, 72);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(145, 23);
            txtEspecialidad.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 47;
            label2.Text = "ID Especialidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 38;
            label1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(131, 35);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(145, 23);
            txtDescripcion.TabIndex = 46;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(112, 16);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 66;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 19);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 65;
            label9.Text = "ID Plan";
            // 
            // button2
            // 
            button2.Location = new Point(202, 203);
            button2.Name = "button2";
            button2.Size = new Size(108, 35);
            button2.TabIndex = 64;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(68, 203);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 63;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 262);
            Controls.Add(groupBox1);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EditarForm";
            Text = "Editar plan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox txtEspecialidad;
        private Label label2;
        private Label label1;
        private TextBox txtDescripcion;
        private TextBox txtID;
        private Label label9;
        private Button button2;
        private Button button1;
    }
}