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
using System.IO;
using System.Reflection;
using FreshStart.Logica;
using FreshStart.Cache;

namespace FreshStart
{
    public partial class FormEvaluaciones : Form
    {
        int pregunta = 0;
        string[] titulos = new string[10];
        string[] respuesta1 = new string[10];
        string[] respuesta2 = new string[10];
        string[] respuesta3 = new string[10];
        string[] respuesta4 = new string[10];
        string[] respuestacorrecta = new string[10];
        int calificacion = 0;

        public FormEvaluaciones()
        {
            InitializeComponent();
        }

        private void FormEvaluaciones_Load(object sender, EventArgs e)
        {
            datosXML();
            this.labeIPregunta.Text = titulos[0];
            this.button1.Text = respuesta1[0];
            this.button2.Text = respuesta2[0];
            this.button3.Text = respuesta3[0];
            this.button4.Text = respuesta4[0];
        }

        private void datosXML()
        {
            int i = 0;
            int opcion = 0;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\evaluaciones.xml");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"..\..\..\Resources\evaluaciones.xml");
            if (UserCache.Basica != "10")
            {
                opcion = 0;
            }else if(UserCache.Intermedia!= "10")
            {
                opcion = 1;
            }
            else { opcion = 2; }
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[opcion].ChildNodes)
            {

                foreach (XmlNode xmlNodeItem in xmlNode.ChildNodes)
                {
                    switch (xmlNodeItem.LocalName)
                    {
                        case "titulo":
                            titulos[i] = xmlNodeItem.InnerText;
                            break;
                        case "respuesta1":
                            respuesta1[i] = xmlNodeItem.InnerText;
                            break;
                        case "respuesta2":
                            respuesta2[i] = xmlNodeItem.InnerText;
                            break;
                        case "respuesta3":
                            respuesta3[i] = xmlNodeItem.InnerText;
                            break;
                        case "respuesta4":
                            respuesta4[i] = xmlNodeItem.InnerText;
                            break;
                        case "respuestacorrecta":
                            respuestacorrecta[i] = xmlNodeItem.InnerText;
                            break;

                    }
                }
                i++;
            }
        }

        private void compararRespuesta(string res)
        {
            if (int.Parse(res) == int.Parse(respuestacorrecta[pregunta]))
            {
                calificacion++;
                
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button botonActual = (Button)sender;
            
            if (pregunta < 10)
            {
                compararRespuesta(botonActual.Tag.ToString());                
            }
            pregunta++;
            if (pregunta < 10)
            {
                this.labeIPregunta.Text = titulos[pregunta];
                this.button1.Text = respuesta1[pregunta];
                this.button2.Text = respuesta2[pregunta];
                this.button3.Text = respuesta3[pregunta];
                this.button4.Text = respuesta4[pregunta];

            }
            else if (pregunta >= 10)
            {
                this.labeIPregunta.Text = "Calificacion: " + calificacion.ToString() + "/10";
                this.button1.Visible = false;
                this.button2.Visible = false;
                this.button3.Visible = false;
                this.button4.Visible = false;
                if (calificacion < 10)
                {
                    MessageBox.Show("Intentelo nuevamente");
                }
                else
                {
                    MessageBox.Show("Excelente, has pasado la evaluacion!");
                }
                if (UserCache.Basica != "10")
                {
                    UsuarioLogica.Instancia.actualizarcalificacion("Basica", calificacion);
                }
                else if (UserCache.Intermedia != "10")
                {
                    UsuarioLogica.Instancia.actualizarcalificacion("Intermedia", calificacion);
                }
                else { UsuarioLogica.Instancia.actualizarcalificacion("Extra", calificacion); }
                
            }
            
        }
    }
}
