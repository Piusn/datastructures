using System;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertMergeSort
    {
        public AlgoExpertMergeSort()
        {
            var input = new[] { 3, 4, 2, 1, 2, 3,-67, 7, 1, 1, 1, 3,89 };
            var result = Sort(input);
        }

        public int[] Sort(int[] arr)
        {
            var aux = new int[arr.Length];
            Sort(arr, aux, 0, arr.Length - 1);
            return aux;
        }

        public void Sort(int[] arr, int[] aux, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
                return;

            var mid = (startIndex + endIndex) / 2;

            Sort(arr, aux, startIndex, mid);
            Sort(arr, aux, mid + 1, endIndex);

            if (endIndex == 10)
                Console.WriteLine("Hello");
                Merge(arr, aux, startIndex, endIndex, mid);
        }

        public void Merge(int[] arr, int[] aux, int startIndex, int endIndex, int mid)
        {
            int i = startIndex;
            int j = mid + 1;
            int k = startIndex;

            while (i <= mid && j <= endIndex)
            {
                if (arr[i] <= arr[j])
                {
                    aux[k] = arr[i];
                    i++;
                    k++;
                }
                else
                {
                    aux[k] = arr[j];
                    j++;
                    k++;
                }
            }

            while (i <= mid)
            {
                aux[k] = arr[i];
                i++;
                k++;
            }

            while (j <= endIndex)
            {
                aux[k] = arr[j];
                j++;
                k++;
            }

            for (int l = 0; l < k; l++)
            {
                arr[l] = aux[l];
            }
        }
    }
}