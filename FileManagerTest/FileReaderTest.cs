using FileManagerCL.Implementations;
using FileManagerCL.Interfaces;
using System;
using Xunit;

namespace FileManagerTest
{
    public class FileReaderTest
    {
        [Fact]
        public void FileReader_existingFile_FileContent()
        {
            IFileReader fileReader = new FileReader();

            string filePath = @"C:\Users\Marwen\Downloads\textFile.txt";

            Assert.NotEmpty(fileReader.ReadFile(filePath));
        }
    }
}
