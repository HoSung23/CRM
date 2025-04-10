namespace BlazorApp1.Data.Models
{
    public class Registros
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Asunto { get; set; }
        public string Cliente { get; set; }
        public string DescCorta { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Nota { get; set; } = string.Empty;

        public Registros() {
        
        }

        public Registros(string nombre, string asunto, string cliente, string descCorta, string descripcion)
        {
            Nombre = nombre;
            Asunto = asunto;
            Cliente = cliente;
            DescCorta = descCorta;
            Descripcion = descripcion;
        }
    }
}
