using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FreshStart
{
    public partial class FormLecciones : Form
    {
        int leccion = 0;
        string[] titulos = new string[10];
        string[] codigos = new string[10];
        string[] explicaciones = new string[10];
        public FormLecciones()
        {
            InitializeComponent();
        }

        private void datosXML()
        {
            int i = 0;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\evaluaciones.xml");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"..\..\..\Resources\lecciones.xml");

            foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[0].ChildNodes)
            {
                foreach (XmlNode xmlNodeItem in xmlNode.ChildNodes)
                {
                    switch (xmlNodeItem.LocalName)
                    {
                        case "titulo":
                            titulos[i] = xmlNodeItem.InnerText;
                            break;
                        case "codigo":
                            codigos[i] = xmlNodeItem.InnerText;
                            break;
                        case "explicacion":
                            explicaciones[i] = xmlNodeItem.InnerText;
                            break;

                    }
                }
                i++;
            }
        }

        private void FormLecciones_Load(object sender, EventArgs e)
        {
            datosXML();
            this.labeITitulo.Text = titulos[0];
            this.labelCodigo.Text = codigos[0];
            this.labelExplicacion.Text = explicaciones[0];
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            if (leccion > 0)
            {
                leccion -= 1;
                this.labeITitulo.Text = titulos[leccion];
                this.labelCodigo.Text = codigos[leccion];
                this.labelExplicacion.Text = explicaciones[leccion];
                
            }
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            if (leccion < 3)
            {
                leccion += 1;
                this.labeITitulo.Text = titulos[leccion];
                this.labelCodigo.Text = codigos[leccion];
                this.labelExplicacion.Text = explicaciones[leccion];
                this.labeITitulo.Left = (Height / 2);
            }
        }
    }
}
