namespace hhWitcher.Core.Entities;

public class Executor : User
{
    public string BirthPlace { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public string School { get; set; } = string.Empty;
}