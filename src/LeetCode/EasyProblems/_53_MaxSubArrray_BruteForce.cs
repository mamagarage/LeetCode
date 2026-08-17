using System;
using System.Text;

namespace LeetCode.EasyProblems
{
    /// <summary>
    /// Brute force solution to find the maximum subarray sum in an array of integers.
    /// https://leetcode.com/problems/maximum-subarray
    /// 
    /// nums = [-2,1,-3,4,-1,2,1,-5,4]
    /// subarray = [4,-1,2,1]
    /// sum = 6
    /// 
    /// nums = [5,4,-1,7,8]
    /// subarray = [5,4,-1,7,8]
    /// sum = 23
    /// 
    /// </summary>

    public static partial class MaxSubArray
    {
        [Prompt]
        public static int MaxSubArray_BruteForce(int[] nums)
        {
            int maxSum = int.MinValue;
            int sum = 0;
            int[] maxSumArray = new int[nums.Length];
            // PrintArray(nums);

            // all the numbers in the array
            for (int i = 0; i < nums.Length; i++)
            {
                sum = 0;
                // all the subarrays of that length
                for (int k = i; k < nums.Length; k++)
                {
                    sum = sum + nums[k];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        //maxSumArray = FillArray(nums, left: i, right:k);
                    }
                }
            }

            // Console.WriteLine($"The subarray {PrintArray(maxSumArray)} has the largest sum {maxSum}");
            return maxSum;
        }
    }
}

