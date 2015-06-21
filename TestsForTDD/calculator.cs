using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestsForTDD
{
    class Calculator
    {
        internal int FindMAx(int[] arr)
        {            
            if (arr != null && arr.Any())
            {
                int max = arr[0];
                for (int i = 0; i < arr.Count(); i++)
                {
                    if (arr[i] > max)
                        max = arr[i];
                }
                return max;
            }
            else
                throw new Exception("Null or empty array");
        }
    }
}
