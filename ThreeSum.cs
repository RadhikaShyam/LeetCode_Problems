public class Solution_8
{
    public IList<IList<int>> ThreeSum_BF(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();
        HashSet<string> seen = new HashSet<string>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        int[] tuple = new int[] { nums[i], nums[j], nums[k] };
                        Array.Sort(tuple);
                        string key = $"{tuple[0]},{tuple[1]},{tuple[2]}";

                        if (!seen.Contains(key))
                        {
                            result.Add(new List<int> { tuple[0], tuple[1], tuple[2] });
                            seen.Add(key);
                        }
                    }
                }
            }
        }
        return result;
    }
    
    public IList<IList<int>> ThreeSum_Optimal(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        for( int i=0;i<nums.Length;i++)
        {
          if(i>0 && nums[i] ==nums [i-1])
          continue;
          int left= i+1;
          int right = nums.Length-1;
          while(left<right)
          {
            int total = nums[i]+nums[left]+ nums[right];
            if(total==0)
            {
                result.Add(new List<int> {nums[i],nums[left],nums[right]});
                while(left<right && nums[left]==nums[left+1])left++;
                while(left<right && nums[right]==nums[right-1])right--;
                left++;
                right--;
            }
            else if(total<0)
            left++;
            else
            right--;
          }
        }
        return result;
    }
}