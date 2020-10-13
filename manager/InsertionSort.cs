using Algo_lab_1.src.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algo_lab_1.src.manager
{
    class InsertionSort
    {
        private int swaps;
        private int comparisons;
        public InsertionSort()
        {
            swaps = 0;
            comparisons = 0;
        }
        public void InsertionSortByRPM(List<Perforator> perforators) {
            for(int i = 1; i < perforators.Count; i++)
            {
                int j = i - 1;
                Perforator buffer = perforators[i];
                while (j>=0 && perforators[j].revolutionsPerMinute > buffer.revolutionsPerMinute)
                {
                    comparisons += 2;
                    swaps++;
                    Utilities.Swap(perforators, j, j + 1);
                    j -= 1;
                }
            }
        }
        public override string ToString()
        {
            return "swaps: " + swaps + " comparisons: " + comparisons;
        }
    }
}
