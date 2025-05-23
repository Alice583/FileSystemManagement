using Itmo.ObjectOrientedProgramming.Lab4.Tree;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

public class LocalSystem : IFileSystem
{
    private string? currentDirectory;

    public LocalSystem(string currentDirectory)
    {
        this.currentDirectory = currentDirectory;
    }

    public void Disconnect()
    {
        currentDirectory = null;
        Console.WriteLine("Disconected");
    }

    public void Connect(string address)
    {
        if (!Directory.Exists(address))
        {
            Console.WriteLine($"Directory {address} does not exist");
        }

        currentDirectory = address;
        Console.WriteLine($"Connected to {address}..");
    }

    public void CopyFile(string sourcePath, string destinationPath)
    {
        if (!File.Exists(sourcePath))
        {
            Console.WriteLine($"File {sourcePath} does not exist");
            return;
        }

        if (currentDirectory is null)
        {
            Console.WriteLine("Current directory is null");
            return;
        }

        sourcePath = Path.Combine(currentDirectory, sourcePath);
        destinationPath = Path.Combine(currentDirectory, destinationPath);
        File.Copy(sourcePath, destinationPath);
        Console.WriteLine($"File copied to {destinationPath}");
    }

    public void DeleteFile(string path)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine($"File {path} does not exist");
            return;
        }

        if (currentDirectory is null)
        {
            Console.WriteLine("Current directory is null");
            return;
        }

        path = Path.Combine(currentDirectory, path);
        File.Delete(path);
        Console.WriteLine($"File {path} deleted");
    }

    public void MoveFile(string sourcePath, string destinationPath)
    {
        if (!File.Exists(sourcePath))
        {
            Console.WriteLine($"File {sourcePath} does not exist");
            return;
        }

        if (!Directory.Exists(destinationPath))
        {
            Console.WriteLine($"Directory {destinationPath} does not exist");
            return;
        }

        if (currentDirectory is null)
        {
            Console.WriteLine("Current directory is null");
            return;
        }

        sourcePath = Path.Combine(currentDirectory, sourcePath);
        destinationPath = Path.Combine(currentDirectory, destinationPath);
        File.Move(sourcePath, destinationPath, true);
        Console.WriteLine($"File {sourcePath} moved to {destinationPath}");
    }

    public void RenameFile(string path, string name)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine($"File {path} does not exist");
            return;
        }

        if (currentDirectory is null)
        {
            Console.WriteLine("Current directory is null");
            return;
        }

        path = Path.Combine(currentDirectory, path);
        name = Path.Combine(currentDirectory, name);
        File.Move(path, name);
        Console.WriteLine($"File {path} renamed to {name}");
    }

    public void ShowFile(string path)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine($"File {path} does not exist");
            return;
        }

        if (currentDirectory is null)
        {
            Console.WriteLine("Current directory is null");
            return;
        }

        path = Path.Combine(currentDirectory, path);
        Console.WriteLine(File.ReadAllText(path));
    }

    public void TreeGoto(string path)
    {
        if (!Directory.Exists(path))
        {
            Console.WriteLine("Directory not found: {0}", path);
            return;
        }

        if (currentDirectory is null)
        {
            Console.WriteLine("Current directory is null");
            return;
        }

        currentDirectory = Path.Combine(currentDirectory, path);
        Console.WriteLine($"Current directory: {currentDirectory}");
    }

    public void TreeList(int depth)
    {
        var factory = new ComponentFactory();

        if (currentDirectory is null)
        {
            Console.WriteLine("Current directory is null");
            return;
        }

        IComponent tree = factory.Create(currentDirectory);
        var consoleVisitor = new ComponentVisitor(depth);
        tree.Accept(consoleVisitor);
    }
}