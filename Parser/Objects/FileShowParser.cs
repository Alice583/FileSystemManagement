using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Objects;

public class FileShowParser : BaseParser
{
    public override void DoCommand(string[] input)
    {
        if (input.Length > 0 && input[0] == "file" && input[1] == "show" && input[3] == "-m")
        {
            if (input.Length < 5)
            {
                Console.WriteLine("Not enough commands");
            }

            string path = input[2];
            string mode = input[4];
            var fileShowOperation = new FileShowOperation(path);
            fileShowOperation.Execute(FileSystem);
        }
        else
        {
            base.DoCommand(input);
        }
    }
}