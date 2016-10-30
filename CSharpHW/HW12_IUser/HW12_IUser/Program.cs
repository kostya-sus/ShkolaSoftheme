using System;
using System.Collections.Generic;


namespace HW12_IUser
{
    class Program
    {
        static void Main(string[] args)
        {
            User.Users = new List<IUser>() { new User("", "", "") };

            SingIn();

            Console.WriteLine("Session compleat");
            Console.ReadLine();
        }

        public static void SingIn()
        {
            string email,
                   password;
            bool correct=false;

            IUser currentUser;
            IValidator validator = new Validator();


            do
            {
                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Password: ");
                password = Console.ReadLine();

                if ((email)==("exit") || (password)== ("exit"))
                {
                    correct = true;
                    continue;
                }


                if ((currentUser = User.GetByEmail(email)) == null)
                {
                    currentUser = SingUp();

                    Console.WriteLine("Registered a new user!");
                    Console.WriteLine(currentUser.GetFullInfo());
                }
                else if (validator.ValidateUser(currentUser, password))
                {

                    Console.WriteLine(currentUser.GetFullInfo());
                    
                }

                Console.WriteLine();

            } while (!correct);
        }

        public static IUser SingUp()
        {
           

            string name,
                   email,
                   password;
            bool Correct;


            Console.WriteLine("\nYou need to creat userr: ");
            do
            {
                Correct = true;

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Password: ");
                password = Console.ReadLine();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("\nThe field cann't be empty!\n");
                    Correct = false;

                }

            } while (!Correct);


            IUser newUser = new User(name, email, password);

            User.Users.Add(newUser);

            return newUser;
        }
    }
}
