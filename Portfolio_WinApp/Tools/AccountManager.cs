using Portfolio_WinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_WinApp.Tools
{
    internal class AccountManager
    {
        public List<Account> Accounts { get; set; }

        public AccountManager()
        {
            Accounts = new List<Account>();
        }

        public Account GetAccount(string login)
        {
            return Accounts.FirstOrDefault(a => a.Login == login);
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }
    }
}
