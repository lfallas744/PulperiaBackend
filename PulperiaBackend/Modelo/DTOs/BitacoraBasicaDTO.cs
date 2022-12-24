namespace PulperiaBackend.Modelo.DTO
{
    public class BitacoraBasicaDTO
    {
        #region Atributos
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public TransaccionBasicaDTO Transaccion { get; set; }
        #endregion

    }
}
