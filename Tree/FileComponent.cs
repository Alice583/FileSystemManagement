namespace Itmo.ObjectOrientedProgramming.Lab4.Tree;

public class FileComponent : IComponent
{
    public string Name { get; }

    public FileComponent(string name)
    {
        Name = name;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}