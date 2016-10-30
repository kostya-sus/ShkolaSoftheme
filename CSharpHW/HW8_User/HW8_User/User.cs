using System;


namespace HW8_User
{
    class User
    {
        //BirthDate, FirstName, Lastname, Age.
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        


        public User(string firstName)
        {
            FirstName = firstName;

        }


        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
