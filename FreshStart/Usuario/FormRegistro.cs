using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FreshStart.Logica;
using FreshStart.Modelo;

namespace FreshStart
{
    public partial class FormRegistro : Form
    {
        string[] fecha_split = new string[3];
        Regex regex = new Regex("/");
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            string Fecha = fechaNacimiento.Value.ToString("dd/MM/yyyy");
            fecha_split = regex.Split(Fecha);
            if ((textBoxCorreo.Text == textBoxCorreoConfirm.Text) && (textBoxPassword.Text == textBoxPasswordConfirm.Text)&&(UsuarioLogica.Instancia.unicos(textBoxUsuario.Text,textBoxCorreo.Text)==false)){
                PrecargaDB objeto = new PrecargaDB()
                {
                    Nombres = textBoxNombres.Text,
                    APaterno = textBoxApellidoPaterno.Text,
                    AMaterno = textBoxApellidoMaterno.Text,
                    DNacimiento = fecha_split[0],
                    MNacimiento = fecha_split[1],
                    ANacimiento = fecha_split[2],
                    Correo = textBoxCorreo.Text,
                    Contraseña = textBoxPassword.Text,
                    Usuario = textBoxUsuario.Text,
                    Basica = Convert.ToString(0),
                    Intermedia = Convert.ToString(0),
                    Extra = Convert.ToString(0)

                };
                bool respuesta = UsuarioLogica.Instancia.Guardar(objeto);
                if (respuesta == true)
                {
                    MessageBox.Show("Registro exitoso");
                    
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                if ((textBoxUsuario.Text != "") || textBoxCorreo.Text != "") {
                    if (UsuarioLogica.Instancia.unicos(textBoxUsuario.Text, textBoxCorreo.Text) == false)
                    {
                        MessageBox.Show("Usuario o Correo ya usados, ingrese otros datos o intente iniciar sesion");
                    }
                    else
                    {
                        MessageBox.Show("Ingrese datos validos!!");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese datos validos!");
                }
            }
            
            

        }
    }
}
