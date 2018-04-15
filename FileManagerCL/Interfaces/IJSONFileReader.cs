using System;
using System.Collections.Generic;
using System.Text;

namespace FileManagerCL.Interfaces
{
    /// <summary>
    /// Interface for json file reading
    /// </summary>
    public interface IJSONFileReader
    {
        /// <summary>
        /// read json file content
        /// </summary>
        /// <param name="filePath">the file path</param>
        /// <returns>the file content</returns>
        string ReadJSONFile(String filePath);
    }
}
