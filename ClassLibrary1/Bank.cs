using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Bank
    {
        public static string name = "NordicBank";
       public static List<User> users = new List<User>();

        //add user

        public static void AddUser(User user)
        { 
        users.Add(user);
        }

        public static void removeUser(User user)
        { 
            users.Remove(user);
        }

    }
}
