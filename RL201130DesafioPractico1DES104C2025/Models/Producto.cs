using RL201130DesafioPractico1DES104C2025.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RL201130DesafioPractico1DES104C2025.Models
{
    public class Producto
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Solo 100 caracteres.")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [StringLength(500, ErrorMessage = "Solo 500 caracteres..")]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        //llave foranea para categoria
        [Display(Name = "Categoria")]
        public int CategoriaID { get; set; }

        //propiedad de navegacion para categoria
        public Categoria Categoria { get; set; }
        //llave foranea para Proveedor

        [Display(Name = "Proveedor")]
        public int ProveedorID { get; set; }

        //propiedad de navegación para Proveedor
        public Proveedor Proveedor { get; set; }

        [Required]
        [Range(0.01, 1000000, ErrorMessage = "el Precio entre 0.01 y 1000000")]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "La existencia solo positivo")]
        [Display(Name = "Existencia")]
        public int Existencia { get; set; }
    }
}
