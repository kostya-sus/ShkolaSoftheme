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

namespace HW6_RandomNumber
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

       

        private void Play_Click(object sender, RoutedEventArgs e)
        {

            Random random = new Random();
            var rNumber = random.Next(10);

            try
            {
                var uNumber = Int32.Parse(UNumber.Text);
                if (rNumber == uNumber)
                {
                    MessageBox.Show("It was " + rNumber, "You win");
                }
                else
                {
                    MessageBox.Show("It was " + rNumber, "You lose! Try more");
                };
            }
            
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void UNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
