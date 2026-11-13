namespace hhWitcher.Core.Entities;

public class Review : BaseEntity
{
    public Guid OrderId { get; set; }
    public Order Order { get; set; } = null!;

    public int Rating { get; set; }
    public string Text { get; set; } = string.Empty;
    public string Photo { get; set; } = string.Empty;
}