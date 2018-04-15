using FileManagerCL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileManagerCL.Interfaces
{
    /// <summary>
    /// read crypted file content
    /// </summary>
    public interface ICryptedFileReader
    {
        /// <summary>
        /// return decrypted text file
        /// </summary>
        /// <param name="filePath">the crypted file path</param>
        /// <param name="cryptingAlgorithm"> the crypting algorithm</param>
        /// <returns>the decrypted file</returns>
        string ReadCryptedFile(string filePath, CrypTingAlgorithm cryptingAlgorithm);
    }
}
