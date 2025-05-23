using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;

public abstract class BaseParser
{
    public static IFileSystem FileSystem { get; private set; } = new LocalSystem(DriveInfo.GetDrives()[0].Name);

    private BaseParser? next;

    public static IFileSystem FileSystemManager
    {
        get => FileSystem;
        set
        {
            if (value is null)
            {
                Console.WriteLine("Path cannot be null or whitespace.");
                return;
            }

            FileSystem = value;
        }
    }

    public virtual void DoCommand(string[] input)
    {
        if (next != null)
        {
            next.DoCommand(input);
        }
        else
        {
            Console.WriteLine("command isn't available");
        }
    }

    public virtual BaseParser NextCommand(BaseParser nextCommand)
    {
        if (next is null)
        {
            next = nextCommand;
        }
        else
        {
            next.NextCommand(nextCommand);
        }

        return this;
    }
}