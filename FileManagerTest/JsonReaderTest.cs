using FileManagerCL.Helpers;
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

        [Fact]
        public void ReadCryptedFile_existingFile_FileContent()
        {
            ICryptedFileReader jsonFileReader = new JSONFileReader();

            string fileContent = jsonFileReader.ReadCryptedFile(filePath, CrypTingAlgorithm.reverse);
            Assert.NotEmpty(fileContent);
        }

        [Fact]
        public void RoleBasedFileRead_existingFile_FileContent()
        {
            ISecureFilerReader jsonFileReader = new JSONFileReader();

            string fileContent = jsonFileReader.RoleBasedFileRead(filePath,ApplicationRoles.admin);
            Assert.NotEmpty(fileContent);
        }
    }
}
