namespace ecommerce.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Product.Price * Quantity;

        public CartItem() { }

        public CartItem(int id, int productId, Product product, int quantity)
        {
            Id = id;
            ProductId = productId;
            Product = product;
            Quantity = quantity;
        }
    }
}
