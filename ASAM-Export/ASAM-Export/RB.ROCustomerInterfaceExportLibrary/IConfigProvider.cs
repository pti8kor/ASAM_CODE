using System.Xml.Linq;

namespace RB.ROCustomerInterfaceExportLibrary
{
    /// <summary>
    /// Abstraction for loading configuration XML to enable unit testing without real files on disk.
    /// </summary>
    public interface IConfigProvider
    {
        /// <summary>
        /// Loads a configuration XML document from the given path (or any source).
        /// Returns null if the configuration could not be loaded.
        /// </summary>
        XDocument LoadConfigurationXML(string configPath);
    }

    /// <summary>
    /// Default implementation that loads configuration from the real filesystem.
    /// Used in production code.
    /// </summary>
    public class FileConfigProvider : IConfigProvider
    {
        public XDocument LoadConfigurationXML(string configPath)
        {
            if (string.IsNullOrEmpty(configPath) || !System.IO.File.Exists(configPath))
                return null;

            return XDocument.Load(configPath);
        }
    }
}
