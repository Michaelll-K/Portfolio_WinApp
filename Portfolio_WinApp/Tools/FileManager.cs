using Portfolio_WinApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_WinApp.Tools
{
    internal class FileManager
    {
        string path;
        List<string> lines;
        public FileManager(string path)
        {
            //acces to file
            this.path = path;
            string txt = File.ReadAllText(path);

            string[] tabPomocnicza = new string[1];
            tabPomocnicza[0] = "\r\n";

            lines = txt.Split(tabPomocnicza, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        /// <summary>
        /// Get acces to the Account file and take rows into single Account object
        /// </summary>
        /// <returns>List of Accounts</returns>
        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            List<string> model;

            foreach (var line in lines)
            {
                model = line.Split(';').ToList();

                Account account = new Account()
                {
                    Login = model[0],
                    Password = model[1],
                    Image = Convert.ToInt32(model[2]),
                    LoginCount = Convert.ToInt32(model[3])
                };

                accounts.Add(account);
            }

            return accounts;
        }

        /// <summary>
        /// Saves Accounts in file
        /// </summary>
        /// <param name="accounts">List of all accounts thah will be saved</param>
        public void SaveAccounts(Account account)
        {
            lines.Add($"{account.Login};{account.Password};{account.Image};{account.LoginCount}");

            File.WriteAllLines(path, lines);
        }
    }
}
