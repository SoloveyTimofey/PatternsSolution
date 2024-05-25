using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель
{
    public class TaskPool : IObservable
    {
        List<IObserver> observers = new List<IObserver>();
        private List<TypeOfWork> works = new List<TypeOfWork>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify(TypeOfWork newelyArrivedWork)
        {
            foreach (var observer in observers)
            {
                observer.Update(newelyArrivedWork);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public List<TypeOfWork> GetWorks => works;
        public void AddNewWork(TypeOfWork work)
        {
            works.Add(work);
            Notify(work);
        }
    }

    public enum TypeOfWork
    {
        Advertise,
        Load,
        Sell,
        Manage,
        ExtendWebsite
    }
}
