using System.ComponentModel.DataAnnotations;

namespace testeef.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres ")]

        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres ")]

        public string Title { get; set; }
        [MaxLength(1024, ErrorMessage = "Este campo deve ter no maximo 1024")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O ppreço deve ser maior que zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "este campo é obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria Invalida ")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
