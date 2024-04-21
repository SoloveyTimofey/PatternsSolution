using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель
{
    public delegate void NewTaskArrived(Employee employee, TypeOfWork work);
    public abstract class Employee
    {
        public event NewTaskArrived TaskArrivedEvent;

        public List<TypeOfWork> works = new List<TypeOfWork>();
        public string Name { get; set; }
        protected Employee(string name, NewTaskArrived newTaskArrived)
        {
            TaskArrivedEvent = newTaskArrived;
            Name = name;
        }

        protected virtual void OnTaskArrived(Employee sender, TypeOfWork work)
        {
            TaskArrivedEvent?.Invoke(sender, work);
        }
    }
}
