using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStart.Cache
{
    public static class UserCache
    {
        public static bool Login { get; set; }
        public static int ID { get; set; }
        public static string Nombres { get; set; }
        public static string APaterno { get; set; }
        public static string AMaterno { get; set; }
        public static string DNacimiento { get; set; }
        public static string MNacimiento { get; set; }
        public static string ANacimiento { get; set; }
        public static string Contraseña { get; set; }
        public static string Correo { get; set; }
        public static string Usuario { get; set; }
        public static string Basica { get; set; }
        public static string Intermedia { get; set; }
        public static string Extra { get; set; }

    }
}
