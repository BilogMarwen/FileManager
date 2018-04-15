using FileManagerCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileManagerCL.Implementations
{
    public class XMLFileReader: FileReader, IXMLFileReader
    {
        /// <summary>
        /// <see cref="IXMLFileReader.ReadFile(string filePath)"/>
        /// </summary>
        public string readXMLFile(string path)
        {
            return base.ReadFile(path);
        }
    }
}
