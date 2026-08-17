using LeetCode;
using LeetCode.EasyProblems;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

namespace LeetCode.Tests
{
    public class _53_MaxSubArray_Tests
    {
        [Test, Description("tests for simple small array")]
        [Order(1)]
        public void pushTests()
        {
            Assert.That(MaxSubArray.MaxSubArray_BruteForce(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }), Is.EqualTo(6), "Should be able to find the max subarray sum.");
            Assert.That(MaxSubArray.MaxSubArray_BruteForce(new int[] { 5, 4, -1, 7, 8 }), Is.EqualTo(23), "Should be able to find the max subarray sum.");
        }

        [Test, Description("tests for big array")]
        public void bigArrayTests()
        {
            var lines = File.ReadAllLines("_53_MaxSubArray_Tests.txt");
            int[] nums = lines[0].Split(',').Select(n => Convert.ToInt32(n)).ToArray();

            Assert.That(MaxSubArray.MaxSubArray_BruteForce(nums), Is.EqualTo(1499749), "Should be able to find the max subarray sum.");
        }
    }
}
