using ApiRestTiendaComiclandia.Modelos;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ApiRestTiendaComiclandia.AccesoDatos
{
    public class ProductoAD
    {

        public async Task<List<Producto>> ObtenerProductos() {

            Conexion conn = new Conexion();
            List<Producto> productos = new List<Producto>();

            using (var sql = new SqlConnection(conn.CadenaSQL()))
            {
                using (var cmd = new SqlCommand("ObtenerProductos", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync())
                        {
                            var prodTmp = new Producto();
                            prodTmp.Id = (int)item["Id"];
                            prodTmp.NombreProducto = (string)item["Producto"];
                            prodTmp.Valor = (decimal)item["Valor"];
                            productos.Add(prodTmp);
                        }

                    }
                }
            }
            return productos;
        }

        public async void GuardarPedido(string cedula, int idProducto, int cantidad)
        {

            Conexion strConexion = new Conexion();
            using (SqlConnection conn = new SqlConnection(strConexion.CadenaSQL()))
            {
                using (SqlCommand cmd = new SqlCommand("GuardarPedido", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    cmd.Parameters.AddWithValue("@producto", idProducto);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    conn.Open();
                    await cmd.ExecuteNonQueryAsync();
                }
            }


        }

        public void GuardarCliente(string nombre, string apellido, string cedula, string direccion)
        {
            Conexion strConexion = new Conexion();
            using (SqlConnection conn = new SqlConnection(strConexion.CadenaSQL()))
            {
                using (SqlCommand cmd = new SqlCommand("GuardarActualizarCliente", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
