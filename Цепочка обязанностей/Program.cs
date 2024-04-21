using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цепочка_обязанностей
{
    public class Program
    {
        private static void GiveCommand(Employee worker, TypeOfWork typeOfWork)
        {
            string result = worker.Execute(typeOfWork);
            if (result == String.Empty)
            {
                Console.WriteLine($"There is no worker to do {typeOfWork}");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        static EmployeeOffice office = new EmployeeOffice();
        static void Main(string[] args)
        {
            Manager manager = office.GetByName("Suda") as Manager;
            Loader loader = office.GetByName("Pitter") as Loader;
            Seller seller = office.GetByName("Adam") as Seller;
            Advertiser advertiser = office.GetByName("Barbara") as Advertiser;

            manager.SetNextEmployee(loader).SetNextEmployee(seller).SetNextEmployee(advertiser);

            GiveCommand(manager, TypeOfWork.Load);
            GiveCommand(manager, TypeOfWork.Manage);
            GiveCommand(manager, TypeOfWork.Sell);
            GiveCommand(manager, TypeOfWork.ExtendWebsite);

            Console.ReadLine();
        }
    }
}
