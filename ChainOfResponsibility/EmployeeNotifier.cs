using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цепочка_обязанностей
{
    public class EmployeeNotifier
    {
        private List<Employee> employees;
        public EmployeeNotifier(List<Employee> employees)
        {

            this.employees = employees;
        }
        public void NewProductArrived(string product)
        {
            Random rand = new Random();
            foreach (var employee in employees.Where(emp=>emp is Manager).Take(rand.Next(1,2))
                .Union(employees.Where(emp=>emp is Loader).Take(rand.Next(1,5)))
                .Union(employees.Where(emp=>emp is Seller).Take(1))
                .Union(employees.Where(emp=>emp is Advertiser).Take(1)))
            {
                employee.NewProductArrived(product);
            }

        }
    }
}
