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
    public partial class FormTutorial : Form
    {
        int i = 0;
        string[] titulo = new string[] {"1. Ir a la pagina de descargas","2. Escuentra la version", "3. Descarga python", "4. Instalar python", "5. Espera", "6. FIN"};
        string[] instrucciones = new string[] { "Ingresar a la pagina https://www.python.org/ y acceder al apartado de descargas", "Escoge la version mas reciente del programa ", "Escoge la version de python dependiendo del sitema operativo usado", "Abre el archivo descargado y selecciona Install Now", "Espera a que se complete la instalacion", "Listo ya tienes la version mas reciente de python en tu sistema"};
        Image[] imagenes = new Image[] {FreshStart.Properties.Resources.TutorilPython1, FreshStart.Properties.Resources.TutorilPython2, FreshStart.Properties.Resources.TutorilPython3, FreshStart.Properties.Resources.TutorialPython5, FreshStart.Properties.Resources.TutorialPython4, FreshStart.Properties.Resources.TutorialPython6 };
    public FormTutorial()
        {
            InitializeComponent();
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            if (i < titulo.Length - 1)
            {
                i += 1;
                this.labeITitulo.Text = titulo[i];
                this.labelInstrucciones.Text = instrucciones[i];
                this.pictureBox.Image = imagenes[i];
                this.labeITitulo.Left = (Height / 2);
            }
        }

        private void FormTutorial_Load(object sender, EventArgs e)
        {
            this.labeITitulo.Text = titulo[0];
            this.labelInstrucciones.Text = instrucciones[0];
            this.pictureBox.Image = imagenes[i];
            this.labeITitulo.Left = (Height / 2);
        }

        private void botonAtras_Click(object sender, EventArgs e)
        { 
            if (i > 0)
            {
                i -= 1;
                this.labeITitulo.Text = titulo[i];
                this.labelInstrucciones.Text = instrucciones[i];
                this.pictureBox.Image = imagenes[i];
                this.labeITitulo.Left = (Height / 2);
            }
            
        }
    }
}
