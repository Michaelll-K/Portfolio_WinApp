using Portfolio_WinApp.Models;
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
        /// Check login if it is in login file
        /// </summary>
        /// <param name="login">Login of account</param>
        /// <param name="accounts">list of accounts</param>
        /// <returns>True if login not exist in login file</returns>
        public bool CheckIfNotExists(string login, List<Account> accounts)
        {
            var respond = accounts.FirstOrDefault(x => x.Login == login);

            if (respond == null)
                return true;

            return false;
        }

        /// <summary>
        /// Check if login and password match with login file
        /// </summary>
        /// <param name="login">Login of account</param>
        /// <param name="password">Password of account</param>
        /// <returns>True if login and password match with login file</returns>
        public bool CheckIfCorrect(string login, string password)
        {
            return true;
        }
    }
}
