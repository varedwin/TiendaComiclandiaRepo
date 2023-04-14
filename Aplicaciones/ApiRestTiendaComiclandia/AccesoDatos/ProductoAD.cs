using ApiRestTiendaComiclandia.Modelos;
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
            

      
            
        
    }
}
