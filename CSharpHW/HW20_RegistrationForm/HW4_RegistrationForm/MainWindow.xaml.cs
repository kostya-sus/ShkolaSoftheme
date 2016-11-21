using System.Windows;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace HW4_RegistrationForm
{
    public partial class MainWindow : Window
    {
        private const string Empty = "It's empty please enter info";
       
        private void Validate(object sender, RoutedEventArgs e)
        {
             var registrationForm = new Registration() {
                                                         FirstName = FirstName.Text,
                                                         LastName = LastName.Text,
                                                         BirthDay = BirthDate.Text,
                                                         Gender = Gender.Text,
                                                         Email = Email.Text,
                                                         PhoneNumber = PhoneNumber.Text,
                                                         AdditionalInfo = AddInfo.Text
                                                                                        };
            var results = new List<ValidationResult>();
            var context = new ValidationContext(registrationForm);

            if (!Validator.TryValidateObject(registrationForm, context, results, true))
                foreach (var error in results)
                    MessageBox.Show(error.ErrorMessage);
            else
                MessageBox.Show("Good work!It successful");
        }
                 

        private void FirstName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (FirstName.Text.Length > 0)
            {
                FirstNameVal.Text = "";
            }
            else if (FirstName.Text.Length == 0)
            {
                FirstNameVal.Text = Empty;
            }
        }

        private void LastName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (LastName.Text.Length > 0)
            {
                LastNameVal.Text = "";
            }
            else if (LastName.Text.Length == 0)
            {
                LastNameVal.Text = Empty;
            }
        }

        private void BirthDate_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (BirthDate.Text.Length > 0)
            {
                BirthDateVal.Text = "";
            }
            else if (BirthDate.Text.Length == 0)
            {
                BirthDateVal.Text = Empty;
            }
        }

        private void Gender_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Gender.Text.Length>0)
            {
                GenderVal.Text = "";
            }
            else if (Gender.Text.Length==0)
            {
                GenderVal.Text = Empty;
            }
        }
        
        private void Email_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Email.Text.Length > 0)
            {
                EmailVal.Text = "";
            }
            else if (Email.Text.Length == 0)
            {
                EmailVal.Text = Empty;
            }
        }

        private void PhoneNumber_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (PhoneNumber.Text.Length > 0)
            {
                PhoneNumberVal.Text = "";
            }
            else if (PhoneNumber.Text.Length == 0)
            {
                PhoneNumberVal.Text = Empty;
            }
        }

        private void AddInfo_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (AddInfo.Text.Length > 0)
            {
                AddInfoVal.Text = "";
            }
            else if (AddInfo.Text.Length == 0)
            {
                AddInfoVal.Text = Empty;
            }
        }

       
    }
}