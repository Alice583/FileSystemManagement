using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Objects;

public class TreeGotoParser : BaseParser
{
    public override void DoCommand(string[] input)
    {
        if (input.Length > 0 && input[0] == "tree" && input[1] == "goto")
        {
            if (input.Length < 3)
            {
                Console.WriteLine("Not enough commands");
            }

            string path = input[2];
            var treeGotoOperation = new TreeGotoOperation(path);
            treeGotoOperation.Execute(FileSystem);
        }
        else
        {
            base.DoCommand(input);
        }
    }
}