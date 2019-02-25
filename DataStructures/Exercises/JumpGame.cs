using System;

namespace DataStructures.Exercises
{
    public class JumpGameII
    {
        private static int Min = int.MaxValue;

        public static int JumpGame(int[] jumps)
        {
            int[] dp = new int[jumps.Length];
            int currentJumps = JumpGameHelper(0, jumps, dp);

            return 0;
        }

        /// <summary>
        /// Using dynamic programming
        /// </summary>
        /// <param name="index"></param>
        /// <param name="jumps"></param>
        /// <param name="dp"></param>
        /// <returns></returns>
        public static int JumpGameHelper(int index, int[] jumps, int[] dp)
        {
            if (index == jumps.Length - 1)
                return 0;

            if (jumps[index] == 0)
                return int.MaxValue;

            if (dp[index] != 0)
                return dp[index];

            //start
            int start = index + 1;
            int end = index + jumps[index];

            int totalJumps = int.MaxValue;

            while (start < jumps.Length && start <= end)
            {
                int minJumps = JumpGameHelper(start++, jumps, dp);

                if (minJumps != Int32.MaxValue)
                    totalJumps = Math.Min(minJumps + 1, totalJumps);
            }

            dp[index] = totalJumps;

            return dp[index];
        }
    }
}