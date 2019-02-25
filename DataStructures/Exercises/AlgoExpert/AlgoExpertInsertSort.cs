namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertInsertSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int movingIndex = i + 1;

                while (movingIndex >= 1 &&movingIndex< arr.Length && arr[movingIndex] < arr[movingIndex - 1])
                {
                    var temp = arr[movingIndex];
                    arr[movingIndex] = arr[movingIndex - 1];
                    arr[movingIndex - 1] = temp;

                    movingIndex--;
                }
            }
        }
    }
}