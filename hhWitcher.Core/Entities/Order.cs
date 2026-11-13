namespace hhWitcher.Core.Entities;

public class Order : BaseEntity
{
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
    
    public Guid? ExecutorId { get; set; }
    public Executor? Executor { get; set; }

    public string Goal { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string AdditionalConditions { get; set; } = string.Empty;

    public List<Review> Reviews { get; set; } = new();
}