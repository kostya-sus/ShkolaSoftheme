

namespace HW12_IUser
{
    public class Validator : IValidator
    {
        public bool ValidateUser(IUser user, string password)
        {
            if (user == null)
                return false;

            if (user.Password.Equals(password.GetHashCode()))
                return true;

            return false;
        }
    }
}
