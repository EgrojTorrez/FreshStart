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
        labelNumeroLeccionesBasica.Text = UserCache.Basica + "/30 lecciones";
        labelPorcentajeEtapaBasica.Text=Convert.ToString(Convert.ToInt32(UserCache.Basica)/30) + "%";
        progressBarBasica.Value = Convert.ToInt32(UserCache.Basica) / 30;
        labelNumeroLeccionesPractica.Text = UserCache.Intermedia+"/30 lecciones";
        labelPorcentajeEtapaPractica.Text = Convert.ToString(Convert.ToInt32(UserCache.Intermedia) / 30) + "%";
        progressBarPractica.Value = Convert.ToInt32(UserCache.Intermedia) / 30;
        labelNumeroLeccionesExtra.Text = UserCache.Extra + "/30 lecciones";
        labelPorcentajeEtapaExtra.Text = Convert.ToString(Convert.ToInt32(UserCache.Extra) / 30)+"%";
        progressBarExtra.Value = Convert.ToInt32(UserCache.Extra) / 30;

    }
}
