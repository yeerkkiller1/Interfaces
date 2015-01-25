using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodInterfaces.Memory
{
    public interface IDisposeWatchable : IDisposable
    {
        int OnDispose(Action action);
        void OffDispose(int id);
        bool IsDisposed();
    }
}
