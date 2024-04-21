using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итератор.Iterator
{
    public class OneDementionalIterator : Iterator<int>
    {
        private int[] _items;
        private int _current;
        public OneDementionalIterator(int[] items)
        {
            _items = items;
        }

        public override int CurrentItem()
        {
            if (!IsDone())
            {
                throw new ArgumentOutOfRangeException();
            }
            return _items[_current];
        }
        public override void First() => _current = 0;
        public override void Next()=>_current++;
        public override bool IsDone() => !(_current >= _items.Length);

    }
}
