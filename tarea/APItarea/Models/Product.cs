using System.ComponentModel.DataAnnotations;

namespace APItarea.Models
{
    public class Product
    {
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}