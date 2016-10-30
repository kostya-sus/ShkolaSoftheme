using System;
using System.Collections.Generic;


namespace HW12_IUser
{
    public class User : IUser
    {
        public static List<IUser> Users;


        public string Name { get; set; }

        public string Email { get; set; }

        public int Password { get; }

        private DateTime LastLogin { get; set; }


        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password.GetHashCode();
            LastLogin = DateTime.Now;
        }


        public string GetFullInfo()
        {
            LastLogin = DateTime.Now;
            return string.Format("\nName:  {0}\nEmail: {1}\nLast login: {2}", Name, Email, LastLogin);
        }



        public static IUser GetByEmail(string email)
        {
            foreach (var user in Users)
            {
                if (user.Email == email)
                    return user;
            }

            return null;
        }
    }
}
