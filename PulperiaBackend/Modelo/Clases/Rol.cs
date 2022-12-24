namespace PulperiaBackend.Modelo.Clases
{
    public class Rol
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
