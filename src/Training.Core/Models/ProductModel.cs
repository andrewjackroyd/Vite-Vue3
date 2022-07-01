namespace Training.Core.Models
{
    public record ProductModel : BaseModel
    {
        public string Description { get; set; } = string.Empty;
    }
}
