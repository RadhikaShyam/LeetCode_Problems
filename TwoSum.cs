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
            var numsWithIndex = nums
            .Select((value, index) => new { Value = value, Index = index })
            .OrderBy(x => x.Value).ToArray();
            int n = numsWithIndex.Length;
            for (int i = 0; i < n; i++)
            {
                int find = target - numsWithIndex[i].Value;

                //Binary Search to find find
                int low = 0; 
                int high = n - 1;
                while (low <= high)
                {
                    int mid = low + (high - low) / 2;
                    if (mid == i)
                    {
                        if (mid < numsWithIndex[i].Value)
                            low = mid + 1;
                        else
                            high = mid - 1;
                        continue;
                    }
                    if (numsWithIndex[mid].Value == find)
                    {
                        // Found the pair
                        return new int[] { numsWithIndex[i].Index, numsWithIndex[mid].Index };
                    }
                    else if (numsWithIndex[mid].Value < find)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return new int[0];
        }


    }
}