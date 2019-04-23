using System.Collections.Generic;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertPermutations
    {
        public AlgoExpertPermutations()
        {
            var result = Permute(new List<int>() { 1, 2, 3 });
        }

        public List<List<int>> Permute(List<int> arr)
        {
            var permutations = new List<List<int>>();
            List<int> permutation = new List<int>();
            Permute(arr, permutation, permutations);

            return permutations;
        }

        public void Permute(List<int> arr, List<int> permutation, List<List<int>> permutations)
        {
            if (arr.Count == 0 && permutation.Count > 0)
            {
                permutations.Add(permutation);
            }
            else
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    var item = arr[i];
                    arr.Remove(item);
                    var newPerm = new List<int>();

                    foreach (var i1 in permutation)
                    {
                        newPerm.Add(i1);
                    }

                    newPerm.Add(item);
                    Permute(arr, newPerm, permutations);
                    arr.Insert(i, item);
                }
            }
        }
    }
}