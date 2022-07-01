namespace Training.Core.Models
{
    public record OrderModel : BaseModel
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}
