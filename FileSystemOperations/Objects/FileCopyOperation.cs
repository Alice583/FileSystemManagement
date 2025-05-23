using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;

public class FileCopyOperation : BaseOperation
{
    private readonly string _sourcePath;

    private readonly string _destinationPath;

    public FileCopyOperation(string sourcePath, string destinationPath)
    {
        _sourcePath = sourcePath;
        _destinationPath = destinationPath;
    }

    public override void Execute(IFileSystem fileSystem)
    {
        fileSystem.CopyFile(_sourcePath, _destinationPath);
    }
}