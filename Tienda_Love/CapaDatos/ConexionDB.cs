using System.Data;
using System.Data.SqlClient;

namespace Tienda_Love
{
    class ConexionBD
    {
        static private string CadenaConexion = "Server=DESKTOP-7358GJE\\MSSQLSERVER03;DataBase=Love;Integrated Security=true";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}