using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Insira um email válido")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Password { get; set; }

    }
}
