using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;

public class TreeGotoOperation : BaseOperation
{
    private readonly string _path;

    public TreeGotoOperation(string path)
    {
        _path = path;
    }

    public override void Execute(IFileSystem fileSystem)
    {
        fileSystem.TreeGoto(_path);
    }
}