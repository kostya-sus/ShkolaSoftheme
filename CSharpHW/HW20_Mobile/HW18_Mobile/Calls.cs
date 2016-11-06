
namespace HW18_Mobile
{
    public class Calls
    {
        public MobileAccount From { get; private set; }
        public MobileAccount ForWhom { get; private set; }

        public Calls(MobileAccount from, MobileAccount forWhom)
        {
            From = from;
            ForWhom = forWhom;
        }
    }
}
