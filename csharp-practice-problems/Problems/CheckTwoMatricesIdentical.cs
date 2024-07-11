namespace csharp_practice_problems.Problems
{
    public class CheckTwoMatricesIdentical
    {
        public void CheckIdentical(int[,] arr1, int[,] arr2)
        {
            bool flag = false;
            int rowArr1 = arr1.GetLength(0);
            int colArr1 = arr1.GetLength(1);
            int rowArr2 = arr2.GetLength(0);
            int colArr2 = arr2.GetLength(1);

            if(rowArr1 == rowArr2 && colArr1 == colArr2)
            {
                for(int i=0;i<arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr1.GetLength(1); j++)
                    {
                        if (arr1[i, j] == arr2[i, j])
                        {
                            flag = true; 
                            continue;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == false) break;
                }
            }
            else
            {
                flag = false;
            }

            if (flag)
            {
                Console.WriteLine("Matrices are identical");
            }
            else
            {
                Console.WriteLine("Matrices are not identical");
            }
        }
    }
}
