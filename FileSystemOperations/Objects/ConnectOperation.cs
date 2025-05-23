using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;

public class ConnectOperation : BaseOperation
{
    private readonly string _address;

    public ConnectOperation(string address)
    {
        _address = address;
    }

    public override void Execute(IFileSystem fileSystem)
    {
        fileSystem.Connect(_address);
    }
}