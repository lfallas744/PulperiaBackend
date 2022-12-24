namespace PulperiaBackend.Modelo.DTO
{
    public class RolBasicaDTO
    {
        #region Atributos
        public int Id { get; set; }
        enum NombreRol
        {
            Administrador,
            Vendedor,
            Cliente
        }
        #endregion
    }
}
