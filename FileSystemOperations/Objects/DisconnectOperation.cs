using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;

public class DisconnectOperation : BaseOperation
{
    public override void Execute(IFileSystem fileSystem)
    {
        fileSystem.Disconnect();
    }
}