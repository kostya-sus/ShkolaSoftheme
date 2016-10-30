

namespace HW12_IUser
{
    
        public interface IUser
        {
            string Name { get; set; }

            string Email { get; set; }

            int Password { get; }


            string GetFullInfo();
        }
    
}
