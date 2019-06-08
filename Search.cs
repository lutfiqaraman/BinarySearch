using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Search
    {
        private int[] _list;
        private int   _item;
        private int   result;

        public Search(int[] list, int item)
        {
            _list = list;
            _item = item;
        }

        public int Find()
        {
            var low    = 0;
            var high   = _list.Length - 1;

            while (low <= high)
            {
                var mid = (low + high) / 2;
                var guess = _list[mid];

                if (guess == _item)
                    result = mid;

                if (guess > _item)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return result;
        }

        public void Print()
        {
            if (result == 0)
                Console.WriteLine("item {0} is not found", _item);
            else
                Console.WriteLine("Item {0} found in Position {1}", _item, result + 1);
        }

    }
}
