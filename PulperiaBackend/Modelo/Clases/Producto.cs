namespace PulperiaBackend.Modelo.Clases
{
    public class Producto
    {
#region Atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public List<Provedor> Provedores { get; set; }
#endregion
    }
}
