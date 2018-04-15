using System;
using System.Collections.Generic;
using System.Text;

namespace FileManagerCL.Helpers
{
    /// <summary>
    /// class for text decripting
    /// </summary>
    public static class TextFileDecryptor
    {
        /// <summary>
        /// reverse a the input text
        /// </summary>
        /// <param name="decryptedText">crypted text</param>
        /// <returns> decrypted text</returns>
        public static string ReverseTextDecrypt(string cryptedText)
        {
            char[] cryptedTextCharArray = cryptedText.ToCharArray();
            Array.Reverse(cryptedTextCharArray);

            return new string(cryptedTextCharArray);
        }
    }
}
