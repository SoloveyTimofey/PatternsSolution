using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskPool observable = new TaskPool();
            NewTaskArrived newTaskArrived = delegate (Employee sender, TypeOfWork typeOfWork)
            {
                Console.WriteLine($"{sender.Name} working on {typeOfWork}. Now {sender.Name} have these works:");
                foreach (var work in sender.works)
                {
                    Console.WriteLine(work);
                }
            };

            Loader observer1 = new Loader(observable,"John",newTaskArrived);
            Seller observer2 = new Seller(observable, "Marry", newTaskArrived);
            Advertiser observer3 = new Advertiser(observable, "Pitter", newTaskArrived);      

            observable.AddNewWork(TypeOfWork.Sell);
            Console.WriteLine();

            observable.AddNewWork(TypeOfWork.Advertise);
            Console.WriteLine();

            observable.AddNewWork(TypeOfWork.Load);
            Console.WriteLine();

            observable.AddNewWork(TypeOfWork.Sell);
            Console.WriteLine();

            Console.ReadLine();
        }

        public static void TaskArrived(Employee sender, TypeOfWork work)
        {
            Console.WriteLine($"{sender.Name} working on {work}");
        }

    }
}
