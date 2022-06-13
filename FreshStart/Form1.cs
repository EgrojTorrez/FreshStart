namespace FreshStart;

using System.Data.SQLite;
using FreshStart.Cache;
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
        this.Close();
    }

    private void AbrirFormHijo(object formhijo)
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

    private void botonUsers_Click(object sender, EventArgs e)
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

    private void contenedorPrincipal_Paint(object sender, PaintEventArgs e)
    {

    }
}
