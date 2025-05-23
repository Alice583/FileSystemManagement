using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Objects;

public class FileRenameParser : BaseParser
{
    public override void DoCommand(string[] input)
    {
        if (input.Length > 0 && input[0] == "file" && input[1] == "rename")
        {
            if (input.Length < 4)
            {
                Console.WriteLine("Not enough commands");
            }

            string path = input[2];
            string name = input[3];
            var fileRenameOperation = new FileRenameOperation(path, name);
            fileRenameOperation.Execute(FileSystem);
        }
        else
        {
            base.DoCommand(input);
        }
    }
}