using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Objects;

public class DisconnectParser : BaseParser
{
    public override void DoCommand(string[] input)
    {
        if (input.Length == 1 && input[0] == "disconnect")
        {
            var disconnectOperation = new DisconnectOperation();
            disconnectOperation.Execute(FileSystem);
        }
        else
        {
            base.DoCommand(input);
        }
    }
}