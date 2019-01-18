using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Exercises
{
    public class NQueensProblem
    {
        public void Run()
        {
            var board = new int[4, 4];
            PlaceQueen(board, 4);

        }

        public void PlaceQueen(int[,] board, int n)
        {
            List<Tuple<int, int>> selected = new List<Tuple<int, int>>();
            List<Tuple<int, int>> moves = new List<Tuple<int, int>>();

            PlaceQueen(board, 0, n, ref selected, ref moves);

        }

        public bool PlaceQueen(int[,] board, int row, int n, ref List<Tuple<int, int>> selected, ref List<Tuple<int, int>> moves)
        {
            if (row == n)
            {
                moves.AddRange(selected);
                return true;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    var move = new Tuple<int, int>(row, i);

                    if (IsValidMove(i, row, selected))
                    {
                        selected.Add(move);

                        var placed = PlaceQueen(board, row + 1, n, ref selected, ref moves);

                        if (!placed)
                        {
                            selected.Remove(move);
                        }
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid move");
                    }
                }
            }

            return false;
        }

        public bool IsValidMove(int col, int row, List<Tuple<int, int>> selected)
        {
            for (int i = 0; i < selected.Count; i++)
            {
                var queen = selected[i];

                //horizontal
                if (queen.Item1 == row)
                    return false;
                if (queen.Item2 == col)
                    return false;

                if ((col - queen.Item2) / (row - queen.Item1) == 1 || (col - queen.Item2) / (row - queen.Item1) == -1)
                    return false;
            }

            return true;
        }
    }
}
