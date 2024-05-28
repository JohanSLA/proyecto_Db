namespace proyecto_db
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.buttonIniciarSecion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelRegistrarse = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyecto_db.Properties.Resources.inicio_Secion;
            this.pictureBox1.Location = new System.Drawing.Point(130, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.Black;
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.ForeColor = System.Drawing.Color.White;
            this.textBoxUsuario.Location = new System.Drawing.Point(130, 190);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(131, 20);
            this.textBoxUsuario.TabIndex = 1;
            this.textBoxUsuario.Text = "Username";
            this.textBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.BackColor = System.Drawing.Color.Black;
            this.textBoxContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasena.ForeColor = System.Drawing.Color.White;
            this.textBoxContrasena.Location = new System.Drawing.Point(130, 234);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(131, 20);
            this.textBoxContrasena.TabIndex = 2;
            this.textBoxContrasena.Text = "Password";
            this.textBoxContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonIniciarSecion
            // 
            this.buttonIniciarSecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarSecion.Location = new System.Drawing.Point(150, 278);
            this.buttonIniciarSecion.Name = "buttonIniciarSecion";
            this.buttonIniciarSecion.Size = new System.Drawing.Size(95, 23);
            this.buttonIniciarSecion.TabIndex = 3;
            this.buttonIniciarSecion.Text = "Sing up";
            this.buttonIniciarSecion.UseVisualStyleBackColor = true;
            this.buttonIniciarSecion.Click += new System.EventHandler(this.buttonIniciarSecion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿No eres miembro?";
            // 
            // linkLabelRegistrarse
            // 
            this.linkLabelRegistrarse.AutoSize = true;
            this.linkLabelRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegistrarse.ImageKey = "(ninguno)";
            this.linkLabelRegistrarse.LinkColor = System.Drawing.Color.White;
            this.linkLabelRegistrarse.Location = new System.Drawing.Point(167, 378);
            this.linkLabelRegistrarse.Name = "linkLabelRegistrarse";
            this.linkLabelRegistrarse.Size = new System.Drawing.Size(60, 13);
            this.linkLabelRegistrarse.TabIndex = 5;
            this.linkLabelRegistrarse.TabStop = true;
            this.linkLabelRegistrarse.Text = "Registrarse";
            this.linkLabelRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistrarse);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.linkLabelRegistrarse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIniciarSecion);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Button buttonIniciarSecion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelRegistrarse;
    }
}