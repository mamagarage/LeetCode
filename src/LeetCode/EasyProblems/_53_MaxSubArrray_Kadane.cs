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

    [Prompt(name: nameof(MaxSubArray), order: 1)]
    public static partial class MaxSubArray
    {
        /// <summary>
        /// Kadane's algorithm to find the maximum subarray sum in an array of integers.
        /// https://foolishhungry.com/maximum-subarray-with-kadanes-algorithm/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        [Prompt]
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

        private static void PrintBarRow(int index, int val, int sum)
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

