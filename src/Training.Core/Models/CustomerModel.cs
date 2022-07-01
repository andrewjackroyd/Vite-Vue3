namespace Training.Core.Models
{
    public record CustomerModel : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public List<OrderModel> Orders { get; set; } = new List<OrderModel>();
    }
}
