public class Solution_10
{
    public IList<IList<int>> FourSum_BF(int[] nums, int target)
    {
        List<IList<int>> res = new List<IList<int>>();
        HashSet<string> seen = new HashSet<string>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    for (int l = k + 1; l < nums.Length; l++)
                    {
                        if (nums[i] + nums[j] + nums[k] + nums[l] == target)
                        {
                            int[] tuple = new int[] { nums[i], nums[j], nums[k], nums[l] };
                            Array.Sort(tuple);
                            string key = $"{tuple[0]},{tuple[1]},{tuple[2]},{tuple[3]}";

                            if (!seen.Contains(key))
                            {
                                res.Add(new List<int> { tuple[0], tuple[1], tuple[2], tuple[3] });
                                seen.Add(key);
                            }

                        }
                    }
                }
            }
        }
        return res;
    }
    
    public IList<IList<int>> FourSum_Optimal(int[] nums, int target) {
        List<IList<int>> res = new List<IList<int>>();
        Array.Sort(nums);
        long sum =0;
        for(int i=0;i<nums.Length-3;i++)
        {
            if(i>0 && nums[i]==nums[i-1])continue;
            for(int j=i+1;j<nums.Length-2;j++)
        {
       if(j>i+1 && nums[j]==nums[j-1])continue;
       int left = j+1;
       int right = nums.Length-1;
       while(left<right)
       {
        sum = nums[i]+nums[j]+nums[left]+nums[right];
        if(sum == target)
        {
            res.Add(new List<int> {nums[i],nums[j],nums[left],nums[right]});
            left++;
            right--;
            while(left<right && nums[left]==nums[left+1])left++;
            while(left<right && nums[right]==nums[right-1])right--;
        }
        else if(sum<target) left++;
        else right--;
       }
            
            }
        }
       
        return res;
    }
}