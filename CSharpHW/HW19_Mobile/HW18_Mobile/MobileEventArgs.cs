using System;


namespace HW18_Mobile
{
    public class MobileEventArgs : EventArgs
    {
        public MobileOperation Operation { get; private set; }
        public MobileAccount ForWhom { get; private set; }
        public string Message { get; private set; }

        public MobileEventArgs(MobileOperation operation, MobileAccount forWhom)
        {
            Operation = operation;
            ForWhom = forWhom;
        }

        public MobileEventArgs(MobileOperation operation, MobileAccount forWhom, string message): this(operation, forWhom)
        {
            Message = message;
        }
    }
}
