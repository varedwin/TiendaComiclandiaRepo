using ApiRestTiendaComiclandia.AccesoDatos;
using ApiRestTiendaComiclandia.Modelos;
using System.Collections.Immutable;

namespace ApiRestTiendaComiclandia.LogicaNegocio
{
    public class ProductoLN
    {

        public async Task<List<Producto>> ObtenerProductos()
        {
            ProductoAD prodAD = new ProductoAD();
            var productos = await prodAD.ObtenerProductos();
            return productos;

        }

        public  void GuardarClienteProducto(Pedido pedido)
        {
            if (pedido != null)
            {
                ProductoAD prodAD = new ProductoAD();
                prodAD.GuardarCliente(pedido.Nombre, pedido.Apellido, pedido.Cedula, pedido.Direccion);

                if (pedido != null && pedido.IdProductos != null && pedido.IdProductos.Any())
                {

                    var productos = from x in pedido.IdProductos
                                    group x by x into g
                                    let count = g.Count()
                                    select new { id = g.Key, cantidad = count };

                    foreach (var item in productos)
                    {

                        prodAD.GuardarPedido(pedido.Cedula, int.Parse(item.id), item.cantidad);

                    }

                }

            }

        }


    }
}
