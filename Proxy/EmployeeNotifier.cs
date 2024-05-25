using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Заместитель
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
            foreach (var employee in employees.Where(emp=>emp is Manager).Take(rand.Next(1,2)).Union(employees.Where(emp=>emp is Loader).Take(rand.Next(1,5))))
            {
                employee.NewProductArrived(product);
            }

        }
    }
}
