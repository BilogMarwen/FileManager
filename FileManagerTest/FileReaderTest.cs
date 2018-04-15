using FileManagerCL.Helpers;
using FileManagerCL.Implementations;
using FileManagerCL.Interfaces;
using System;
using Xunit;

namespace FileManagerTest
{
    public class FileReaderTest
    {
        [Fact]
        public void FileRead_existingFile_FileContent()
        {
            IFileReader fileReader = new FileReader();

            string filePath = @"C:\Users\Marwen\Downloads\textFile.txt";

            Assert.NotEmpty(fileReader.ReadFile(filePath));
        }


        [Fact]
        public void CryptedFileRead_existingFile_FileContent()
        {
            ICryptedFileReader fileReader = new FileReader();

            string filePath = @"C:\Users\Marwen\Downloads\textFile.txt";

            Assert.NotEmpty(fileReader.ReadCryptedFile(filePath, CrypTingAlgorithm.reverse));
        }
    }
}
