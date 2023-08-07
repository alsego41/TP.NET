namespace Academia
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtUsuario = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            btnIngresar = new System.Windows.Forms.Button();
            linkOlvidaPass = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(53, 63);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(229, 30);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido!\r\nPor favor digite su informacion de ingreso";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 117);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(63, 158);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(139, 114);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(167, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new System.Drawing.Point(139, 155);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new System.Drawing.Size(167, 23);
            txtPass.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new System.Drawing.Point(231, 199);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(75, 23);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // linkOlvidaPass
            // 
            linkOlvidaPass.AutoSize = true;
            linkOlvidaPass.Location = new System.Drawing.Point(15, 250);
            linkOlvidaPass.Name = "linkOlvidaPass";
            linkOlvidaPass.Size = new System.Drawing.Size(119, 15);
            linkOlvidaPass.TabIndex = 6;
            linkOlvidaPass.TabStop = true;
            linkOlvidaPass.Text = "Olvide mi contraseña";
            linkOlvidaPass.LinkClicked += linkOlvidaPass_LinkClicked;
            // 
            // formLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(332, 282);
            Controls.Add(linkOlvidaPass);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Ingreso";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel linkOlvidaPass;
    }
}
