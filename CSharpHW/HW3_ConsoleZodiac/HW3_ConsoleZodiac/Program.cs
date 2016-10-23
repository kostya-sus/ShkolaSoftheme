using System;
using System.Globalization;

namespace HW3_ConsoleZodiac
{
    class BirthDateRecurseValidation
    {
        private const string Capricorn = "Capricorn";
        private const string Aquarius = "Aquarius";
        private const string Pisces = "Pisces";
        private const string Aries = "Aries";
        private const string Taurus = "Taurus";
        private const string Gemini = "Gemini";
        private const string Cancer = "Cancer";
        private const string Leo = "Leo";
        private const string Virgo = "Virgo";
        private const string Libra = "Libra";
        private const string Scorpio = "Scorpio";
        private const string Sagittarius = "Sagittarius";
        

        static void Main(string[] args)
        {
            DateTime date = CheckDate();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your zodiac sign is " + DefineZodiac(date));
            Console.ReadKey();
            
        }

        private static DateTime CheckDate()
        {
            DateTime date;
            Console.WriteLine("Enter your birth date in DD/MM/YYYY format:");
            string input = Console.ReadLine();

            if (DateTime.TryParseExact (input, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.AdjustToUniversal,out date) )
            {
                return date;
            }//recursion
            else return CheckDate();
            
        }

        private static string DefineZodiac(DateTime date)
        {
            int month = date.Month, day = date.Day;
            
            switch (month)
            {
                case 1:
                    if (day <= 19) return Capricorn;
                    return Aquarius;

                case 2:
                    if (day <= 18) return Aquarius;
                    return Pisces;

                case 3:
                    if (day <= 20) return Pisces;
                    return Aries;

                case 4:
                    if (day <= 19) return Aries;
                    return Taurus;

                case 5:
                    if (day <= 20) return Taurus;
                    return Gemini;
                case 6:
                    if (day <= 20) return Gemini;
                    return Cancer;

                case 7:
                    if (day <= 22) return Cancer;
                    return Leo;

                case 8:
                    if (day <= 22) return Leo;
                    return Virgo;

                case 9:
                    if (day <= 22) return Virgo;
                    return Libra;

                case 10:
                    if (day <= 22) return Libra;
                    return Scorpio;

                case 11:
                    if (day <= 21) return Scorpio;
                    return Sagittarius;

                case 12:
                    if (day <= 21) return Sagittarius;
                    return Capricorn;
            }
            return null;
        }

       
    }
}