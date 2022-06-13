namespace FreshStart
{
    partial class FormTutorial
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
            this.botonAtras = new System.Windows.Forms.PictureBox();
            this.botonSiguiente = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelLecciones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.botonAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labeITitulo
            // 
            this.labeITitulo.AutoSize = true;
            this.labeITitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeITitulo.Location = new System.Drawing.Point(87, 9);
            this.labeITitulo.Name = "labeITitulo";
            this.labeITitulo.Size = new System.Drawing.Size(183, 45);
            this.labeITitulo.TabIndex = 1;
            this.labeITitulo.Text = "Iniciar Sesión";
            // 
            // labelInstrucciones
            // 
            this.labelInstrucciones.Font = new System.Drawing.Font("Californian FB", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInstrucciones.Location = new System.Drawing.Point(154, 383);
            this.labelInstrucciones.Name = "labelInstrucciones";
            this.labelInstrucciones.Size = new System.Drawing.Size(564, 154);
            this.labelInstrucciones.TabIndex = 7;
            this.labelInstrucciones.Text = "UNETE AHORA A LA PLATAFORMA DE APRENDIZAJE DE PYTHON GRATUITA MAS COMPLETA Y AL A" +
    "LCANCE DE UN CLICK";
            this.labelInstrucciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // botonAtras
            // 
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtras.Image = global::FreshStart.Properties.Resources.angle_circle_left_free_icon_font;
            this.botonAtras.Location = new System.Drawing.Point(33, 465);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(50, 50);
            this.botonAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonAtras.TabIndex = 8;
            this.botonAtras.TabStop = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSiguiente.Image = global::FreshStart.Properties.Resources.angle_circle_right_free_icon_font;
            this.botonSiguiente.Location = new System.Drawing.Point(841, 465);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(50, 50);
            this.botonSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonSiguiente.TabIndex = 9;
            this.botonSiguiente.TabStop = false;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(154, 57);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(572, 314);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // panelLecciones
            // 
            this.panelLecciones.Location = new System.Drawing.Point(0, 0);
            this.panelLecciones.Name = "panelLecciones";
            this.panelLecciones.Size = new System.Drawing.Size(931, 548);
            this.panelLecciones.TabIndex = 11;
            // 
            // FormTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(929, 546);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.labelInstrucciones);
            this.Controls.Add(this.labeITitulo);
            this.Controls.Add(this.panelLecciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTutorial";
            this.Text = "FormTutorial";
            this.Load += new System.EventHandler(this.FormTutorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.botonAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labeITitulo;
        private Label labelInstrucciones;
        private PictureBox botonAtras;
        private PictureBox botonSiguiente;
        private PictureBox pictureBox;
        private Panel panelLecciones;
    }
}