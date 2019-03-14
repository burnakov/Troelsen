using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizableDisposableClass
{
    class MyResourceWrapper : IDisposable
    {
        private bool disposed = false;
        public void Dispose()
        {
            CleanUp(true); // true to dispose managed resources. Still exist. Object clearing invoked by user
            GC.SuppressFinalize(this); // No need in finalization anymore
        }

        private void CleanUp(bool disposing)
        {
            if (!this.disposed) // If not allready disposed
            {
                if (disposing)
                {
                    // Dispose managed resources
                }
            // Clear unmanaged resources
        }
        disposed = true;
        }
        ~MyResourceWrapper()
        {
            Console.Beep();
            CleanUp(false); // false suppress disposing managed resources. May not exist. Object clearing invoked by GC
        }
    }
}
