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

        public List<Account> GetAccounts(string path)
        {
            List<Account> accounts = new List<Account>();

            string txt = File.ReadAllText(path);

            string[] tabPomocnicza = new string[1];
            tabPomocnicza[0] = "\r\n";

            List<string> lines = txt.Split(tabPomocnicza, StringSplitOptions.RemoveEmptyEntries).ToList();

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
    }
}
