using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;

public class FileShowOperation : BaseOperation
{
    private readonly string _path;

    public FileShowOperation(string path)
    {
        _path = path;
    }

    public override void Execute(IFileSystem fileSystem)
    {
        fileSystem.ShowFile(_path);
    }
}