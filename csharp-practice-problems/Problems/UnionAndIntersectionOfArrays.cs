namespace csharp_practice_problems.Problems
{
    public class UnionAndIntersectionOfArrays
    {
        public void FindUnion(int[] arr1, int[] arr2)
        {
            HashSet<int> set = new HashSet<int>();
            
            for(int i = 0; i < arr1.Length; i++)
            {
                set.Add(arr1[i]);
            }
            for(int j=0;j< arr2.Length; j++)
            {
                set.Add(arr2[j]);
            }
            Console.WriteLine("Union");
            Console.WriteLine(string.Join(", ", set));
        }
        public void FindIntersection(int[] arr1, int[] arr2) 
        {
            Console.WriteLine("Intersection");
            HashSet<int> hs = new HashSet<int>();
            for(int i = 0; i < arr1.Length; i++)
            {
                hs.Add(arr1[i]);
            }
            for(int j = 0; j < arr2.Length; j++)
            {
                if (hs.Contains(arr2[j]))
                {
                    Console.Write(arr2[j] + " ");
                }
                else
                {
                    hs.Add(arr2[j]);
                }
            }
        }

    }
}
