using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode961N_RepeatedElementInSize2NArray
{
    public class Solution
    {
        public int RepeatedNTimes(int[] A)
        {
            for (int i = 0; i < A.Length-1; i++)
            {
                var item = A[i];
                for (int j = i+1; j < A.Length; j++)
                {
                    if (item == A[j])
                    {
                        return item;
                    }
                }
            }
            throw new Exception("Not Found");
        }
    }
}
