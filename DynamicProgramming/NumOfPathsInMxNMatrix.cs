using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmWorkout.DynamicProgramming
{
    public class NumOfPathsInMxNMatrix
    {
        public static int GetNumOfPathsInMxNMatrix(int m, int n)
        {
            if (m == 1 || n == 1)
                return 1;
            
            return GetNumOfPathsInMxNMatrix(m-1,n) + GetNumOfPathsInMxNMatrix(m,n-1);
        }
    }
}
