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
        
        public AccountManager()
        {
            Accounts = new List<Account>();
            Directory.CreateDirectory(path);
            location = Path.Combine(path, "\\Accounts.txt");

            FileInfo fileInfo = new FileInfo(location);

            if (!fileInfo.Exists)
                File.CreateText(location).Close();

            string txt = File.ReadAllText(location);

            string[] tabPomocnicza = new string[1];
            tabPomocnicza[0] = "\r\n";

            List<string> lines = txt.Split(tabPomocnicza, StringSplitOptions.RemoveEmptyEntries).ToList();

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
