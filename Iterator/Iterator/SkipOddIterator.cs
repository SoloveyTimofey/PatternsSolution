using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итератор.Iterator
{
    internal class SkipOddIterator : Iterator<int>
    {
        private int[] _items;
        private int _current;
        public SkipOddIterator(int[] items)
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
        public override void First()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] %2==0)
                {
                    _current = i;
                    return;
                }
            }
        }
        public override void Next()
        {
            if (!IsDone())
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i =++_current;i<_items.Length;i++ )
            {
                if (_items[i]%2==0)
                {
                    _current = i;
                    return;
                }
            }
        }
        public override bool IsDone() => !(_current >= _items.Length);
    }
}
