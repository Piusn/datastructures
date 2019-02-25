using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertMinJumps
    {
        public static int MinNumberOfJumps(int[] arr)
        {
            if (arr.Length == 0)
                return 0;

            int minJumps = 0;
            int endJump = 0;

            int maxJump = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                var jumps = arr[i];

                int furthestJump = jumps + i;

                if (furthestJump > maxJump)
                    maxJump = furthestJump;

                if (endJump == 0)
                    endJump = furthestJump;

                if (endJump == i)
                {
                    minJumps++;
                    endJump = furthestJump;
                }
            }

            return minJumps + 1;
        }
    }
}
