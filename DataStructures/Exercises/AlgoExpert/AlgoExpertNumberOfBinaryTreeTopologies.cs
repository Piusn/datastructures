using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises.AlgoExpert
{
   public  class AlgoExpertNumberOfBinaryTreeTopologies
    {
        public AlgoExpertNumberOfBinaryTreeTopologies()
        {
           var total= NumberOfBinaryTreeTopologies(3);
        }
        public int NumberOfBinaryTreeTopologies(int n)
        {
            if (n == 0)
                return 1;

            int total = 0;

            for (int i = 0; i < n; i++)
            {
                var left = i;
                var right = n - 1 - i;

                var lT = NumberOfBinaryTreeTopologies(left);
                var rT = NumberOfBinaryTreeTopologies(right);

                total += lT * rT;
            }

            return total;
        }
    }
}
