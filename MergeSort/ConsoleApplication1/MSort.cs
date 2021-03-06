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
    class MSort
    {
        public List<int> MergeSort(List<int> unsortedList)
        {
            if (unsortedList.Count <=1)
            {
                return unsortedList;
            }
            int midIndex = unsortedList.Count / 2;
            List<int> L = new List<int>();
            List<int> R = new List<int>();

            L = MergeSort(unsortedList.GetRange(0,midIndex)); //recursively splits left side of unsorted list until count <=1
            R = MergeSort(unsortedList.GetRange(midIndex, unsortedList.Count - midIndex)); // ^^ For right
            return Merge(L, R); //
        }
        private List<int> Merge(List<int> Left, List<int> Right)
        {
            List<int> SortedList = new List<int>();
            int IndexL = 0;
            int IndexR = 0;
            while(IndexL < Left.Count || IndexR < Right.Count) //while left or right array has int
            {
                if(IndexL < Left.Count && IndexR < Right.Count) //check to make sure both have element so that comparison can happen, otherwise no comparison needed
                {
                    if (Left[IndexL]<=Right[IndexR]) 
                    {
                        SortedList.Add(Left[IndexL]);
                        IndexL++;
                    }
                    else
                    {
                        SortedList.Add(Right[IndexR]);
                        IndexR++;
                    }
                }
                else if(IndexL < Left.Count) //right does not have int so no comparison
                {
                    SortedList.Add(Left[IndexL]);
                    IndexL++;
                }
                else if(IndexR < Right.Count)
                {
                    SortedList.Add(Right[IndexR]); //let does not have int so no comparison
                    IndexR++;
                }
            }
            return SortedList;
        }
    }
}
