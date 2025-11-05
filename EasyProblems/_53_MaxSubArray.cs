using System;
using System.Text;

namespace LeetCode
{
    /// <summary>
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
    public class Solution
    {
        private static string PrintArray(int[] subArray) 
        {
            StringBuilder sb = new StringBuilder($"[");
            for (int j = 0; j < subArray.Length; j++)
            {
                sb.Append($" {subArray[j]}");
            }
            sb.Append($"]");

            return sb.ToString();
        }

        private static int[] FillArray(int[] subArray, int left, int right)
        {
            int length = right - left+1;
            int[] ints = new int[length];
            for (int j = 0; j < length; j++)
            {
                ints[j] = subArray[left+j];
            }

            return ints;
        }

        public static int MaxSubArray(int[] nums)
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
                for (int k = i; k < (nums.Length); k++)
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
            return Math.Max(maxSum,sum);
        }
    }
}
