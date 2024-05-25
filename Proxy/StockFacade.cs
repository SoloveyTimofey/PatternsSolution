using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Заместитель
{
    public class StockFacade
    {
        private IDatabase Database { get; set; }
        private EmployeeOffice EmployeeOffice { get; set; }
        private EmployeeNotifier EmployeeNotifier { get; set; }
        public StockFacade(IDatabase database)
        {
            Database = database;
            EmployeeOffice = new EmployeeOffice();
            EmployeeNotifier = new EmployeeNotifier(EmployeeOffice.Employees);
        }

        public void NewProductArrived(string product)
        {
            Database.AddProduct(product);
            EmployeeNotifier.NewProductArrived(product);
        }

        public List<string> GetProducts()
        {
            return Database.GetProducts();
        }
    }
}
