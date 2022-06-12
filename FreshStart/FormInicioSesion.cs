using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshStart
{
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {
            
            panelRegistro.Width = Width;
            panelRegistro.Height = Height;
            panelFormInscribirse.Width = Width;
            panelFormInscribirse.Height = Height;
                
        }

        private void buttonIncribirse_Click(object sender, EventArgs e)
        {

            AbrirFormHijo(new FormRegistro());
            this.panelRegistro.SendToBack();
            this.buttonCerrar.BringToFront();
        }

        private void AbrirFormHijo(object formhijo)
        {
            if (this.panelFormInscribirse.Controls.Count > 0)
            {
                this.panelFormInscribirse.Controls.RemoveAt(0);
            }
            Form hijo = formhijo as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.panelFormInscribirse.Controls.Add(hijo);
            this.panelFormInscribirse.Tag = hijo;
            hijo.Show();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.panelFormInscribirse.Controls.RemoveAt(0);
            this.panelFormInscribirse.SendToBack();
            this.buttonCerrar.SendToBack();
            this.panelRegistro.BringToFront();
            
        }
    }

}
