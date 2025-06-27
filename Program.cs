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
        
        //AddTwoNumbers
        
        // Create l1 = [2,4,3]
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));

        // Create l2 = [5,6,4]
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        // Solve
        AddTwoNumbersSolver solution = new AddTwoNumbersSolver();
        //ListNode result = solution.AddTwoNumbers_BF(l1, l2);
        ListNode result_op = solution.AddTwoNumbers_Optimal(l1, l2);
        // Print result: [7,0,8]
        Console.Write("[");
        while (result_op != null)
        {
            Console.Write(result_op.val);
            if (result_op.next != null) Console.Write(",");
            result_op = result_op.next;
        }
        Console.WriteLine("]");
    }
}
