using FileManagerCL.Helpers;
using FileManagerCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileManagerCL.Implementations
{
    public class XMLFileReader : FileReader, IXMLFileReader, ISecureFilerReader
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
        public string RoleBasedFileRead(string filePath, ApplicationRoles userRole)
        {
            string fileContent = string.Empty;

            if (AuthorisationHelper.CanReadFile(filePath, userRole))
            {
                fileContent = this.readXMLFile(filePath);
            }

            return fileContent;
        }
    }
}
