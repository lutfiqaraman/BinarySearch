using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 45, 54, 60, 65, 69 };
            var item   = 54;
            
            Search BinarySearch = new Search(list, item);

            BinarySearch.Find();
            BinarySearch.Print();

            Console.ReadKey();
        }
    }
}