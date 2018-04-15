using System;
using System.Collections.Generic;
using System.Text;

namespace FileManagerCL.Interfaces
{
    /// <summary>
    /// interface for XML File reader
    /// </summary>
    public interface IXMLFileReader
    {
        /// <summary>
        /// read an xml file content
        /// </summary>
        /// <param name="path">xml file path</param>
        /// <returns> the xml file content</returns>
        string readXMLFile(string path);
    }
}
