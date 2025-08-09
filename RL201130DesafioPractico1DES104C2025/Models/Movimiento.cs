using System.ComponentModel.DataAnnotations;

namespace RL201130DesafioPractico1DES104C2025.Models
{
    public class Movimiento
    {
        public int ID { get; set; }

        [Display(Name = "Producto")]
        public int ProductoID { get; set; }
        public Producto Producto { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Range(1, int.MaxValue)]
        public int Cantidad { get; set; }
        [Required]
        [Display(Name = "Tipo de Movimiento")]
        public TipoMovimiento Tipo { get; set; }
    }

    public enum TipoMovimiento
    {
        [Display(Name = "Entrada de Producto")]
        Entrada = 0,
        [Display(Name = "Salida de Producto")]
        Salida = 1
    }
}