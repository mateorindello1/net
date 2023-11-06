namespace WinFormsAcademia.FormularioPlan
{
    partial class BusquedaForm
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
            btnAceptar = new Button();
            tbId = new TextBox();
            btnCancelar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(100, 123);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(98, 24);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // tbId
            // 
            tbId.Location = new Point(21, 61);
            tbId.Name = "tbId";
            tbId.Size = new Size(242, 23);
            tbId.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(216, 123);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 24);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 5;
            label1.Text = "Ingresa el ID a buscar:";
            // 
            // BusquedaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 167);
            Controls.Add(btnAceptar);
            Controls.Add(tbId);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Name = "BusquedaForm";
            Text = "BusquedaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox tbId;
        private Button btnCancelar;
        private Label label1;
    }
}