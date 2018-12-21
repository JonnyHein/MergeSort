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
    class NumGenerator
    {
        public List<int> ListofSize(int size)
        {
            Random num = new Random();
            List<int> mylist = new List<int>();
            for(int i=0; i<size; i++)
            {
                int ran = num.Next(0, Int32.MaxValue);
                mylist.Add(ran);
            }
            return mylist;
        }
    }
}
