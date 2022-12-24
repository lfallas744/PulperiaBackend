namespace PulperiaBackend.Modelo.DTO
{
    public class ProductoBasicoDTO
    {
#region Atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public List<ProvedorBasicoDTO> Provedores { get; set; }
#endregion
    }
}
