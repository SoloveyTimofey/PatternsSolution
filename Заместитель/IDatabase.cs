using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Заместитель
{
    public interface IDatabase
    {
        void AddProduct(string product);
        List<string> GetProducts();
    }
}
