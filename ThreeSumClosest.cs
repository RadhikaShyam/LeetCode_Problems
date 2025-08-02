public class Solution_9 {
    
    public int ThreeSumClosest_BF(int[] nums, int target) {
        Array.Sort(nums);
        int closestSum =nums[0]+nums[1]+nums[2];
        int minDiff = Math.Abs(target-closestSum);
        for(int i=0;i<nums.Length;i++)
        { for(int j=i+1;j<nums.Length;j++)
        { for(int k=j+1;k<nums.Length;k++)
        {
            int sum = nums[i]+nums[j]+nums[k];
            int diff= Math.Abs(target-sum);
            if(diff<minDiff)
            {
                closestSum=sum;
                minDiff=diff;
            }
        }}}
        return closestSum;
    }
    public int ThreeSumClosest_Optimal(int[] nums, int target)
    {
        Array.Sort(nums);
        int closestSum = nums[0] + nums[1] + nums[2]; ;
        for (int i = 0; i < nums.Length; i++)
        {
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (Math.Abs(target - sum) < Math.Abs(target - closestSum))
                {
                    closestSum = sum;
                }

                if (sum > target) right--;
                else if (sum < target) left++;
            }
        }
        return closestSum;
    }
}