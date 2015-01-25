using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodInterfaces
{
    interface IObserv<T>
    {
        bool HasBeenSet { get; }
        T Get();
        void Set(T newValue);
        /// <param name="callIfSet"> This means, if HasBeenSet, we will call your handler. Basically: 
        /// int id = x.Subscribe(handler, false); if(x.HasBeenSet) handler(x.Get(), id);
        /// ==
        /// x.Subscribe(handler, true)</param>
        /// <returns>Unique id (probably, until we wrap around the integer :P) that canb e used to destroy the observable.</returns>
        int Subscribe(Action<T> handler, bool callIfSet = true);
        void Unsubscribe(int id);
    }
}
