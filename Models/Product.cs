namespace WebApplication1.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Price { get; set; } 
        public int Stock { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

    }
}
