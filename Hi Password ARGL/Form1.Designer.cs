namespace Hi_Password_ARGL
{
    partial class FPassword
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.validar = new System.Windows.Forms.Button();
            this.txtcontrasena1 = new System.Windows.Forms.TextBox();
            this.txtcontrasena2 = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.Label();
            this.lcontra1 = new System.Windows.Forms.Label();
            this.lcontra2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // validar
            // 
            this.validar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.validar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validar.Location = new System.Drawing.Point(183, 251);
            this.validar.Name = "validar";
            this.validar.Size = new System.Drawing.Size(182, 52);
            this.validar.TabIndex = 0;
            this.validar.Text = "Validar ";
            this.validar.UseVisualStyleBackColor = false;
            this.validar.Click += new System.EventHandler(this.validar_Click);
            // 
            // txtcontrasena1
            // 
            this.txtcontrasena1.Location = new System.Drawing.Point(114, 121);
            this.txtcontrasena1.Name = "txtcontrasena1";
            this.txtcontrasena1.PasswordChar = '*';
            this.txtcontrasena1.Size = new System.Drawing.Size(312, 22);
            this.txtcontrasena1.TabIndex = 1;
            // 
            // txtcontrasena2
            // 
            this.txtcontrasena2.Location = new System.Drawing.Point(114, 194);
            this.txtcontrasena2.Name = "txtcontrasena2";
            this.txtcontrasena2.PasswordChar = '*';
            this.txtcontrasena2.Size = new System.Drawing.Size(312, 22);
            this.txtcontrasena2.TabIndex = 2;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(108, 41);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(318, 32);
            this.titulo.TabIndex = 3;
            this.titulo.Text = "Creacion de Password";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lcontra1
            // 
            this.lcontra1.AutoSize = true;
            this.lcontra1.Location = new System.Drawing.Point(111, 102);
            this.lcontra1.Name = "lcontra1";
            this.lcontra1.Size = new System.Drawing.Size(138, 16);
            this.lcontra1.TabIndex = 4;
            this.lcontra1.Text = "Ingrese la Contraseña";
            // 
            // lcontra2
            // 
            this.lcontra2.AutoSize = true;
            this.lcontra2.Location = new System.Drawing.Point(111, 175);
            this.lcontra2.Name = "lcontra2";
            this.lcontra2.Size = new System.Drawing.Size(146, 16);
            this.lcontra2.TabIndex = 5;
            this.lcontra2.Text = "Confirme la Contraseña";
            // 
            // FPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 361);
            this.Controls.Add(this.lcontra2);
            this.Controls.Add(this.lcontra1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.txtcontrasena2);
            this.Controls.Add(this.txtcontrasena1);
            this.Controls.Add(this.validar);
            this.Name = "FPassword";
            this.Text = "Solicitud de Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validar;
        private System.Windows.Forms.TextBox txtcontrasena1;
        private System.Windows.Forms.TextBox txtcontrasena2;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label lcontra1;
        private System.Windows.Forms.Label lcontra2;
    }
}

