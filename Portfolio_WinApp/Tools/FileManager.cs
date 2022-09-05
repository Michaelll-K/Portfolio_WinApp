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
            this.path = path;
            string txt = File.ReadAllText(path);

            string[] tabPomocnicza = new string[1];
            tabPomocnicza[0] = "\r\n";

            lines = txt.Split(tabPomocnicza, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

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
                    Image = Convert.ToInt32(model[3]),
                    LoginCount = Convert.ToInt32(model[4])
                };

                accounts.Add(account);
            }

            return accounts;
        }

        public void SaveAccounts(List<Account> accounts)
        {
            foreach (Account account in accounts)
            {
                lines.Add($"{account.Login};{account.Password};{account.Image};{account.LoginCount}");
            }

            File.WriteAllLines(path, lines);
        }
    }
}
