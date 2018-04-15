using System;
using System.Collections.Generic;
using System.Text;

namespace FileManagerCL.Helpers
{

    public enum CrypTingAlgorithm { reverse };

    public enum ApplicationRoles { admin, employee, guest }

    public static class AuthorisationHelper
    {

        public static bool CanReadFile(string filePath, ApplicationRoles userRole)
        {
            switch (userRole)
            {
                case ApplicationRoles.admin:
                    {
                        return true;
                    }
                case ApplicationRoles.employee:
                    {
                        return filePath.EndsWith(".xml");
                    }
                default:
                    {
                        return false;
                    }
            }
        }
    }
}
