using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фасад
{
    public class StockFacade
    {
        private Database Database { get; set; }
        private EmployeeOffice EmployeeOffice { get; set; }
        private EmployeeNotifier EmployeeNotifier { get; set; }
        public StockFacade()
        {
            Database = new Database();
            EmployeeOffice = new EmployeeOffice();
            EmployeeNotifier = new EmployeeNotifier(EmployeeOffice.Employees);
        }

        public void NewProductArrived(string product)
        {
            Database.AddProduct(product);
            EmployeeNotifier.NewProductArrived(product);
        }
    }
}
