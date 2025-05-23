using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;

public class FileRenameOperation : BaseOperation
{
    private readonly string _path;

    private readonly string _name;

    public FileRenameOperation(string path, string name)
    {
        _path = path;
        _name = name;
    }

    public override void Execute(IFileSystem fileSystem)
    {
        fileSystem.RenameFile(_path, _name);
    }
}