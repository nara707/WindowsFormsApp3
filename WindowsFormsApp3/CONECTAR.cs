using System.Data.SqlClient;

namespace PROYECTO_MAD
{
    public class BDConexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Server=NARAYANI\\SQLEXPRESS;Database=BD_MAD_PROJECT;Trusted_Connection=True;TrustServerCertificate=True;");

            conexion.Open();
            return conexion;
        }
    }
}