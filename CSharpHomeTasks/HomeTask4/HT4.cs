/*
There is an array of numbers - arr [1, 3, 6, 2, 2, 0, 4, 5] 
there is a number target = 5.
Count the number of pairs in the array, the sum of which will give target
I mean the pairs are (1,3) (3,6) (6,2) (2,2) (2,0) (0,4) (4,5) 
 
 */
/*
 If search any combination like (1,3) (1,6) (6,5) etc., use a second for
for (int i=0; i< numbers.Length;i++){
    for (int j=i+1; j < numbers.Length;j++){
      sum = numbers[i]+numbers[j];

 */

using NUnit.Framework;
using System.Diagnostics.Metrics;

namespace CSharpHomeTask4
{
    public class HT4
    {
        public static int SumPairInArray(int[] arr, int target)
        {
            int counter = 0, sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum = arr[i] + arr[j];
                    if (sum == target) counter++;
                }
            }
            return counter;
        }
        [Test]
        public void Test1_Sum5T4()
        {
            int[] arr = new int[] { 1, 4, 2, 3, 6, 5, 0, 2 };
            int target = 5;
            int expectedResult = 4;
            int result = SumPairInArray(arr, target);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test2_Sum5T3()
        {
            int[] arr = new int[] { 1, 4, 5, 3, 0, 2, 6 };
            int target = 5;
            int expectedResult = 3;
            int result = SumPairInArray(arr, target);

            Assert.AreEqual(expectedResult, result);
        }
    }
}