namespace WinFormsAcademia.FormularioEspecialidad
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
            label1 = new Label();
            txtID = new TextBox();
            txtDescripcion = new TextBox();
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 77);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 64;
            label1.Text = "Descripcion";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(147, 25);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 68;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(147, 74);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 65;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 28);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 67;
            label9.Text = "ID Especialidad";
            // 
            // button2
            // 
            button2.Location = new Point(170, 127);
            button2.Name = "button2";
            button2.Size = new Size(108, 35);
            button2.TabIndex = 66;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // button1
            // 
            button1.Location = new Point(33, 127);
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
            ClientSize = new Size(336, 179);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(txtDescripcion);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EditarForm";
            Text = "EditarForm";
            Load += EditarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtDescripcion;
        private Label label9;
        private Button button2;
        private Button button1;
    }
}