using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель
{
    public class Advertiser : Employee, IObserver
    {
        private IObservable taskPool;
        public Advertiser(IObservable taskPool,string name, NewTaskArrived newTaskArrived) : base(name, newTaskArrived)
        {
            this.taskPool = taskPool;
            taskPool.AddObserver(this);
        }

        public void Update(TypeOfWork newelyArrivedWork)
        {
            if (newelyArrivedWork==TypeOfWork.Advertise)
            {
                works.Add(newelyArrivedWork);

                OnTaskArrived(this, newelyArrivedWork);
            }
        }
    }
}
