namespace ApiRestTiendaComiclandia.Modelos
{
    public class Pedido
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Cedula { get; set; }
        public string? Direccion { get; set; }
        public List<string>? IdProductos { get; set; }
    }
}
