using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фасад
{
    public class EmployeeOffice
    {
        public List<Employee> Employees { get; set; } = new List<Employee>
        {
            new Manager("Suda"),
            new Manager("John"),
            new Loader("Pitter"),
            new Loader("Morrissey"),
            new Loader("Varvatos"),
            new Loader("Pedro"),
            new Loader("Joe")
        };
    }
}
