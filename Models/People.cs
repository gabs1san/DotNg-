namespace DotNg1.Models;

public class People
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public People(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}