using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель
{
    public class Seller : Employee, IObserver
    {
        IObservable observable;
        public Seller(IObservable taskPool, string name, NewTaskArrived newTaskArrived) : base(name, newTaskArrived)
        {
            this.observable = taskPool;
            taskPool.AddObserver(this);
        }

        public void Update(TypeOfWork newelyArrivedWork)
        {
            if (newelyArrivedWork == TypeOfWork.Sell)
            {
                works.Add(newelyArrivedWork);

                OnTaskArrived(this, newelyArrivedWork);
            }
        }
    }
}
