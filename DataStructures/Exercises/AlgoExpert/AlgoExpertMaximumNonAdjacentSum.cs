namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertMaximumNonAdjacentSum
    {
        public static int Sum(int[] arr)
        {
            var jumps = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    jumps[i] = arr[i];
                    continue;
                }

                if (i == 1)
                {
                    jumps[i] = arr[i];
                    continue;
                }

                if (jumps[i - 1] > jumps[i - 2] + arr[i])
                    jumps[i] = jumps[i - 1];
                else
                {
                    jumps[i] = jumps[i - 2] + arr[i];
                }
            }

            return jumps[arr.Length - 1];
        }
    }
}