using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises
{
    public class RecursionExercise
    {
        //TODO: Tower of hanoi

        public static List<int> GetNumbers(int n)
        {

            List<int> numbers = new List<int>();
            GetNumbers(100, numbers);
            return numbers;
        }

        public static void GetNumbers(int n, List<int> number)
        {

            if (n == 0)
            {
                number.Add(n);
                return;
            }
            else
            {
                GetNumbers(n - 1, number);
                number.Add(n);
            }

        }

        public static void TowerOfHanoi(int n, string source, string aux, string dest)
        {
           if (n == 1)
            {
                Console.WriteLine($"{source } ----> {dest}");
                return;
            }
            TowerOfHanoi(n - 1, source, dest, aux);
            Console.WriteLine($"{source } ----> {dest}");
            TowerOfHanoi(n - 1, aux, source, dest);
            return;
        }
    }
}
