using FileManagerCL.Helpers;
using FileManagerCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileManagerCL.Implementations
{
    public class XMLFileReader : FileReader, IXMLFileReader 
    {
        /// <summary>
        /// <see cref="IXMLFileReader.ReadFile(string filePath)"/>
        /// </summary>
        public string readXMLFile(string path)
        {
            return base.ReadFile(path);
        }

        /// <summary>
        /// <see cref="ISecureFilerReader.RoleBasedFileRead(string filePath, ApplicationRoles userRole)"/>
        /// </summary>
        public override string RoleBasedFileRead(string filePath, ApplicationRoles userRole)
        {
            string fileContent = string.Empty;

            if (AuthorisationHelper.CanReadFile(filePath, userRole))
            {
                fileContent = this.readXMLFile(filePath);
            }

            return fileContent;
        }

        // <summary>
        /// <see cref="ICryptedFileReader.ReadCryptedFile(string filePath, CrypTingAlgorithm cryptingAlgorithm)"/> 
        /// </summary> 
        public override string ReadCryptedFile(string filePath, CrypTingAlgorithm cryptingAlgorithm)
        {
            string cryptedFileContent = this.readXMLFile(filePath);
            string decrypedFileContent = String.Empty;

            switch (cryptingAlgorithm)
            {
                case CrypTingAlgorithm.reverse:
                    {
                        decrypedFileContent = TextFileDecryptor.ReverseTextDecrypt(cryptedFileContent);
                        break;
                    }

            }

            return decrypedFileContent;
        }

    }
}
