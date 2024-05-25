using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итератор.Iterator
{
    public abstract class Iterator<T>
    {
        protected Iterator() 
        {
        }

        public virtual void First()
        {

        }
        public virtual void Next()
        {

        }
        public virtual bool IsDone()
        {
            return default(bool);
        }
        public virtual T CurrentItem()
        {
            return default(T);
        }


    }
}
