namespace FreshStart
{
    using System.Data.SQLite;
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

        private void contenedorPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}