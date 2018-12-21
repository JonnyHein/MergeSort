//Jonathan Hein
//Cpts 321
//HW10
//12/4/18
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class main
    {
        static void Main(string[] args)
        {
            List<int> List1; //for normal merge sort
            List<int> List2; //for threaded merge sort
            NumGenerator Lists = new NumGenerator();
            MSort MSort = new MSort();
            ThreadMSort ThreadMSort = new ThreadMSort();
            long start, finish, result;
            Console.WriteLine("Initializing tests for merge sort vs. threaded merge sort");
            //--------------------------------------------------------------- SIZE 8 -------------------------------------------------------------
            Console.WriteLine("Starting test for size 8");
            List1 = Lists.ListofSize(8); // Rand List of size 8
            List2 = List1; // Copy list
            start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            MSort.MergeSort(List1);
            finish = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            result = finish - start;
            Console.WriteLine("Normal sort time (ms) : "+result);
            start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            List2 = ThreadMSort.TMSort(List2);
            finish = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            result = finish - start;
            Console.WriteLine("Threaded sort time (ms) : " + result);
            //--------------------------------------------------------------- SIZE 64 ------------------------------------------------------------
            Console.WriteLine("Starting test for size 64");
            List1 = Lists.ListofSize(64); // Rand List of size 64
            List2 = List1; // Copy list
            start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            List1 = MSort.MergeSort(List1);
            finish = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            result = finish - start;
            Console.WriteLine("Normal sort time (ms) : " + result);
            start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            List2 = ThreadMSort.TMSort(List2);
            finish = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            result = finish - start;
            Console.WriteLine("Threaded sort time (ms) : " + result);
            //--------------------------------------------------------------- SIZE 256 -----------------------------------------------------------
            Console.WriteLine("Starting test for size 256");
            List1 = Lists.ListofSize(256); // Rand List of size 256
            List2 = List1; // Copy list
            start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            List1 = MSort.MergeSort(List1);
            finish = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            result = finish - start;
            Console.WriteLine("Normal sort time (ms) : " + result);
            start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            List2 = ThreadMSort.TMSort(List2);
            finish = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            result = finish - start;
            Console.WriteLine("Threaded sort time (ms) : " + result);
            //--------------------------------------------------------------- SIZE 1024 ----------------------------------------------------------
            Console.WriteLine("Starting test for size 1024");
            List1 = Lists.ListofSize(1024); // Rand List of size 1024
            List2 = List1; // Copy list
            start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            List1 = MSort.MergeSort(List1);
            finish = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            result = finish - start;
            Console.WriteLine("Normal sort time (ms) : " + result);
            start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            List2 = ThreadMSort.TMSort(List2);
            finish = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            result = finish - start;
            Console.WriteLine("Threaded sort time (ms) : " + result);
            //--------------------------------------------------------------- SIZE 4096 ----------------------------------------------------------
            Console.WriteLine("Starting test for size 4096");
            List1 = Lists.ListofSize(4096); // Rand List of size 1024
            List2 = List1; // Copy list
            start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            List1 = MSort.MergeSort(List1);
            finish = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            result = finish - start;
            Console.WriteLine("Normal sort time (ms) : " + result);
            start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            List2 = ThreadMSort.TMSort(List2);
            finish = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            result = finish - start;
            Console.WriteLine("Threaded sort time (ms) : " + result);
            Console.Read();
        }
    }
}
