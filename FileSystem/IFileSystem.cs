namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

public interface IFileSystem
{
    void Disconnect();

    void Connect(string address);

    void CopyFile(string sourcePath, string destinationPath);

    void DeleteFile(string path);

    void MoveFile(string sourcePath, string destinationPath);

    void RenameFile(string path, string name);

    void ShowFile(string path);

    void TreeGoto(string path);

    void TreeList(int depth);
}