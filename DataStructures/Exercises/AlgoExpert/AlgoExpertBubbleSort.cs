namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertBubbleSort
    {
        public static void Sort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int index = 1;

                while (index < input.Length)
                {
                    var temp = input[index];

                    if (temp < input[index - 1])
                    {
                        input[index] = input[index - 1];
                        input[index - 1] = temp;
                    }

                    index++;
                }
            }
        }
    }
}