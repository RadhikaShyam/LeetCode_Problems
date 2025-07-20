namespace Median
{
    public class Solution_4
    {
        public double FindMedianSortedArrays_BF(int[] nums1, int[] nums2)
        {
            int n1 = nums1.Length;
            int n2 = nums2.Length;
            int n = n1 + n2;
            int i = 0;
            int j = 0;
            int k = 0;
            int[] new_arr = new int[n];

            while (i <= n1 && j <= n2)
            {
                if (i == n1)
                {
                    while (j < n2)
                        new_arr[k++] = nums2[j++];
                    break;
                }
                else if (j == n2)
                {
                    while (i < n1)
                        new_arr[k++] = nums1[i++];
                    break;
                }

                if (nums1[i] < nums2[j])
                {
                    new_arr[k++] = nums1[i++];
                }
                else
                {
                    new_arr[k++] = nums2[j++];
                }
            }
            if (n % 2 == 0) return (float)(new_arr[n / 2 - 1] + new_arr[n / 2]) / 2;
            else return new_arr[n / 2];

        }

        public double FindMedianSortedArrays_Optimal(int[] nums1, int[] nums2)
        {

            if (nums1.Length > nums2.Length)
            {
                return FindMedianSortedArrays_Optimal(nums2, nums1);
            }

            int x = nums1.Length;
            int y = nums2.Length;

            int start = 0;
            int end = x;

            while (start <= end)
            {
                int partX = (start + end) / 2;
                int partY = (x + y + 1) / 2 - partX;

                int xLeft = partX == 0 ? int.MinValue : nums1[partX - 1];
                int xRight = partX == x ? int.MaxValue : nums1[partX];
                int yLeft = partY == 0 ? int.MinValue : nums2[partY - 1];
                int yRight = partY == y ? int.MaxValue : nums2[partY];

                if (xLeft <= yRight && yLeft <= xRight)
                {
                    if ((x + y) % 2 == 0)
                    {
                        return ((double)Math.Max(xLeft, yLeft) + Math.Min(xRight, yRight)) / 2;
                    }
                    else
                    {
                        return Math.Max(xLeft, yLeft);
                    }
                }
                else if (xLeft > yRight)
                {
                    end = partX - 1;
                }
                else
                {
                    start = partX + 1;
                }
            }

            return 0;
        }
    }
}