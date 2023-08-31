namespace PrincipioLiskov
{
    public interface ILogging
    {
        public void Informacion(string mensaje);
        public void Error(string mensaje, Exception e);
        public void Fatal(string mensaje, Exception e);
        public void Warning(string mensaje) { }

    }
}
