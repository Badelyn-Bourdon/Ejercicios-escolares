﻿
using capaDatos;
using System.Data.SqlClient;
using System.Data;

public class CD_Productos
{
    private CD_Conexion conexion = new CD_Conexion();

    SqlDataReader leer;
    DataTable tabla = new DataTable();
    SqlCommand comando = new SqlCommand();

    public DataTable Mostrar()
    {

        comando.Connection = conexion.AbrirConexion();
        comando.CommandText = "mostrarProducto";
        comando.CommandType = CommandType.StoredProcedure;
        leer = comando.ExecuteReader();
        tabla.Load(leer);
        conexion.CerrarConexion();
        return tabla;

    }

    public void Insertar(string nombre, string desc, string marca, double precio, int stock)
    {
        comando.Connection = conexion.AbrirConexion();
        comando.CommandText = "InsetarProductos";
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("@nombre", nombre);
        comando.Parameters.AddWithValue("@descrip", desc);
        comando.Parameters.AddWithValue("@Marca", marca);
        comando.Parameters.AddWithValue("@precio", precio);
        comando.Parameters.AddWithValue("@stock", precio);

        comando.ExecuteNonQuery();

        comando.Parameters.Clear();
        conexion.CerrarConexion();

    }

    public void Editar(string nombre, string desc, string marca, double precio, int stock, int id)
    {
        comando.Connection = conexion.AbrirConexion();
        comando.CommandText = "EditarProductos";
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("@nombre", nombre);
        comando.Parameters.AddWithValue("@descrip", desc);
        comando.Parameters.AddWithValue("@Marca", marca);
        comando.Parameters.AddWithValue("@precio", precio);
        comando.Parameters.AddWithValue("@stock", precio);
        comando.Parameters.AddWithValue("@id", id);

        comando.ExecuteNonQuery();

        comando.Parameters.Clear();
        conexion.CerrarConexion();
    }

    public void Eliminar(int id)
    {
        comando.Connection = conexion.AbrirConexion();
        comando.CommandText = "EliminarProducto";
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("@idpro", id);

        comando.ExecuteNonQuery();

        comando.Parameters.Clear();
        conexion.CerrarConexion();
    }

}