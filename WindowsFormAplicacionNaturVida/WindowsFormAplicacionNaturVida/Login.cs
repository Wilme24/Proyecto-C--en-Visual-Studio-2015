using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormAplicacionNaturVida
{
    class Login
    {
        private string cadenaConexion = "Data Source=DESKTOP-BED3LUO; Initial Catalog=BdTienda; Integrated Security=true";

        public static string usuario = "";
        
        public bool iniciarSesion(string nombre, String contrasena)
        {
            usuario = "";

            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            SqlParameter parUsuario = new SqlParameter("@nombre",nombre);
            SqlParameter parContrasena = new SqlParameter("@contrasena",contrasena);

            SqlCommand comando = new SqlCommand("select * from Vendedores where venUsuario=@nombre and venContraseña COLLATE Latin1_General_CS_AS = @contrasena",conexion);
            comando.Parameters.Add(parUsuario);
            comando.Parameters.Add(parContrasena);

            SqlDataReader lectura = comando.ExecuteReader();
            while (lectura.Read())
            {
                usuario = lectura.GetString(0);
            }

            lectura.Close();
            conexion.Close();

            if (String.IsNullOrEmpty(usuario))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       

    }
}
