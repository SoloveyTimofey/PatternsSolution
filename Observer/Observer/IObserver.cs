using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Наблюдатель
{
    public interface IObserver
    {
        void Update(TypeOfWork newelyArrivedWork);
    }
}
