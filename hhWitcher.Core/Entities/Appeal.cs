namespace hhWitcher.Core.Entities;

public class Appeal : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public string Reason { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Photo { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}