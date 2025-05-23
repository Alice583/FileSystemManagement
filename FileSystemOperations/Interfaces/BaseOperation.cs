using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Interfaces;

public abstract class BaseOperation
{
    public abstract void Execute(IFileSystem fileSystem);
}