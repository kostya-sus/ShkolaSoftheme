using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Human
{
    class Human
    {
        //BirthDate, FirstName, Lastname, Age.
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age => DateTime.Now.Year - BirthDate.Year;


        public Human(string firstName)
        {
            FirstName = firstName;

        }


        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

       
         public Human(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            //Age = DateTime.Now.Year - BirthDate.Year;
        }



        public bool Equals(Human humanClone)
        {
            if (FirstName == humanClone.FirstName && LastName == humanClone.LastName && BirthDate == humanClone.BirthDate)
            {
                return true;
            }
            return false;
        }
    }
}
