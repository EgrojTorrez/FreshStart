using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FreshStart.Modelo;
using System.Data.SQLite;
namespace FreshStart.Logica
{
    public class UsuarioLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;

        private static UsuarioLogica _instanci = null;

        public UsuarioLogica()
        {

        }

        public static UsuarioLogica Instancia
        {
            get
            {
                if (_instanci == null)
                {
                    _instanci = new UsuarioLogica();
                }
                return _instanci;
            }
        }

        public bool Guardar(PrecargaDB obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into Datos(Nombres,APaterno,AMaterno,DNacimiento,MNacimiento,ANacimiento,Contraseña,Correo,Usuario) values (@nombre,@apaterno,@amaterno,@dnacimiento,@mnacimiento,@anacimiento,@contraseña,@correo,@usuario)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Nombres));
                cmd.Parameters.Add(new SQLiteParameter("@apaterno", obj.Nombres));
                cmd.Parameters.Add(new SQLiteParameter("@amaterno", obj.Nombres));
                cmd.Parameters.Add(new SQLiteParameter("@dnacimiento", obj.Nombres));
                cmd.Parameters.Add(new SQLiteParameter("@mnacimiento", obj.Nombres));
                cmd.Parameters.Add(new SQLiteParameter("@anacimiento", obj.Nombres));
                cmd.Parameters.Add(new SQLiteParameter("@contraseña", obj.Nombres));
                cmd.Parameters.Add(new SQLiteParameter("@correo", obj.Nombres));
                cmd.Parameters.Add(new SQLiteParameter("@usuario", obj.Nombres));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
                return respuesta;
        }

        public List<PrecargaDB> Listar()
        {
            List<PrecargaDB> oLista = new List<PrecargaDB>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Datos";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new PrecargaDB()
                        {
                            IdUsuario = int.Parse(dr["IdUsuario"].ToString()),
                            Nombres = dr["Nombres"].ToString(),
                            APaterno = dr["APaterno"].ToString(),
                            AMaterno = dr["AMaterno"].ToString(),
                            DNacimiento = int.Parse(dr["DNacimiento"].ToString()),
                            MNacimiento = int.Parse(dr["MNacimiento"].ToString()),
                            ANacimiento = int.Parse(dr["ANacimiento"].ToString()),
                            Contraseña = dr["Contraseña"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            Usuario = dr["Usuario"].ToString()
                        });

                    }
                }
                    return oLista;
            }
        }
    }
}
