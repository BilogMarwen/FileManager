using FileManagerCL.Helpers;
using FileManagerCL.Implementations;
using FileManagerCL.Interfaces;
using System;
using Xunit;

namespace FileManagerTest
{
    public class FileReaderTest
    {
        string filePath = @"C:\Users\Marwen\Downloads\textFile.txt";

        [Fact]
        public void FileRead_existingFile_FileContent()
        {
            IFileReader fileReader = new FileReader();
            
            Assert.NotEmpty(fileReader.ReadFile(filePath));
        }


        [Fact]
        public void CryptedFileRead_existingFile_FileContent()
        {
            ICryptedFileReader fileReader = new FileReader();

            Assert.NotEmpty(fileReader.ReadCryptedFile(filePath, CrypTingAlgorithm.reverse));
        }

        [Fact]
        public void BaseRoleXMLFileRead_existingFile_FileContent()
        {
            ISecureFilerReader fileReader = new XMLFileReader();

            Assert.NotEmpty(fileReader.RoleBasedFileRead(filePath, ApplicationRoles.admin));
        }
    }
}
