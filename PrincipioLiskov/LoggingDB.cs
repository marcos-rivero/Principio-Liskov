using PrincipioLiskov;

namespace PrincipioAbiertoCerrado
{
    public class LoggingDB : ILogging
    {
        private readonly LoggingRepositorio _logginRepositorio;
        public LoggingDB()
        {
            _logginRepositorio = new LoggingRepositorio();
        }

        // Violando Principio de Liskov
        public void Error(string mensaje, Exception e)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string mensaje, Exception e)
        {
            _logginRepositorio.Guardar();
        }

        // Violando Principio de Liskov
        public void Informacion(string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
