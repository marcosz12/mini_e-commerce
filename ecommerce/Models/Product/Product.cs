using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models.Product
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Stock { get; set; }
    }
}
