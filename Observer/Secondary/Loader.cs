using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель
{
    public class Loader : Employee,IObserver
    {
        IObservable observable;
        public Loader(IObservable taskPool, string name, NewTaskArrived newTaskArrived) : base(name, newTaskArrived)
        {
            this.observable = taskPool;
            taskPool.AddObserver(this);
        }

        public void Update(TypeOfWork newelyArrivedWork)
        {
            if (newelyArrivedWork == TypeOfWork.Load)
            {
                works.Add(newelyArrivedWork);

                OnTaskArrived(this, newelyArrivedWork);
            }
        }
    }
}
