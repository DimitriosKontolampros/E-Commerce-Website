namespace WebApplication1.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderDate { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int TotalAmount { get; set; }
        public string OrderStatus { get; set; } = string.Empty;
    }

}


