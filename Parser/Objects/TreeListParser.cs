using Itmo.ObjectOrientedProgramming.Lab4.FileSystemOperations.Objects;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Objects;

public class TreeListParser : BaseParser
{
    public override void DoCommand(string[] input)
    {
        if (input.Length > 0 && input[0] == "tree" && input[1] == "list" && input[2] == "-d")
        {
            if (input.Length < 4)
            {
                Console.WriteLine("Not enough commands");
            }

            if (int.TryParse(input[3], out int depth))
            {
                var treeListOperation = new TreeListOperation(depth);
                treeListOperation.Execute(FileSystem);
            }
            else
            {
                Console.WriteLine("Not valid depth");
            }
        }
        else
        {
            base.DoCommand(input);
        }
    }
}