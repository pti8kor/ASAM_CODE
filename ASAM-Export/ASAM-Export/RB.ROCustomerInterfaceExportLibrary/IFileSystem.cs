using System.IO;

namespace RB.ROCustomerInterfaceExportLibrary
{
    /// <summary>
    /// Abstraction for file system operations to enable unit testing without real disk I/O.
    /// </summary>
    public interface IFileSystem
    {
        bool DirectoryExists(string path);
        void CreateDirectory(string path);
        string[] GetFiles(string path);
        void WriteAllBytes(string path, byte[] data);
        void WriteAllText(string path, string content);
        Stream OpenRead(string path);
        bool FileExists(string path);
    }

    /// <summary>
    /// Default implementation that delegates to the real System.IO for production use.
    /// </summary>
    public class DefaultFileSystem : IFileSystem
    {
        public bool DirectoryExists(string path) => Directory.Exists(path);
        public void CreateDirectory(string path) => Directory.CreateDirectory(path);
        public string[] GetFiles(string path) => Directory.GetFiles(path);
        public void WriteAllBytes(string path, byte[] data) => File.WriteAllBytes(path, data);
        public void WriteAllText(string path, string content) => File.WriteAllText(path, content);
        public Stream OpenRead(string path) => File.OpenRead(path);
        public bool FileExists(string path) => File.Exists(path);
    }
}
