using FileManagerCL.Helpers;
using FileManagerCL.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileManagerCL.Implementations
{
    public class FileReader : IFileReader, ICryptedFileReader, ISecureFilerReader
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

        /// <summary>
        /// <see cref="ICryptedFileReader.ReadCryptedFile(string filePath, CrypTingAlgorithm cryptingAlgorithm)"/> 
        /// </summary> 
        public virtual string ReadCryptedFile(string filePath, CrypTingAlgorithm cryptingAlgorithm)
        {
            string cryptedFileContent = this.ReadFile(filePath);
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


        /// <summary>
        /// <see cref="ISecureFilerReader.RoleBasedFileRead(string filePath, ApplicationRoles userRole)"/>
        /// </summary>
        public virtual string RoleBasedFileRead(string filePath, ApplicationRoles userRole)
        {
            string fileContent = string.Empty;

            if (AuthorisationHelper.CanReadFile(filePath, userRole))
            {
                fileContent = this.ReadFile(filePath);
            }

            return fileContent;
        }
    }
}
