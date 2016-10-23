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

namespace HW2_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "9";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "0";
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += ".";
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {

           
            int position = 0;
            
            if (screen.Text.Contains("+"))
            {
                position = screen.Text.IndexOf("+");
            }
            else if (screen.Text.Contains("-"))
            {
                position = screen.Text.IndexOf("-");
            }
            else if (screen.Text.Contains("*"))
            {
                position = screen.Text.IndexOf("*");
            }
            else if (screen.Text.Contains("/"))
            {
                position = screen.Text.IndexOf("/");
            }
            else
            {
                 
            }
            String symbol;

            symbol = screen.Text.Substring(position, 1);
            double part1 = Convert.ToDouble(screen.Text.Substring(0, position));
            double part2 = Convert.ToDouble(screen.Text.Substring(position + 1, screen.Text.Length - position - 1));

        
            switch (symbol)
            {
                case "+":
                    screen.Text += "=" + Math.Round((part1 + part2), 2);
                    break;
                case "-":
                    screen.Text += "=" + Math.Round((part1 - part2), 2);
                    break;
                case "*":
                    screen.Text += "=" + Math.Round((part1 * part2), 2);
                    break;
                case "/":
                    screen.Text += "=" + Math.Round((part1 / part2), 2);
                    break;
            }

        }
       

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = "";
        }

        private void sum_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "+";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "-";
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "*";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "/";
        }

        
    }
}
