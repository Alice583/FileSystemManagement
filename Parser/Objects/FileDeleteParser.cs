using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Objects;

public class FileDeleteParser : BaseParser
{
    public override void DoCommand(string[] input)
    {
        if (input.Length > 0 && input[0] == "file" && input[1] == "delete")
        {
            if (input.Length < 3)
            {
                Console.WriteLine("Not enough commands");
            }

            string path = input[2];
            var fileDeleteOperation = new FileDeleteOperation(path);
            fileDeleteOperation.Execute(FileSystem);
        }
        else
        {
            base.DoCommand(input);
        }
    }
}