﻿namespace ApiRestTiendaComiclandia.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Cedula { get; set; }
        public string? Direccion { get; set; }
    }
}
