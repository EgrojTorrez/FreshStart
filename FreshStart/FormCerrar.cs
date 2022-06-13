using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreshStart.Cache;
using FreshStart.Logica;

namespace FreshStart
{
    public partial class FormCerrar : Form
    {
        int opcion;
        public FormCerrar()
        {
            InitializeComponent();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCerrar_Load(object sender, EventArgs e)
        {
            if (opcion == 1)
            {
                this.labeITitulo.Text = "Cerrar Sesion";
                this.labelInstrucciones.Text = "Esta seguro que desea cerrar sesion en el dispositivo?";
            }
            else if (opcion == 2) 
            {
                this.labeITitulo.Text = "Cerrar";
                this.labelInstrucciones.Text = "Esta punto de cerrar el programa \n Terminaste de estudiar?";

            }
        }

        public void modificarOpcion(int opc)
        {
            opcion = opc;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (opcion == 1)
            {
                UserCache.Login = false;
                UsuarioLogica.Instancia.cerrar();
                this.DialogResult = DialogResult.OK;
            }
            else if (opcion == 2)
            {
                Application.Exit();
            }
        }
    }
}
