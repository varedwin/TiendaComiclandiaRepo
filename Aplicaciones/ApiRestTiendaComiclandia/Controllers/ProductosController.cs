using ApiRestTiendaComiclandia.AccesoDatos;
using ApiRestTiendaComiclandia.Modelos;
using Microsoft.AspNetCore.Mvc;



namespace ApiRestTiendaComiclandia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        // GET: api/<ProductosController>
        [HttpGet]
        //[Route("api/Productos")]
        public async Task<ActionResult<List<Producto>>> Get()
        {
            try
            {
                ProductoAD prodAD = new ProductoAD();
                var productos = await prodAD.ObtenerProductos();
                return productos;

            }
            catch (Exception)
            {
                return StatusCode(500);
                 
            }

           

        }
    }
}
