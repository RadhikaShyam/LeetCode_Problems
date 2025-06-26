namespace LeetCode_Problems
{
    public class Solution
    {
        public int[] TwoSum_Optimal(int[] nums, int target)
        {
            Dictionary<int, int> set = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {

                int find = target - nums[i];
                if (set.ContainsKey(find))
                {
                    return new int[] { set[find], i };
                }
                set[nums[i]] = i;

            }
            return new int[0];
        }

        public int[] TwoSum_BF(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    int sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }

        public int[] TwoSum_NotSoPerfectApproach(int[] nums, int target)
        {
            //sort the array
            
            var numsWithIndex = nums
            .Select((value, index) => new { Value = value, Index = index })
            .OrderBy(x => x.Value).ToArray();
            
            //Two pointers
                int low = 0;
                int high = numsWithIndex.Length - 1;
                Console.WriteLine("", low, high);
                while (low < high)
            {
                int sum = numsWithIndex[low].Value + numsWithIndex[high].Value;
                if (sum == target && low != high)
                {
                    return new int[] { numsWithIndex[low].Index, numsWithIndex[high].Index };
                }
                if (sum < target)
                    low++;
                else
                    high--;
            }
            return new int[0];
        }
    }
}