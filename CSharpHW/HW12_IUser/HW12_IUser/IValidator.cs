

namespace HW12_IUser
{
    public interface IValidator
    {
        bool ValidateUser(IUser user, string password);
    }
}
