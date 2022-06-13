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

namespace FreshStart;

public partial class FormUsuario : Form
{
    public FormUsuario()
    {
        InitializeComponent();
    }

    private void FormUsuario_Load(object sender, EventArgs e)
    {
        labeINombre.Text = UserCache.Nombres+" "+UserCache.APaterno+" "+UserCache.AMaterno;
        labelCorreo.Text = UserCache.Correo;
        labelNacimiento.Text = UserCache.DNacimiento + "/" + UserCache.MNacimiento + "/" + UserCache.ANacimiento;
        labelCorreo.Text = UserCache.Correo;
        labelNumeroLeccionesBasica.Text = UserCache.Basica + "/10 puntos";
        labelPorcentajeEtapaBasica.Text=Convert.ToString(Convert.ToInt32(UserCache.Basica)*10) + "%";
        progressBarBasica.Value = Convert.ToInt32(UserCache.Basica) * 10;
        labelNumeroLeccionesPractica.Text = UserCache.Intermedia+"/10 puntos";
        labelPorcentajeEtapaPractica.Text = Convert.ToString(Convert.ToInt32(UserCache.Intermedia)*10) + "%";
        progressBarPractica.Value = Convert.ToInt32(UserCache.Intermedia) * 10;
        labelNumeroLeccionesExtra.Text = UserCache.Extra + "/10 puntos";
        labelPorcentajeEtapaExtra.Text = Convert.ToString(Convert.ToInt32(UserCache.Extra)*10)+"%";
        progressBarExtra.Value = Convert.ToInt32(UserCache.Extra) * 10;

    }
}
