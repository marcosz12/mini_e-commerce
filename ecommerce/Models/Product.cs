using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Nome")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        [Display(Name = "Preço")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Description = "Descrição")]
        [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Url(ErrorMessage = "Insira uma URL válida.")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "O estoque não pode ser negativo")]
        [Display(Name = "Estoque")]
        public int Stock { get; set; }

        public Product() { }
    }
}
