namespace BlazorApp1.Data.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public int Telefono { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Representante { get; set; } = string.Empty;
    }
}
