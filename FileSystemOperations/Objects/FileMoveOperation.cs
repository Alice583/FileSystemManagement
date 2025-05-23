using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;

public class FileMoveOperation : BaseOperation
{
    private readonly string _sourcePath;

    private readonly string _destinationPath;

    public FileMoveOperation(string sourcePath, string destinationPath)
    {
        _sourcePath = sourcePath;
        _destinationPath = destinationPath;
    }

    public override void Execute(IFileSystem fileSystem)
    {
       fileSystem.MoveFile(_sourcePath, _destinationPath);
    }
}