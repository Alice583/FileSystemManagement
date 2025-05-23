using Itmo.ObjectOrientedProgramming.Lab4.Parser.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParserInvoker : IParserInvoker
{
    private readonly BaseParser _baseParser;

    private readonly ConsoleWrapper _console;

    public ParserInvoker(BaseParser baseParser, ConsoleWrapper console)
    {
        _baseParser = baseParser;
        _console = console;
    }

    public void Run(string[] input)
    {
        if (input.Length == 0)
        {
            _console.WriteLine("No input provided.");
            return;
        }

        _baseParser.DoCommand(input);

        while (true)
        {
            string? line = _console.ReadLine();
            string[] parsedLine;
            if (string.IsNullOrWhiteSpace(line))
            {
                _console.WriteLine("No input");
                break;
            }
            else
            {
                parsedLine = line.Split(" ");
            }

            _baseParser.DoCommand(parsedLine);
        }
    }
}