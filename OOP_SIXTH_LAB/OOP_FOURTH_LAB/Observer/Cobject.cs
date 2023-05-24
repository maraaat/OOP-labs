using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SIXTH_LAB.Observer
{
    public class Cobject
    {
        public List<Cobserver> _observers = new List<Cobserver>();

        protected string Name;
        virtual public String Who()
        {
            return Name;
        }

        virtual public void AddObserver(Cobserver o)
        {
            _observers.Add(o);
        }
        virtual public void RemoveObserver()
        {
            _observers.Clear();
        }

        virtual public void NotifyEveryone()
        {
            foreach (Cobserver o in _observers)
            {
                o.OnSubjectChanged(this);
            }
        }

        virtual public void NotifyEveryoneSelect()
        {
            foreach (Cobserver o in _observers)
            {
                o.OnSubjectSelect(this);
            }
        }

        virtual public void NotifyEveryoneMove(int x, int y)
        {
            foreach (Cobserver o in _observers)
            {
                o.OnSubjectMove(x, y);
            }
        }


        public virtual void Dispose()
        {
        }
    }
}
