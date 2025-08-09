using System.ComponentModel.DataAnnotations;

namespace RL201130DesafioPractico1DES104C2025.Models
{
   
        public class Proveedor
        {
            public int ID { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "Solo hasta 100 caracteres.")]
            [Display(Name = "Empresa")]
            public string Empresa { get; set; }
            [Required]
            [StringLength(100, ErrorMessage = "Solo 100 caracteres.")]
            [Display(Name = "Contacto")]
            public string Contacto { get; set; }
            [StringLength(200, ErrorMessage = "Solo 100 caracteres.")]
            [Display(Name = "Direccion")]
            public string Direccion { get; set; }
            [Phone]
            [Display(Name = "Telefono")]
            public string Telefono { get; set; }
            [EmailAddress]
            [Display(Name = "Correo")]
            public string Email { get; set; }
        }
    
}
