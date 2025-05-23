namespace Itmo.ObjectOrientedProgramming.Lab4.Tree;

public interface IComponent
{
    public string Name { get; }

    public void Accept(IVisitor visitor);
}