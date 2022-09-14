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
        public static int userIndex = 0;

        //add user

        public static void AddUser(User user)
        { 
        users.Add(user);
        }

        public static List<User> getUsers()
        {
            return users;
        }

        public static void setUserIndex(User user)
        {
            for (int i = 0; i < users.Count(); i++)
            {
                if (users[i] == user)
                { 
                    userIndex = i;
                }
            }
        }

        public static void removeUser(User user)
        { 
            users.Remove(user);
        }

    }
}
