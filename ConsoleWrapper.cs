namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ConsoleWrapper
{
    public virtual string? ReadLine() => Console.ReadLine();

    public virtual void WriteLine(string message) => Console.WriteLine(message);
}