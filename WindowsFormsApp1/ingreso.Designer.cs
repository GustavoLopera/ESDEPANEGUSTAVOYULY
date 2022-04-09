namespace WindowsFormsApp1
{
    partial class ingreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingreso));
            this.groupBoxIngreso = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesionIngreso = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIngreso
            // 
            this.groupBoxIngreso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxIngreso.Controls.Add(this.pictureBox2);
            this.groupBoxIngreso.Controls.Add(this.btnIniciarSesionIngreso);
            this.groupBoxIngreso.Controls.Add(this.txtContraseña);
            this.groupBoxIngreso.Controls.Add(this.lblUsuario);
            this.groupBoxIngreso.Controls.Add(this.lblContraseña);
            this.groupBoxIngreso.Controls.Add(this.txtUsuario);
            this.groupBoxIngreso.Controls.Add(this.pictureBox1);
            this.groupBoxIngreso.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIngreso.Location = new System.Drawing.Point(213, 27);
            this.groupBoxIngreso.Name = "groupBoxIngreso";
            this.groupBoxIngreso.Size = new System.Drawing.Size(375, 396);
            this.groupBoxIngreso.TabIndex = 7;
            this.groupBoxIngreso.TabStop = false;
            this.groupBoxIngreso.Text = "Iniciar sesión";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.perfil_del_usuario1;
            this.pictureBox2.Location = new System.Drawing.Point(128, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;

            // 
            // btnIniciarSesionIngreso
            // 
            this.btnIniciarSesionIngreso.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIniciarSesionIngreso.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesionIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesionIngreso.Location = new System.Drawing.Point(125, 296);
            this.btnIniciarSesionIngreso.Name = "btnIniciarSesionIngreso";
            this.btnIniciarSesionIngreso.Size = new System.Drawing.Size(121, 66);
            this.btnIniciarSesionIngreso.TabIndex = 5;
            this.btnIniciarSesionIngreso.Text = "INICIAR SESIÓN";
            this.btnIniciarSesionIngreso.UseVisualStyleBackColor = false;
            this.btnIniciarSesionIngreso.Click += new System.EventHandler(this.btnIniciarSesionIngreso_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.SkyBlue;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Location = new System.Drawing.Point(101, 244);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(168, 22);
            this.txtContraseña.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.SkyBlue;
            this.lblUsuario.Location = new System.Drawing.Point(157, 152);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 14);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.SkyBlue;
            this.lblContraseña.Location = new System.Drawing.Point(146, 225);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(78, 14);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.SkyBlue;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Location = new System.Drawing.Point(101, 169);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(168, 22);
            this.txtUsuario.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 375);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.purple_and_blue_gradient_background_free_photo;
            this.ClientSize = new System.Drawing.Size(854, 521);
            this.Controls.Add(this.groupBoxIngreso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ingreso";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESO";
            this.groupBoxIngreso.ResumeLayout(false);
            this.groupBoxIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIngreso;
        private System.Windows.Forms.Button btnIniciarSesionIngreso;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

