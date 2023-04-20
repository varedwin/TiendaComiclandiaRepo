using ApiRestTiendaComiclandia.AccesoDatos;
using ApiRestTiendaComiclandia.LogicaNegocio;
using ApiRestTiendaComiclandia.Modelos;
using Microsoft.AspNetCore.Mvc;



namespace ApiRestTiendaComiclandia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        
        [HttpGet]
        public async Task<ActionResult<List<Producto>>> Get()
        {
            try
            {
                ProductoLN prodLN = new ProductoLN();
                var productos = await prodLN.ObtenerProductos();
                return productos;

            }
            catch (Exception)
            {
                return StatusCode(500);
                 
            }
        }


        [HttpPost]
        public ActionResult Post([FromBody] Pedido pedido)
        {
            try
            {
                ProductoLN prodLN = new ProductoLN();
                prodLN.GuardarClienteProducto(pedido);
                return Ok();

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
            
        }

    }
}
