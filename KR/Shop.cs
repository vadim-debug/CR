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
        private HashSet<IpropertyObserver> observers= new HashSet<IpropertyObserver> ();
        public void Add(IEnumerable <IpropertyObserver> observer) 
        {
            foreach (var o in observer) Add(o); 
        }

        public void Add(IpropertyObserver observer) => observers.Add(observer);


        public void Remove(IpropertyObserver observer) => observers.Remove(observer);
        public void Notify(string message) {
            foreach (var observer in observers)
            {

            }
        }

    }
}
