namespace hhWitcher.Core.Entities;

public class Customer : User
{
    public string Settlement { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
}