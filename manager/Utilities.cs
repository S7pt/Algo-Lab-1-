using Algo_lab_1.src.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algo_lab_1.src.manager
{
  public class Utilities {
        public static void Swap(List<Perforator> listToSwap,int firstIndex,int secondIndex)
        {
            Perforator buffer = listToSwap[firstIndex];
            listToSwap[firstIndex] = listToSwap[secondIndex];
            listToSwap[secondIndex] = buffer;
        }
} }
