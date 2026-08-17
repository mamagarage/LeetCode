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

    [Prompt(name: nameof(MaxSubArray_BruteForce), order: 1)]
    public static class MaxSubArray
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

        /// <summary>
        /// Kadane's algorithm to find the maximum subarray sum in an array of integers.
        /// https://foolishhungry.com/maximum-subarray-with-kadanes-algorithm/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxSubArray_Kadane(int[] nums)
        {
            int sum_so_far = 0;
            int max_sum = int.MinValue;

            Console.WriteLine("=== SIMULAZIONE KADANE CON GRAFICO ASCII ===");
            Console.WriteLine("Indice | Valore | Sum_so_far | Grafico delle barre");
            Console.WriteLine("---------------------------------------------------");

            for (int i = 0; i < nums.Length; i++)
            {
                sum_so_far += nums[i];
                
                max_sum = Math.Max(sum_so_far, max_sum);

                PrintBarRow(i, nums[i], sum_so_far);

                //If the sum so far is negative, reset it to 0
                if (sum_so_far < 0)
                {
                    Console.WriteLine("       |        | [RESET -> 0]| X (Somma negativa, azzeramento passato)");
                    sum_so_far = 0;
                }

            }

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"RISULTATO FINALE -> Massima Somma Trovata: {max_sum}");

            return max_sum;
        }

        static void PrintBarRow(int index, int val, int sum)
        {
            // Allineamento del testo per incolonnare i dati in modo pulito
            string info = $"{index,5}  | {val,6} | {sum,10} | ";
            Console.Write(info);

            if (sum > 0)
            {
                // Disegna barre piene per i valori positivi
                Console.WriteLine(new string('█', sum));
            }
            else if (sum < 0)
            {
                // Disegna barre sfumate per indicare il "deficit" negativo prima del reset
                Console.WriteLine(new string('░', Math.Abs(sum)) + " (Sotto Zero)");
            }
            else
            {
                // Valore esattamente pari a 0
                Console.WriteLine("|");
            }
        }
    }
}
