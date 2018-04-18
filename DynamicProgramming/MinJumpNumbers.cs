using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmWorkout.DynamicProgramming
{
    public class MinJumpNumbers
    {
        public static int GetMinJumpNumbers()
        { 
            int[] a = {1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9};
            if (a.Length <= 1) return 0;

            int maxReach = a[0];
            int step = a[0];
            int jump = 1;

            for (int i = 1; i < a.Length; i++)
            {
                if (i == a.Length - 1) return jump;
                if (i + a[i] > maxReach)
                    maxReach = i + a[i];
                step--;
                if (step == 0)
                {
                    jump++;
                    step = maxReach - i;
                }
            }

            return jump;
        }
    }
}
