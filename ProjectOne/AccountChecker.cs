using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    static class AccountChecker
    {
        public static void AcccountChecker()
        {
            string[] usernames = {"8man", "Nyx" };
            string[] passwords = {"nyx", "8man" };
            string username = Account.AccountUsername();
            string password = Account.AccountPassword();
            bool isExist = false;
            for(int i = 0; i < usernames.Length; i++)
            {
                if (username.Equals(usernames[i], StringComparison.CurrentCultureIgnoreCase)
                    && password.Equals(passwords[i], StringComparison.CurrentCultureIgnoreCase))
                {
                    isExist = true;
                    Console.WriteLine("Login Successfully");
                }
            }
            if (!isExist) Console.WriteLine("User Doesn't Exist");
        }
    }
}
