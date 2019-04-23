using System;
using System.IO;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertContinousMeanMinHeap
    {
        private readonly int[] _heap = null;
        private int _endIndex = -1;

        public bool IsEmpty
        {
            get { return _endIndex == -1; }
        }

        public AlgoExpertContinousMeanMinHeap(int size)
        {
            _heap = new int[size];
            _endIndex = -1;
        }
        public AlgoExpertContinousMeanMinHeap(int[] arr)
        {
            _heap = arr;
            _endIndex = arr.Length - 1;

            BuildHeap(_endIndex);
        }

        //Build
        public void BuildHeap(int endIndex)
        {
            var mid = endIndex / 2;

            for (int i = mid; i >= 0; i--)
            {
                SiftDown(i, endIndex);
            }
        }

        //Sift down
        public void SiftDown(int idx, int endIdx)
        {
            var leftIndex = GetLeft(idx, endIdx);
            int idxToSwap = leftIndex;

            if (leftIndex != -1 && leftIndex<=endIdx)
            {
                var rightIndex = GetRight(idx, endIdx);

                if (rightIndex != -1)
                {
                    if (_heap[rightIndex] < _heap[leftIndex])
                        idxToSwap = rightIndex;
                }

                if (_heap[idx] > _heap[idxToSwap])
                    Swap(idx, idxToSwap);
            }
        }

        //Sift up
        public void SiftUp(int index)
        {
            var parent = GetParent(index);

            while (_heap[parent] > _heap[index])
            {
                Swap(parent, index);
                index = parent;
                parent = GetParent(parent);
            }
        }

        private int GetLeft(int idx, int endIdx)
        {
            var left = (idx * 2) + 1;

            return left <= endIdx ? left : -1;
        }

        private int GetRight(int idx, int endIdx)
        {
            var right = (idx * 2) + 2;

            return right <= endIdx ? right : -1;
        }

        public int GetParent(int index)
        {
            return (index - 1) / 2;
        }

        //Swap
        public void Swap(int leftIndex, int rightIndex)
        {
            var temp = _heap[leftIndex];
            _heap[leftIndex] = _heap[rightIndex];
            _heap[rightIndex] = temp;
        }

        //Remove
        public int Remove()
        {
            if (!IsEmpty)
            {
                Swap(0, _endIndex);
                var value = _heap[_endIndex];
                _endIndex--;
                if (_endIndex >= 0)
                {
                    SiftDown(0, _endIndex);

                }
                return value;
            }

            return int.MinValue;
        }

        public void Insert(int value)
        {
            var nextIndex = _endIndex + 1;
            _heap[nextIndex] = value;
            SiftUp(nextIndex);
            _endIndex++;
        }
    }

    public class AlgoExpertContinousMeanHandler
    {
        private readonly AlgoExpertContinousMeanMinHeap _min;
        public AlgoExpertContinousMeanHandler()
        {
            _min = new AlgoExpertContinousMeanMinHeap(4);
            _min.Insert(2);
            _min.Insert(6);
            _min.Insert(1);

            var val = _min.Remove();
        }
    }
}