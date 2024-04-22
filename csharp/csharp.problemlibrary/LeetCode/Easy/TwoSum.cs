using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.problemlibrary.LeetCode.Easy
{
    public class TwoSum
    {
        public static int[] TwoSumResolution(int[] nums, int target)
        {
            var indices = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i]+ nums[j] == target)
                    {
                     indices = [i,j];
                    }
                }
            }
            return indices;
        }
    }
}
