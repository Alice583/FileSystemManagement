using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Objects;

public class ConnectParser : BaseParser
{
    public override void DoCommand(string[] input)
    {
        if (input.Length > 0 && input[0] == "connect" && input[2] == "-m")
        {
            if (input.Length < 4)
            {
                Console.WriteLine("Not enough commands");
            }

            string address = input[1];
            string mode = input[3];
            var connectOperation = new ConnectOperation(address);
            if (mode == "local")
            {
                FileSystemManager = new LocalSystem(address);
            }

            connectOperation.Execute(FileSystem);
        }
        else
        {
            base.DoCommand(input);
        }
    }
}