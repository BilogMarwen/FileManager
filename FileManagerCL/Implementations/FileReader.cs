using FileManagerCL.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileManagerCL.Implementations
{
    public class FileReader : IFileReader
    {
        /// <summary>
        /// <see cref="IFileReader.ReadFile(string filePath)"/> 
        /// </summary>        
        public string ReadFile(string filePath)
        {
            string readResult = string.Empty;

            readResult = File.ReadAllText(filePath);
            
            return readResult;

        }
    }
}
