﻿namespace AlgorithmWorkout.DynamicProgramming
{ 
    public class MinCost
    {
        public int GetMinCost() 
        {
            var cost = new int[3][]; 
            cost[0] = new[] { 1, 2, 3 };
            cost[1] = new[] { 4, 8, 2 };
            cost[2] = new[] { 1, 5, 3 };
            
            int m = 2, n = 2;
            int i, j;
            var tc = new int[m, n];
            tc[0, 0] = cost[0][0];

            for (i = 1; i <= m; i++)  
                tc[i, 0] = tc[i - 1, 0] + cost[i][0];

            for (j = 1; j <= n; j++) 
                tc[0, j] = tc[0, j - 1] + cost[0][j];

            for (i = 1; i <= m; i++)
            for (j = 1; j <= n; j++)
                tc[i, j] = this.min(tc[i - 1, j - 1], 
                               tc[i-1, j],
                               tc[i, j-1]) + cost[i][j];

            return 0;
        }

        public int min(int x, int y, int z)
        {
            if (x < y)
                return x < z ? x : z;
            else
                return y < z ? y : z;
        }
    }
}