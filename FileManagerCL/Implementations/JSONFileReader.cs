using FileManagerCL.Helpers;
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
        
        // <summary>
        /// <see cref="ICryptedFileReader.ReadCryptedFile(string filePath, CrypTingAlgorithm cryptingAlgorithm)"/> 
        /// </summary> 
        public override string ReadCryptedFile(string filePath, CrypTingAlgorithm cryptingAlgorithm)
        {
            string cryptedFileContent = this.ReadJSONFile(filePath);
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
