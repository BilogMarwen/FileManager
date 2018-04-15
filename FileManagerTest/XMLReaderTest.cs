using FileManagerCL.Helpers;
using FileManagerCL.Implementations;
using FileManagerCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FileManagerTest
{
    public class XMLReaderTest
    {

        string filePath = @"C:\Users\Marwen\Downloads\book.xml";

        [Fact]
        public void XMLFileRead_existingFile_FileContent()
        {
            IXMLFileReader fileReader = new XMLFileReader();

            Assert.NotEmpty(fileReader.readXMLFile(filePath));
        }

        [Fact]
        public void BaseRoleXMLFileRead_existingFile_FileContent()
        {
            ISecureFilerReader fileReader = new XMLFileReader();

            Assert.NotEmpty(fileReader.RoleBasedFileRead(filePath,ApplicationRoles.admin));
        }


        [Fact]
        public void CryptedXMLFileRead_existingFile_FileContent()
        {
            ICryptedFileReader fileReader = new XMLFileReader();

            Assert.NotEmpty(fileReader.ReadCryptedFile(filePath, CrypTingAlgorithm.reverse));
        }
    }
}
