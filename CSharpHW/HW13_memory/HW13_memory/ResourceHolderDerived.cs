using System;


namespace HW13_memory
{
    class ResourceHolderDerived:ResourceHolderBase
    {

        private bool _disposed;

        public int nubmer { get; set; }
        public string name { get; set; }

        protected override void Dispose(bool disposing)
        {
            if (_disposed)
            {
                Console.WriteLine("Derived already disposed");
                return;
            }

            if (disposing)
            {
                Console.WriteLine("Derived free managed resources");
            }

            Console.WriteLine("Derived free unmanaged resources");
            _disposed = true;

            base.Dispose(disposing);
        }


        ~ResourceHolderDerived()
        {
            Console.WriteLine("Deriverd: finalizer called.");
            Dispose(false);
        }


    }
}
