using Algo_lab_1.src.manager;
using Algo_lab_1.src.model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;


namespace Algo_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            List<Perforator> perforators = new List<Perforator>();
            using (StreamReader reader = new StreamReader("D:/VSprojects/Algo lab 1/Algo lab 1/src/csv_list.csv"))
            {
                string outcomeString;
                while(!reader.EndOfStream)
                {
                    outcomeString = reader.ReadLine();
                    string[] readerArray = outcomeString.Split(",");
                    perforators.Add(new Perforator(readerArray[0], int.Parse(readerArray[1]), int.Parse(readerArray[2]), readerArray[3]));
                }
            }
            foreach(Perforator unit in perforators)
            {
                Console.WriteLine(unit);
            }
            Console.WriteLine("Press any button for heap sort");
            Console.ReadKey();
            HeapSort heapSort = new HeapSort();
            heapSort.SortByStrokeFrequency(perforators);
            time.Stop();
            foreach(Perforator unit in perforators)
            {
                Console.WriteLine(unit);
            }
            Console.WriteLine(heapSort);
            Console.WriteLine("The program was executed in {0} seconds", time.Elapsed);
            Console.WriteLine("Press any key to start insertion sort");
            Console.ReadLine();
            time.Start();
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.InsertionSortByRPM(perforators);
            time.Stop();
            foreach (Perforator unit in perforators)
            {
                Console.WriteLine(unit);
            }
            Console.WriteLine(insertionSort);
            Console.WriteLine("The program was executed in {0} seconds", time.Elapsed);
        }
    }
}
