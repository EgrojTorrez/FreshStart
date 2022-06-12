using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace FreshStart.Modelo;

public class PrecargaDB
{
    public int IdUsuario { get; set; }
    public string Nombres { get; set; }
    public string APaterno { get; set; }
    public string AMaterno { get; set; }
    public int DNacimiento { get; set; }
    public int MNacimiento { get; set; }
    public int ANacimiento { get; set; }
    public string Contraseña { get; set; }
    public string Correo { get; set; }
    public string Usuario { get; set; }

}
