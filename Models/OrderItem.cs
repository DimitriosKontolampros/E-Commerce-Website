﻿namespace WebApplication1.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }   
        public int OrderId { get; set; }       
        public int ProductId { get; set; }     
        public int Quantity { get; set; }      
        public decimal Price { get; set; }     
    }

}
