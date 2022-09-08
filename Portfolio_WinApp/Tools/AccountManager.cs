using Portfolio_WinApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_WinApp.Tools
{
    /*
    //gets the directory where the program is launched from and adds the foldername
    string path = Path.Combine(Environment.CurrentDirectory, "foldername");

    //Creates a directory(folder) if it doesen't exist
    Directory.CreateDirectory(path);
    */
    internal class AccountManager
    {
        public List<Account> Accounts { get; set; }

        private readonly string path = Path.Combine(Environment.CurrentDirectory, "Accounts");
        private readonly string location;
        private FileManager fileManager;
        
        public AccountManager()
        {
            //fill Accounts list
            Accounts = new List<Account>();

            Directory.CreateDirectory(path);
            location = path + "\\Accounts.txt";

            FileInfo fileInfo = new FileInfo(location);

            if (!fileInfo.Exists)
                File.CreateText(location).Close();

            fileManager = new FileManager(location);
            Accounts = fileManager.GetAccounts();

        }

        /// <summary>
        /// Get specified account depend on login
        /// </summary>
        /// <param name="login">Login of the account</param>
        /// <returns>Returns Account with specific login</returns>
        public Account GetAccount(string login)
        {
            return Accounts.FirstOrDefault(a => a.Login == login);
        }

        /// <summary>
        /// Adds new account to Accounts list
        /// </summary>
        /// <param name="account">Account object to add</param>
        public void AddAccount(Account account)
        {
            Accounts.Add(account);

            fileManager.SaveAccounts(account);
        }


    }
}
