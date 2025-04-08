using System;
using System.Data;
using System.Data.SqlClient;


namespace Tienda_Love
{
   public class ClsProductos
    {
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        //ATRIBUTOS
        private int idprod;
        private int idCategoria;
        private int idMarca;
        private string descripcion;
        private double precio;


        //metodos get y set
        public int _Idprod
        {
            get { return idprod; }
            set { idprod = value; }
        }
        public int _IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }
        public int _IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }
        }
        public string _Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public double _Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public DataTable ListarCategorias()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarCategorias";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarMarcas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarMarcas";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public void InsertarProductos(int idCategoria, int idMarca, string descripcion, double precio)
        {
            using (SqlCommand Comando = new SqlCommand())
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "AgregarProducto";
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@idcategoria", idCategoria);
                Comando.Parameters.AddWithValue("@idmarca", idMarca);
                Comando.Parameters.AddWithValue("@descrip", descripcion);
                Comando.Parameters.AddWithValue("@prec", precio);

                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
            }
            Conexion.CerrarConexion();
        }
        public DataTable ListarProductos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarProductos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public void EditarProductos()
        {
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "UPDATE PRODUCTOS SET IDCATEGORIA=@idCategoria, IDMARCA=@idMarca, DESCRIPCION=@descripcion, PRECIO=@precio WHERE IDPROD=@idprod";
            Comando.CommandType = CommandType.Text;

            // Usar parámetros para evitar SQL Injection
            Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            Comando.Parameters.AddWithValue("@idMarca", idMarca);
            Comando.Parameters.AddWithValue("@descripcion", descripcion);
            Comando.Parameters.AddWithValue("@precio", precio);
            Comando.Parameters.AddWithValue("@idprod", idprod);

            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        public void EliminarProducto()
        {
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "DELETE FROM PRODUCTOS WHERE IDPROD=@idprod";
            Comando.CommandType = CommandType.Text;

            // Usar parámetros para evitar SQL Injection
            Comando.Parameters.AddWithValue("@idprod", idprod);

            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }

        
    }
}