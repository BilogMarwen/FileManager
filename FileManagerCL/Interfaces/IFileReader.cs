using System;
using System.Collections.Generic;
using System.Text;

namespace FileManagerCL.Interfaces
{
    /// <summary>
    /// Interface for text file reader
    /// </summary>
    public interface IFileReader
    {
        /// <summary>
        /// read a text file content 
        /// </summary>
        /// <param name="filePath">the file path</param>
        /// <returns>the text file content</returns>
        string ReadFile(string filePath);
    }
}
