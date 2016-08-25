﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort2
{
    class Program
    {
        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;
                while (numbers[right] > pivot)
                    right--;
                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static public void SortQuick(int[] arr, int left, int right)
        {
            //for recursion
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                    SortQuick(arr, left, pivot - 1);
                if (pivot + 1 < right)
                    SortQuick(arr, pivot + 1, right);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("\nProgram for sorting a number array using Quick Sorting");
            Console.Write("\n\nEnter number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[max];

            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input int array : ");
            Console.Write("\n");
            for (int k = 0; k < max; k++)
            {
                Console.Write(numbers[k] + " ");
                Console.Write("\n");
            }
            Console.WriteLine("QuickSort by Recursive Method");
            SortQuick(numbers, 0, max - 1);
            for (int i = 0; i < max; i++)
                Console.WriteLine(numbers[i]);
            Console.ReadLine();
        }
    }
}
