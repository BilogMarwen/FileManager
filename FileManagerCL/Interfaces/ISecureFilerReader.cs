using FileManagerCL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileManagerCL.Interfaces
{
    /// <summary>
    /// Read file based on user role
    /// </summary>
    public interface ISecureFilerReader
    {
        /// <summary>
        /// read file content based on user's role
        /// </summary>
        /// <param name="filePath">the file path</param>
        /// <param name="userRole">the user role</param>
        /// <returns>the file content</returns>
        string RoleBasedFileRead(string filePath, ApplicationRoles userRole);
    }
}
