// See https://aka.ms/new-console-template for more information
using System;
using LeetCode_Problems;
using LongestSubstring;
using AddTwoNumbers;

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

        //Longest substring
        Solution_3 sol = new Solution_3();
        string s = "pwwkew";
         int result_3 = sol.LengthOfLongestSubstring(s);
        Console.WriteLine(result_3);

        // Median Of two sorted arrays result is 2 here
        Solution_4 solved = new Solution_4();
        int[] nums1 = [1, 3];
        int[] nums2 = [2];
        double resultMedian = solved.FindMedianSortedArrays_Optimal(nums1, nums2);
        Console.WriteLine(resultMedian);
         
        // Container with most water  output is 49
        Solution_6 solv = new Solution_6();
        int[] height = [1,8,6,2,5,4,8,3,7] ;
        int result_Cont = solv.MaxArea_Optimal(height);
         Console.WriteLine(result_Cont);

        // Longest Common Prefix
        Solution_7 sol_7 = new Solution_7();
        string[] strs = ["flower","flow","flight"];
        string result_prefix = sol_7.LongestCommonPrefix_Optimal(strs);
        Console.WriteLine(result_prefix); 

         // Three Sum
        Solution_8 sol_8 = new Solution_8();
        int[] threenum = [-1, 0, 1, 2, -1, -4];
        IList<IList<int>> threesum = sol_8.ThreeSum_BF(threenum);
        foreach (var triplet in threesum)
        {
            Console.WriteLine($"[{string.Join(", ", triplet)}]");
        }

        // Three Sum Closest
        Solution_9 sol_9 = new Solution_9();
        int[] tnums = [-1,2,1,-4];
        int tar = 1;
        int threesumClosest = sol_9.ThreeSumClosest_Optimal(tnums,tar);
        Console.WriteLine(threesumClosest);
    }
}
