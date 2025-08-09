using System.ComponentModel.DataAnnotations;

namespace RL201130DesafioPractico1DES104C2025.Models
{
    
        public class Categoria
        {
            public int ID { get; set; }
            [Required]
            [StringLength(100, ErrorMessage = "Solo hasta 100 caracteres.")]
            [Display(Name="Categoria?")]
            public string Nombre { get; set; }
        }
    
}
