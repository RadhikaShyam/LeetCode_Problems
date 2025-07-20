public class Solution_6
{
    public int MaxArea_Optimal(int[] height)
    {
        int max = 0;
        int left = 0;
        int right = height.Length - 1;
        while (left < right)
        {
            int width = right - left;
            int area = (Math.Min(height[left], height[right])) * width;
            max = Math.Max(max, area);
            if (height[left] >= height[right])
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return max;
    }

    public int MaxArea_BF(int[] height)
    {
        int max = 0;
        int width = 0;
        int area;
        for (int i = 0; i < height.Length; i++)
        {
            for (int j = 1; j < height.Length; j++)
            {
                width = Math.Abs(j- i);
                area = (Math.Min(height[j], height[i])) * width;
                max = Math.Max(max, area);
            }
        }
        return max;

    }
   
}