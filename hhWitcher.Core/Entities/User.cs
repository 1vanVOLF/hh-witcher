namespace hhWitcher.Core.Entities;

public abstract class User : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Profession { get; set; } = string.Empty;
}