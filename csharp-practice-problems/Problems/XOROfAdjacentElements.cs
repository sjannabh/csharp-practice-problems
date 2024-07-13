namespace csharp_practice_problems.Problems
{
    public class XOROfAdjacentElements
    {
        public void xorOfElements(int[] arr)
        {
            for(int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = arr[i] ^ arr[i+1];
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
        }
    }
}
