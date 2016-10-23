using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace HW4_RegistrationForm
{
    public partial class MainWindow : Window
    {
        private const string LENGTH_ERROR = "Lenght must be less than 255 and more then 0";
        private const string LENGTH_PHONE_NUMBER_ERROR = "Lenght must be sumbol 12";
        private const string LENGTH_ADD_INFO_ERROR = "Lenght should be less than 2000";
        private const string YEAR_ERROR = "Year should be between 1990 and current year";

        private const string CONTAINS_LETTER_ERROR = "Field must contains only letters";
        private const string CONTAINS_NUMBERS_ERROR = "Field contains only numbers";

        private const string INCORRECT_GENDER = "Chose only male or female";
        private const string EMAIL_ERROR = "Email should contain @";
        
        
        private const string EMPTY = "It's empty please enter info";
        private const string successful = "successful";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Validate(object sender, RoutedEventArgs e)
        {
            ValFirstName();
            ValLastName();
            ValBirthDate();
            ValGender();
            ValEmail();
            ValPhoneNumber();
            ValAddInfo();
        }

        private void ValFirstName()
        {
            var firstName = FirstName.Text;
            if ((firstName.Length > 255) || (String.IsNullOrEmpty(firstName)))
            {
                FirstNameVal.Text = LENGTH_ERROR;
            }
            else if(!Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
            {
                FirstNameVal.Text = CONTAINS_LETTER_ERROR;
            }
            else
            {
                FirstNameVal.Text = successful;
            }
        }

        private void ValLastName()
        {
            var lastName = LastName.Text;
            if ((lastName.Length > 255) || (String.IsNullOrEmpty(lastName)))
            {
                LastNameVal.Text = LENGTH_ERROR;
            }
            else if (!Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
            {
                LastNameVal.Text = CONTAINS_LETTER_ERROR;
            }
            else LastNameVal.Text = successful;
        }

        private void ValBirthDate()
        {
            var birthDate = BirthDate.Text;
            var exMessage = "";

            DateTime birthDateDt = DateTime.Now;
            try
            {
                birthDateDt = DateTime.Parse(birthDate);
            }
            catch (FormatException e)
            {
                exMessage = e.Message;
            }

            
            if (!Regex.IsMatch(birthDate, @"[0-9]+"))
            {
                BirthDateVal.Text = CONTAINS_NUMBERS_ERROR;
            }
            else if ((birthDateDt.Year < 1990) || (birthDateDt.Year > DateTime.Now.Year))
            {
                BirthDateVal.Text = YEAR_ERROR;
            }
            else if (string.IsNullOrEmpty(exMessage))
            {
                    BirthDateVal.Text = successful;
            }else BirthDateVal.Text = exMessage;
            

            

        }

        private void ValGender()
        {
            var gender = Gender.Text;

            if (String.IsNullOrEmpty(gender))
            {
                GenderVal.Text = EMPTY;
            }
            else if (gender == "male" || gender == "female")
            {
                GenderVal.Text = successful;
            }
            else
            {
                GenderVal.Text = INCORRECT_GENDER;
            }
        }

        private void ValEmail()
        {
            var email = Email.Text;
            if (String.IsNullOrEmpty(email))
            {
                EmailVal.Text = EMPTY;
            }
            else if ((!email.Contains("@"))||(!email.Contains(".")))
            {
                EmailVal.Text = EMAIL_ERROR;
            }
            else if (email.Length > 255)
            {
                EmailVal.Text = LENGTH_ERROR;
            }
            else
            {
                EmailVal.Text = successful;
            }
        }

        private void ValPhoneNumber()
        {
            var phoneNumber = PhoneNumber.Text;
            if (String.IsNullOrEmpty(phoneNumber))
            {
                PhoneNumberVal.Text = EMPTY;
            }
            else if (phoneNumber.Length !=12)
            {
                PhoneNumberVal.Text = LENGTH_PHONE_NUMBER_ERROR;
            }
            else if (!Regex.IsMatch(phoneNumber, @"[0-9]+"))
            {
                PhoneNumberVal.Text = CONTAINS_NUMBERS_ERROR;
            }
            else
            {
                PhoneNumberVal.Text = successful;
            }
        }

        private void ValAddInfo()
        {
            var addInfo = AddInfo.Text;
            if (String.IsNullOrEmpty(addInfo))
            {
                AddInfoVal.Text = EMPTY;
            }
            else if (addInfo.Length > 2000)
            {
                AddInfoVal.Text = LENGTH_ADD_INFO_ERROR;
            }
            else AddInfoVal.Text = successful;
          }

        private void FirstName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (FirstName.Text.Length > 0)
            {
                FirstNameVal.Text = "";
            }
            else if (FirstName.Text.Length == 0)
            {
                FirstNameVal.Text = EMPTY;
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
                LastNameVal.Text = EMPTY;
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
                BirthDateVal.Text = EMPTY;
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
                GenderVal.Text = EMPTY;
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
                EmailVal.Text = EMPTY;
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
                PhoneNumberVal.Text = EMPTY;
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
                AddInfoVal.Text = EMPTY;
            }
        }

        
        
    }
}