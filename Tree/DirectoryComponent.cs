namespace Itmo.ObjectOrientedProgramming.Lab4.Tree;

public class DirectoryComponent : IComponent
{
    public string Name { get; }

    public IReadOnlyCollection<IComponent> Components { get; }

    public DirectoryComponent(string name, IReadOnlyCollection<IComponent> components)
    {
        Name = name;
        Components = components;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}