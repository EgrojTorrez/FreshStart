namespace FreshStart;

using System.Data.SQLite;
using FreshStart.Cache;
using FreshStart.Logica;
public partial class formInicio : Form
{
    public formInicio()
    {
        InitializeComponent();
    }

    private void formInicio_Load(object sender, EventArgs e)
    {
        barraLateral.Height = Height;
        barraSuperior.Width = Width;
        botonCerrar.Left = (Width - (botonCerrar.Width + 25));
        botonCalendario.Left = (Width - (botonCerrar.Width + botonCalendario.Width + 50));
        botonSignOut.Top = (Height - (botonSignOut.Height + 50));
        contenedorPrincipal.Width = Width - barraLateral.Width;
        contenedorPrincipal.Height = Height - barraSuperior.Height;

    }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            abrirFormCerrar(2);
        }

   public void AbrirFormHijo(object formhijo)
    {
        if (this.contenedorPrincipal.Controls.Count > 0)
        {
            this.contenedorPrincipal.Controls.RemoveAt(0);
        }
        Form hijo = formhijo as Form;
        hijo.TopLevel = false;
        hijo.Dock = DockStyle.Fill;
        this.contenedorPrincipal.Controls.Add(hijo);
        this.contenedorPrincipal.Tag = hijo;
        hijo.Show();
    }

    public void botonUsers_Click(object sender, EventArgs e)
    {
        if (UserCache.Login == true)
        {
            AbrirFormHijo(new FormUsuario());
        }else
        AbrirFormHijo(new FormInicioSesion());
    }

        private void botonLecciones_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormTutorial());
        }

        private void botonSignOut_Click(object sender, EventArgs e)
        {
            abrirFormCerrar(1);
        }

        private void abrirFormCerrar(int opc)
        {
            using (FormCerrar cerrar = new FormCerrar())
            {
                cerrar.modificarOpcion(opc);
                cerrar.ShowDialog(this);
                if (cerrar.DialogResult == DialogResult.OK)
                {
                    AbrirFormHijo(new FormUsuario());
                }
                
            }
        }

        private void botonCalificaciones_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormEvaluaciones());
        }

        private void botonSignOut_Click(object sender, EventArgs e)
        {
            if (UserCache.Login == true)
            {
                abrirFormCerrar(1);

            }
            else
                MessageBox.Show("No hay ninguna sesion iniciada");
        }

        private void abrirFormCerrar(int opc)
        {
            using (FormCerrar cerrar = new FormCerrar())
            {
                cerrar.modificarOpcion(opc);
                cerrar.ShowDialog();
            if (cerrar.DialogResult == DialogResult.OK)
            {
                AbrirFormHijo(new FormInicioSesion());
            }
            }
        }

        private void botonCalificaciones_Click(object sender, EventArgs e)
        {
        if (UserCache.Login == true)
            AbrirFormHijo(new FormEvaluaciones());
        else
            MessageBox.Show("Ingrese a una cuenta antes de continuar");
        }

    private void barraLateral_Paint(object sender, PaintEventArgs e)
    {

    }

    private void contenedorPrincipal_Paint(object sender, PaintEventArgs e)
    {

    }

    private void formInicio_Load_1(object sender, EventArgs e)
    {
        barraLateral.Height = Height;
        barraSuperior.Width = Width;
        botonCerrar.Left = (Width - (botonCerrar.Width + 25));
        botonCalendario.Left = (Width - (botonCerrar.Width + botonCalendario.Width + 50));
        botonSignOut.Top = (Height - (botonSignOut.Height + 50));
        contenedorPrincipal.Width = Width - barraLateral.Width;
        contenedorPrincipal.Height = Height - barraSuperior.Height;
        UserCache.Login = false;
        UsuarioLogica.Instancia.confirmacionlogin();
    }
}
