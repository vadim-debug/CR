using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    interface ISubjectObserverable
    {
        void Add(IpropertyObserver observer);
        void Remove(IpropertyObserver observer);
        void Notify(string message);
    }
    internal class Shop: ISubjectObserverable
    {
        public void Add(IpropertyObserver observer) { }
        public void Remove(IpropertyObserver observer) { }
        public void Notify(string message) { }

    }
}
