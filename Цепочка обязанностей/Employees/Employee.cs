using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цепочка_обязанностей
{

    public abstract class Employee
    {
        private Employee nextEmployee;
        protected Employee(string name)
        {
            this.Name = name;
            nextEmployee = null;
        }
        public string Name { get;set;}

        public virtual string Execute(TypeOfWork command)
        {
            if (nextEmployee!=null)
            {
                return nextEmployee.Execute(command);
            }
            else
            {
                return string.Empty;
            }            
        }

        public virtual Employee SetNextEmployee(Employee employee)
        {
            nextEmployee = employee;
            return nextEmployee;
        }

        public abstract void NewProductArrived(string product);
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
