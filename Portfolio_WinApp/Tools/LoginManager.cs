using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_WinApp.Tools
{
    internal class LoginManager
    {
        public bool CheckIfCorrect(string login, string password)
        {
            if (login == password)
                return true;

            return false;
        }
    }
}
