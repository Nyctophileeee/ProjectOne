using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    static class Account
    {
         public static string AccountUsername()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            return username;
        }

        public static string AccountPassword() 
        {
            Console.Write("Password: ");
            string password = Console.ReadLine();
            return password;
        }
    }
}
