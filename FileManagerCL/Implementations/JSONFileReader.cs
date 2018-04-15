using FileManagerCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileManagerCL.Implementations
{
    public class JSONFileReader : FileReader,IJSONFileReader
    {

        /// <summary>
        /// <see cref="IJSONFileReader.ReadJSONFile(String filePath)"/>
        /// </summary>
        public string ReadJSONFile(string filePath)
        {
            return base.ReadFile(filePath);
        }
    }
}
