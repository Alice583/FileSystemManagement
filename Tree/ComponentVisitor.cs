namespace Itmo.ObjectOrientedProgramming.Lab4.Tree;

public class ComponentVisitor : IVisitor
{
    private int _depth;

    public ComponentVisitor(int depth)
    {
        _depth = depth;
    }

    public void Visit(FileComponent fileComponent)
    {
        Write(fileComponent.Name);
    }

    public void Visit(DirectoryComponent directoryComponent)
    {
        Write(directoryComponent.Name);

        _depth += 1;

        foreach (IComponent component in directoryComponent.Components)
        {
            component.Accept(this);
        }

        _depth -= 1;
    }

    private void Write(string value)
    {
        if (_depth != 0)
        {
            Console.Write(string.Concat(Enumerable.Repeat(' ', _depth)));
            Console.Write("--> ");
        }

        Console.WriteLine(value);
    }
}