using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_WinApp.Tools
{
    internal class LoginManager
    {
        /// <summary>
        /// Check login and password if they are correct with the login file
        /// </summary>
        /// <param name="login">Login of account</param>
        /// <param name="password">Password of account</param>
        /// <returns>True if password compares to login in login file</returns>
        public bool CheckIfCorrect(string login, string password)
        {
            if (login == password)
                return true;

            return false;
        }
    }
}
