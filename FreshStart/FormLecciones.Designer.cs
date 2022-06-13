namespace FreshStart
{
    partial class FormLecciones
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
            this.labelExplicacion = new System.Windows.Forms.Label();
            this.labeITitulo = new System.Windows.Forms.Label();
            this.botonSiguiente = new System.Windows.Forms.PictureBox();
            this.botonAtras = new System.Windows.Forms.PictureBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.botonSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExplicacion
            // 
            this.labelExplicacion.Font = new System.Drawing.Font("Californian FB", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExplicacion.Location = new System.Drawing.Point(529, 133);
            this.labelExplicacion.Name = "labelExplicacion";
            this.labelExplicacion.Size = new System.Drawing.Size(348, 301);
            this.labelExplicacion.TabIndex = 9;
            this.labelExplicacion.Text = "UNETE AHORA A LA PLATAFORMA DE APRENDIZAJE DE PYTHON GRATUITA MAS COMPLETA Y AL A" +
    "LCANCE DE UN CLICK";
            this.labelExplicacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labeITitulo
            // 
            this.labeITitulo.AutoSize = true;
            this.labeITitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeITitulo.Location = new System.Drawing.Point(332, 43);
            this.labeITitulo.Name = "labeITitulo";
            this.labeITitulo.Size = new System.Drawing.Size(183, 45);
            this.labeITitulo.TabIndex = 10;
            this.labeITitulo.Text = "Iniciar Sesión";
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSiguiente.Image = global::FreshStart.Properties.Resources.angle_circle_right_free_icon_font;
            this.botonSiguiente.Location = new System.Drawing.Point(827, 457);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(50, 50);
            this.botonSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonSiguiente.TabIndex = 11;
            this.botonSiguiente.TabStop = false;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtras.Image = global::FreshStart.Properties.Resources.angle_circle_left_free_icon_font;
            this.botonAtras.Location = new System.Drawing.Point(44, 457);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(50, 50);
            this.botonAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonAtras.TabIndex = 12;
            this.botonAtras.TabStop = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.Font = new System.Drawing.Font("Californian FB", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCodigo.Location = new System.Drawing.Point(35, 133);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(348, 301);
            this.labelCodigo.TabIndex = 13;
            this.labelCodigo.Text = "UNETE AHORA A LA PLATAFORMA DE APRENDIZAJE DE PYTHON GRATUITA MAS COMPLETA Y AL A" +
    "LCANCE DE UN CLICK";
            this.labelCodigo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormLecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(929, 546);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.labeITitulo);
            this.Controls.Add(this.labelExplicacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLecciones";
            this.Text = "FormLecciones";
            this.Load += new System.EventHandler(this.FormLecciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.botonSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelExplicacion;
        private Label labeITitulo;
        private PictureBox botonSiguiente;
        private PictureBox botonAtras;
        private Label labelCodigo;
    }
}