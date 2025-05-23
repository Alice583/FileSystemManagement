using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Objects;

public class FileCopyParser : BaseParser
{
    public override void DoCommand(string[] input)
    {
        if (input.Length > 0 && input[0] == "file" && input[1] == "copy")
        {
            if (input.Length < 4)
            {
                Console.WriteLine("Not enough commands");
            }

            string sourcePath = input[2];
            string destinationPath = input[3];
            var fileCopyOperation = new FileCopyOperation(sourcePath, destinationPath);
            fileCopyOperation.Execute(FileSystem);
        }
        else
        {
            base.DoCommand(input);
        }
    }
}