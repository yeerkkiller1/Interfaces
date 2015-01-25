using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDisposeWatchable : IDisposable
    {
        int OnDispose(Action action);
        void OffDispose(int id);
        bool IsDisposed();
    }
}
