using System;

namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
      public int Find(int[] numbers)
      {
            for (int index = 0; index < numbers.Length; index++)
            {
                //split and sum numbers left of index
                var leftSum = Sum(SplitArray(numbers, 0, index + 1));

                //split and sum numbers right of index
                var rightSum = Sum(SplitArray(numbers, index, numbers.Length - index));

                if (leftSum == rightSum)
                    return index;
            }

            return -1;
      }

        //function to split array based on start and end positions
        public int[] SplitArray(int[] arr, int index, int length)
        {
            int[] result = new int[length];
            Array.Copy(arr, index, result, 0, length);
            return result;
        }

        //function to sum array
        public int Sum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            return sum;
        }
    }
}
