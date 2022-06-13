namespace FreshStart
{
    partial class formInicio
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
            this.barraLateral = new System.Windows.Forms.Panel();
            this.botonSignOut = new System.Windows.Forms.PictureBox();
            this.botonCalificaciones = new System.Windows.Forms.PictureBox();
            this.botonLecciones = new System.Windows.Forms.PictureBox();
            this.botonUsers = new System.Windows.Forms.PictureBox();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.botonAtras = new System.Windows.Forms.PictureBox();
            this.botonCalendario = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.contenedorPrincipal = new System.Windows.Forms.Panel();
            this.barraLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonSignOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCalificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonLecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonUsers)).BeginInit();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCalendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // barraLateral
            // 
            this.barraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(213)))));
            this.barraLateral.Controls.Add(this.botonSignOut);
            this.barraLateral.Controls.Add(this.botonCalificaciones);
            this.barraLateral.Controls.Add(this.botonLecciones);
            this.barraLateral.Controls.Add(this.botonUsers);
            this.barraLateral.Location = new System.Drawing.Point(0, 0);
            this.barraLateral.Name = "barraLateral";
            this.barraLateral.Size = new System.Drawing.Size(82, 608);
            this.barraLateral.TabIndex = 0;
            // 
            // botonSignOut
            // 
            this.botonSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSignOut.Image = global::FreshStart.Properties.Resources.sign_out_free_icon_font;
            this.botonSignOut.Location = new System.Drawing.Point(0, 533);
            this.botonSignOut.Name = "botonSignOut";
            this.botonSignOut.Size = new System.Drawing.Size(82, 55);
            this.botonSignOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonSignOut.TabIndex = 6;
            this.botonSignOut.TabStop = false;
            this.botonSignOut.Click += new System.EventHandler(this.botonSignOut_Click);
            // 
            // botonCalificaciones
            // 
            this.botonCalificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCalificaciones.Image = global::FreshStart.Properties.Resources.book_arrow_up_free_icon_font;
            this.botonCalificaciones.Location = new System.Drawing.Point(0, 205);
            this.botonCalificaciones.Name = "botonCalificaciones";
            this.botonCalificaciones.Size = new System.Drawing.Size(82, 55);
            this.botonCalificaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonCalificaciones.TabIndex = 5;
            this.botonCalificaciones.TabStop = false;
            this.botonCalificaciones.Click += new System.EventHandler(this.botonCalificaciones_Click);
            // 
            // botonLecciones
            // 
            this.botonLecciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonLecciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonLecciones.Image = global::FreshStart.Properties.Resources.book_alt_free_icon_font;
            this.botonLecciones.Location = new System.Drawing.Point(0, 135);
            this.botonLecciones.Name = "botonLecciones";
            this.botonLecciones.Size = new System.Drawing.Size(82, 55);
            this.botonLecciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonLecciones.TabIndex = 4;
            this.botonLecciones.TabStop = false;
            this.botonLecciones.Click += new System.EventHandler(this.botonLecciones_Click);
            // 
            // botonUsers
            // 
            this.botonUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonUsers.Image = global::FreshStart.Properties.Resources.user_free_icon_font;
            this.botonUsers.Location = new System.Drawing.Point(0, 65);
            this.botonUsers.Name = "botonUsers";
            this.botonUsers.Size = new System.Drawing.Size(82, 55);
            this.botonUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonUsers.TabIndex = 3;
            this.botonUsers.TabStop = false;
            this.botonUsers.Click += new System.EventHandler(this.botonUsers_Click);
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.barraSuperior.Controls.Add(this.botonAtras);
            this.barraSuperior.Controls.Add(this.botonCalendario);
            this.barraSuperior.Controls.Add(this.botonCerrar);
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(1014, 59);
            this.barraSuperior.TabIndex = 1;
            // 
            // botonAtras
            // 
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAtras.Image = global::FreshStart.Properties.Resources.angle_circle_left_free_icon_font;
            this.botonAtras.Location = new System.Drawing.Point(12, 3);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(50, 50);
            this.botonAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonAtras.TabIndex = 2;
            this.botonAtras.TabStop = false;
            // 
            // botonCalendario
            // 
            this.botonCalendario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonCalendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCalendario.Image = global::FreshStart.Properties.Resources.calendar_free_icon_font;
            this.botonCalendario.Location = new System.Drawing.Point(872, 3);
            this.botonCalendario.Name = "botonCalendario";
            this.botonCalendario.Size = new System.Drawing.Size(50, 50);
            this.botonCalendario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonCalendario.TabIndex = 1;
            this.botonCalendario.TabStop = false;
            // 
            // botonCerrar
            // 
            this.botonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.Image = global::FreshStart.Properties.Resources.cross_circle_free_icon_font;
            this.botonCerrar.Location = new System.Drawing.Point(953, 3);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(50, 50);
            this.botonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonCerrar.TabIndex = 0;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // contenedorPrincipal
            // 
            this.contenedorPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.contenedorPrincipal.Location = new System.Drawing.Point(82, 59);
            this.contenedorPrincipal.Name = "contenedorPrincipal";
            this.contenedorPrincipal.Size = new System.Drawing.Size(929, 546);
            this.contenedorPrincipal.TabIndex = 2;
            this.contenedorPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedorPrincipal_Paint);
            // 
            // formInicio
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(1011, 604);
            this.Controls.Add(this.contenedorPrincipal);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.barraLateral);
            this.Name = "formInicio";
            this.Resize += new System.EventHandler(this.formInicio_Load);
            this.barraLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonSignOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCalificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonLecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonUsers)).EndInit();
            this.barraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCalendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel barraLateral;
        private Panel barraSuperior;
        private PictureBox botonCerrar;
        private PictureBox botonSignOut;
        private PictureBox botonCalificaciones;
        private PictureBox botonLecciones;
        private PictureBox botonUsers;
        private PictureBox botonAtras;
        private PictureBox botonCalendario;
        private Panel contenedorPrincipal;

        
    }
}