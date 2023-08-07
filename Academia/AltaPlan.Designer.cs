namespace Academia
{
    partial class AltaPlan
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            comboEspecialidad = new System.Windows.Forms.ComboBox();
            txtAceptar = new System.Windows.Forms.Button();
            txtCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripcion Plan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(133, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Especialidad";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(27, 40);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(100, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // comboEspecialidad
            // 
            comboEspecialidad.FormattingEnabled = true;
            comboEspecialidad.Location = new System.Drawing.Point(133, 40);
            comboEspecialidad.Name = "comboEspecialidad";
            comboEspecialidad.Size = new System.Drawing.Size(121, 23);
            comboEspecialidad.TabIndex = 3;
            // 
            // txtAceptar
            // 
            txtAceptar.Location = new System.Drawing.Point(179, 94);
            txtAceptar.Name = "txtAceptar";
            txtAceptar.Size = new System.Drawing.Size(75, 23);
            txtAceptar.TabIndex = 4;
            txtAceptar.Text = "Aceptar";
            txtAceptar.UseVisualStyleBackColor = true;
            // 
            // txtCancelar
            // 
            txtCancelar.Location = new System.Drawing.Point(98, 94);
            txtCancelar.Name = "txtCancelar";
            txtCancelar.Size = new System.Drawing.Size(75, 23);
            txtCancelar.TabIndex = 5;
            txtCancelar.Text = "Cancelar";
            txtCancelar.UseVisualStyleBackColor = true;
            // 
            // AltaPlan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(283, 142);
            Controls.Add(txtCancelar);
            Controls.Add(txtAceptar);
            Controls.Add(comboEspecialidad);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaPlan";
            Text = "AltaPlan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox comboEspecialidad;
        private System.Windows.Forms.Button txtAceptar;
        private System.Windows.Forms.Button txtCancelar;
    }
}