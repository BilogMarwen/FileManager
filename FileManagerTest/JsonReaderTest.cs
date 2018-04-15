using FileManagerCL.Implementations;
using FileManagerCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FileManagerTest
{
    public class JsonReaderTest
    {
        string filePath = @"C:\Users\Marwen\Downloads\JsonFile.json";

        [Fact]
        public void ReadJSONFile_existingFile_FileContent()
        {
            IJSONFileReader jsonFileReader = new JSONFileReader();

            string fileContent = jsonFileReader.ReadJSONFile(filePath);
            Assert.NotEmpty(fileContent);
        }
    }
}
