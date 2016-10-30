using System;


namespace HW8_User
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbol = "Sus";
            var user = new User("Kostya");

            var symbolCopy = symbol;
            var userCopy = user;

            Console.WriteLine("value type copy: symbol = {0}, symbolCopy = {1}.", symbol, symbolCopy);
            Console.WriteLine("reference type after copy. user.Name = {0}, userCopy.Name = {1}.\n", user.FirstName, userCopy.FirstName);

            symbolCopy = "Petrov";
            userCopy.FirstName = "Hrihorii";


            Console.WriteLine("value types changed: symbol = {0}, symbolCopy = {1}.", symbol, symbolCopy);
            Console.WriteLine("reference type changed: user.FirstName = {0}, userCopy.FirstName = {1}.", user.FirstName, userCopy.FirstName);
            
            Console.ReadKey();
        }
    }
}
