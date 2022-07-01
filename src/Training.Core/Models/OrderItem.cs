namespace Training.Core.Models
{
    public record OrderItem : BaseModel
    {
        public ProductModel Product { get; set; } = new ProductModel();
        public int Quantity { get; set; }
    }
}
