using PrincipioLiskov;
using Serilog;

namespace PrincipioAbiertoCerrado
{
    public class Logging : ILogging
    {
        private readonly LoggingRepositorio _loggingRepositorio;
        public Logging()
        {
            _loggingRepositorio = new LoggingRepositorio();
        }

        public void Error(string mensaje, Exception e)
        {
            Log.Information(mensaje);
            _loggingRepositorio.Guardar();
        }

        public void Fatal(string mensaje, Exception e)
        {
            Log.Error(mensaje, e);
            _loggingRepositorio.Guardar();
        }

        public void Informacion(string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
