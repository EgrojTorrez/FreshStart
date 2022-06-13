namespace FreshStart
{
    partial class FormInicioSesion
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labeIniciarSesion = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.buttonIncribirse = new System.Windows.Forms.Button();
            this.labelPromocion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFormInscribirse = new System.Windows.Forms.Panel();
            this.panelRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(166, 437);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(152, 75);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "ENTRAR";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(110, 348);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(247, 23);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(110, 204);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(247, 23);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Californian FB", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(166, 264);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(126, 27);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Constraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Californian FB", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.Location = new System.Drawing.Point(188, 144);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(86, 27);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario";
            // 
            // labeIniciarSesion
            // 
            this.labeIniciarSesion.AutoSize = true;
            this.labeIniciarSesion.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeIniciarSesion.Location = new System.Drawing.Point(143, 67);
            this.labeIniciarSesion.Name = "labeIniciarSesion";
            this.labeIniciarSesion.Size = new System.Drawing.Size(183, 45);
            this.labeIniciarSesion.TabIndex = 0;
            this.labeIniciarSesion.Text = "Iniciar Sesión";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.buttonCerrar.BackgroundImage = global::FreshStart.Properties.Resources.x_free_icon_font;
            this.buttonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.buttonCerrar.Location = new System.Drawing.Point(29, 21);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(55, 52);
            this.buttonCerrar.TabIndex = 6;
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // panelRegistro
            // 
            this.panelRegistro.AutoSize = true;
            this.panelRegistro.BackColor = System.Drawing.Color.Transparent;
            this.panelRegistro.Controls.Add(this.labelPassword);
            this.panelRegistro.Controls.Add(this.textBoxUsuario);
            this.panelRegistro.Controls.Add(this.buttonLogin);
            this.panelRegistro.Controls.Add(this.buttonIncribirse);
            this.panelRegistro.Controls.Add(this.textBoxPassword);
            this.panelRegistro.Controls.Add(this.labelPromocion);
            this.panelRegistro.Controls.Add(this.label1);
            this.panelRegistro.Controls.Add(this.labeIniciarSesion);
            this.panelRegistro.Controls.Add(this.labelUsuario);
            this.panelRegistro.Location = new System.Drawing.Point(0, 0);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(811, 515);
            this.panelRegistro.TabIndex = 1;
            // 
            // buttonIncribirse
            // 
            this.buttonIncribirse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.buttonIncribirse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.buttonIncribirse.FlatAppearance.BorderSize = 0;
            this.buttonIncribirse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIncribirse.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIncribirse.Location = new System.Drawing.Point(593, 437);
            this.buttonIncribirse.Name = "buttonIncribirse";
            this.buttonIncribirse.Size = new System.Drawing.Size(152, 75);
            this.buttonIncribirse.TabIndex = 7;
            this.buttonIncribirse.Text = "INSCRIBETE";
            this.buttonIncribirse.UseVisualStyleBackColor = false;
            this.buttonIncribirse.Click += new System.EventHandler(this.buttonIncribirse_Click);
            // 
            // labelPromocion
            // 
            this.labelPromocion.AutoSize = true;
            this.labelPromocion.Font = new System.Drawing.Font("Californian FB", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPromocion.Location = new System.Drawing.Point(547, 168);
            this.labelPromocion.Name = "labelPromocion";
            this.labelPromocion.Size = new System.Drawing.Size(261, 189);
            this.labelPromocion.TabIndex = 6;
            this.labelPromocion.Text = "UNETE AHORA\nA LA PLATAFORMA\nDE APRENDIZAJE\nDE PYTHON GRATUITA\nMAS COMPLETA\nY AL A" +
    "LCANCE\nDE UN CLICK";
            this.labelPromocion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(593, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrarse";
            // 
            // panelFormInscribirse
            // 
            this.panelFormInscribirse.Location = new System.Drawing.Point(0, 0);
            this.panelFormInscribirse.Name = "panelFormInscribirse";
            this.panelFormInscribirse.Size = new System.Drawing.Size(230, 216);
            this.panelFormInscribirse.TabIndex = 2;
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(929, 546);
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.panelFormInscribirse);
            this.Controls.Add(this.buttonCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicioSesion";
            this.Text = "FormInicioSesion";
            this.Load += new System.EventHandler(this.FormInicioSesion_Load);
            this.Resize += new System.EventHandler(this.FormInicioSesion_Load);
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panelRegistro;
        private TextBox textBoxUsuario;
        private Label labelPassword;
        private Label labelUsuario;
        private Label labeIniciarSesion;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Label labelPromocion;
        private Label label1;
        private Button buttonIncribirse;
        private Panel panelFormInscribirse;
        private Button buttonCerrar;
    }
}