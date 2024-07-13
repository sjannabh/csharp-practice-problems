using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_practice_problems.Problems
{
    //Given an array of n integers and a positive number k. We are allowed to take any k integers from the given array.
    //The task is to find the minimum possible value of the difference between maximum and minimum of K numbers.
    public class MimimumPossibleValue
    {
        public void minDiff(int[] arr, int k)
        {
            int n = arr.Length;
            int result = int.MaxValue;

            Array.Sort(arr);

            for(int i=0;i<= n-k; i++)
            {
                result = Math.Min(result, arr[i + k - 1] - arr[i]);
            }
            Console.WriteLine(result);
        }
    }
}
