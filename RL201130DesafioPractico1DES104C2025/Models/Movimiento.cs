using System.ComponentModel.DataAnnotations;

namespace RL201130DesafioPractico1DES104C2025.Models
{
    public class Movimiento
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Producto")]
        public int ProductoID { get; set; }

        // Propiedad de navegación para Producto
        public Producto Producto { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser al menos 1")]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        public TipoMovimiento Tipo { get; set; }
    }

    public enum TipoMovimiento
    {
        Entrada,
        Salida
    }
}