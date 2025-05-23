namespace Itmo.ObjectOrientedProgramming.Lab4.Tree;

public interface IVisitor
{
    void Visit(FileComponent fileComponent);

    void Visit(DirectoryComponent directoryComponent);
}