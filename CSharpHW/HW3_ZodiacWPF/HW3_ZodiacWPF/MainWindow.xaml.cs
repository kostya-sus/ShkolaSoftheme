using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;



namespace HW3_ZodiacWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
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

        public MainWindow()
        {
            InitializeComponent();
        }

                 

        private static DateTime CheckDate(string s)
        {
                DateTime date;
                Console.WriteLine("Enter your birth date in DD/MM/YYYY format:");

                string input = s;

                if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.AdjustToUniversal, out date))
                {
                    return date;
                }//recursion
                else return CheckDate(s);
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

        private void inputBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
           
            DateTime date = CheckDate(textBox.Text);
            zodiacName.Text = DefineZodiac(date);
            string s = "/images/"+ DefineZodiac(date) + ".jpg";
            show.Source = new BitmapImage(new Uri (s, UriKind.Relative));
        


        }
    }
}
