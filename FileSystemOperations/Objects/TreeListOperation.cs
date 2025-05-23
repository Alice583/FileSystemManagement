using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;

public class TreeListOperation : BaseOperation
{
    private readonly int _depth;

    public TreeListOperation(int depth)
    {
        _depth = depth;
    }

    public override void Execute(IFileSystem fileSystem)
    {
        fileSystem.TreeList(_depth);
    }
}