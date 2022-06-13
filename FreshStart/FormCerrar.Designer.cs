namespace FreshStart
{
    partial class FormCerrar
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
            this.labeITitulo = new System.Windows.Forms.Label();
            this.labelInstrucciones = new System.Windows.Forms.Label();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.botonAceptar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // labeITitulo
            // 
            this.labeITitulo.AutoSize = true;
            this.labeITitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeITitulo.Location = new System.Drawing.Point(195, 24);
            this.labeITitulo.Name = "labeITitulo";
            this.labeITitulo.Size = new System.Drawing.Size(183, 45);
            this.labeITitulo.TabIndex = 2;
            this.labeITitulo.Text = "Iniciar Sesión";
            // 
            // labelInstrucciones
            // 
            this.labelInstrucciones.Font = new System.Drawing.Font("Californian FB", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInstrucciones.Location = new System.Drawing.Point(28, 103);
            this.labelInstrucciones.Name = "labelInstrucciones";
            this.labelInstrucciones.Size = new System.Drawing.Size(564, 154);
            this.labelInstrucciones.TabIndex = 8;
            this.labelInstrucciones.Text = "UNETE AHORA A LA PLATAFORMA DE APRENDIZAJE DE PYTHON GRATUITA MAS COMPLETA Y AL A" +
    "LCANCE DE UN CLICK";
            this.labelInstrucciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // botonCerrar
            // 
            this.botonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.Image = global::FreshStart.Properties.Resources.cerrarPopUp;
            this.botonCerrar.Location = new System.Drawing.Point(28, 260);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(67, 63);
            this.botonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonCerrar.TabIndex = 9;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAceptar.Image = global::FreshStart.Properties.Resources.checkPopUp;
            this.botonAceptar.Location = new System.Drawing.Point(525, 260);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(67, 63);
            this.botonAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonAceptar.TabIndex = 10;
            this.botonAceptar.TabStop = false;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // FormCerrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(634, 345);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.labelInstrucciones);
            this.Controls.Add(this.labeITitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCerrar";
            this.Text = "FormCerrar";
            this.Load += new System.EventHandler(this.FormCerrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labeITitulo;
        private Label labelInstrucciones;
        private PictureBox botonCerrar;
        private PictureBox botonAceptar;
    }
}