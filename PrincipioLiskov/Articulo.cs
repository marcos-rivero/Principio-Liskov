using PrincipioAbiertoCerrado;
using Serilog;

namespace PrincipioResponsabilidadUnica
{
    public class Articulo
    {
        private readonly Logging _logging;
        string path = "C:/Users/Marcos/Desktop";
        public Articulo()
        {
            _logging = new Logging();
        }
        public void GuardarArticulo(string titulo, string contenido)
        {
            _logging.Informacion($"Vamos a insertar el articulo {titulo}");
            File.WriteAllText($"{path}/{titulo}.txt", contenido);
            _logging.Informacion($"Articulo insertado");
            //_cache.Add(titulo, contenido);
        }

        public string ConsultarArticulo(string titulo)
        {
            _logging.Informacion($"Consultar Articulo {titulo}");
            string contenido = ""; //_cache.Get(titulo);
            if (!string.IsNullOrWhiteSpace(contenido))
            {
                Log.Information($"Articulo encontrado en la cache");
                return contenido;
            }
            _logging.Informacion($"Articulo {titulo} encontrado en el sistema de archivos");
            contenido = File.ReadAllText($"{path}/{titulo}.txt");

            return contenido;
        }
    }
}
