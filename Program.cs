// See https://aka.ms/new-console-template for more information
using System;
using LeetCode_Problems;

class Program
{
    public static void Main(string[] args)
    {
        Solution twoSum = new Solution();
        /* int[] nums = { 2, 7, 11, 15 };
        int target = 9; 
        int[] nums = [3, 2, 4];
        int target = 6;
        */
        int[] nums = [3, 3];
        int target = 6;
        int[] result = twoSum.TwoSum_Optimal(nums, target);
        int[] result_bf = twoSum.TwoSum_BF(nums, target);
        int[] result_lo = twoSum.TwoSum_NotSoPerfectApproach(nums, target);
        Console.WriteLine($"TwoSum Indices: {result[0]}, {result[1]}");
        Console.WriteLine($"TwoSum Indices: {result_bf[0]}, {result_bf[1]}");
        Console.WriteLine($"TwoSum Indices: {result_lo[0]}, {result_lo[1]}");
    }
}