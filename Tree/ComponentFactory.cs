namespace Itmo.ObjectOrientedProgramming.Lab4.Tree;

public class ComponentFactory
{
    public IComponent Create(string path)
    {
        if (Directory.Exists(path))
        {
            string? name = Path.GetFileName(path);

            IEnumerable<string> names = Directory
                .EnumerateFileSystemEntries(path)
                .Select(Path.GetFileName)
                .Where(x => x is not null)
                .Cast<string>();

            IComponent[] components = names
                .Select(entry => Path.Combine(path, entry))
                .Select(Create)
                .ToArray();

            return new DirectoryComponent(name ?? string.Empty, components);
        }

        if (File.Exists(path))
        {
            string name = Path.GetFileName(path);
            return new FileComponent(name);
        }

        throw new InvalidOperationException($"File system component at {path} is not found");
    }
}