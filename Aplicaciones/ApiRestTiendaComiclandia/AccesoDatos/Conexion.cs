namespace ApiRestTiendaComiclandia.AccesoDatos
{
    public class Conexion
    {
        private string _conexionString = string.Empty;
        public Conexion() {

            var cadenaTmp = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _conexionString = cadenaTmp.GetSection("ConnectionStrings:connTiendaBD").Value;

        }


        public string CadenaSQL() {

            return _conexionString;
        }

    }
}
