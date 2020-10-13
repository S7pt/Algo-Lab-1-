using Algo_lab_1.src.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algo_lab_1.src.manager
{
    class HeapSort
    {
        private int swaps;
        private int comparisons;

        public HeapSort()
        {
            swaps = 0;
            comparisons = 0;
        }
        public void SortByStrokeFrequency(List<Perforator> perforators)
        {
            int n = perforators.Count;

            for (int i = n / 2 - 1; i >= 0; i--)
                HeapifyDescending(perforators, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                swaps++;
                Utilities.Swap(perforators, i, 0);
                HeapifyDescending(perforators, i, 0);
            }
        }
        void HeapifyDescending(List<Perforator> perforators, int heapSize, int root)
        {
            int least = root; 
            int leftBranch = 2 * root + 1;  
            int rightBranch = 2 * root + 2;
            comparisons += 2;
            if (leftBranch < heapSize && perforators[leftBranch].strokeFrequency < perforators[least].strokeFrequency)
                least = leftBranch;
            comparisons += 2;
            if (rightBranch < heapSize && perforators[rightBranch].strokeFrequency < perforators[least].strokeFrequency)
                least = rightBranch;
 
            if (least != root)
            {
                swaps++;
                Utilities.Swap(perforators, least, root);
                HeapifyDescending(perforators, heapSize, least);
            }
        }
        public override string ToString()
        {
            return "swaps: " + swaps + " comparisons: " + comparisons;
        }
    }
}
