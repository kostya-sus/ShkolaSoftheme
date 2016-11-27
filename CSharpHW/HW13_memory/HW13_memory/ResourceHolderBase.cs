using System;


namespace HW13_memory
{
    class ResourceHolderBase : IDisposable
    {
        private bool _disposed;

        public int nubmer { get; set; }
        public string name { get; set; }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                Console.WriteLine("Base already disposed");
                return;
            }

            if (disposing)
            {
                Console.WriteLine("Base free managed resources");
            }

            Console.WriteLine("Base free unmanaged resources");
            _disposed = true;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ResourceHolderBase()
        {
            Console.WriteLine("Base: finalizer called.");
            Dispose(false);
        }
    }
}
