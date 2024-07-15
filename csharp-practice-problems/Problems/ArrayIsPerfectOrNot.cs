using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_practice_problems.Problems
{
    public class ArrayIsPerfectOrNot
    {
        public bool IsPerfect(int[] arr)
        {
            int i = 1;
            int n = arr.Length;

            while (i < n && arr[i] > arr[i - 1])
                ++i;

            while (i < n && arr[i] == arr[i - 1])
                ++i;

            while (i < n && arr[i] < arr[i - 1])
                ++i;

            return (i == n);
        }
    }
}
