namespace PulperiaBackend.Modelo.Clases
{
    public class Bitacora
    {
        #region Atributos
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public Transaccion Transaccion { get; set; }
        #endregion

    }
}
