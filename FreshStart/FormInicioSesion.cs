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
            paneInicioSesion.Width = Width / 2;
            paneInicioSesion.Height = Height;
            panelRegistro.Left = Width / 2;
            panelRegistro.Width = Width/2;
            panelRegistro.Height = Height;
            
        }

        
    }

}
