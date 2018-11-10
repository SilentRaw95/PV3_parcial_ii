using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printArray(int[] arr, int n)
        {
            String owo = "Lista ordenada de los numeros: ";
            for (int i = 0; i < n; ++i)
            {
                System.Diagnostics.Debug.WriteLine(arr[i] + " ");
                owo = owo + arr[i] + ",";
            }
            BottomText.Text = owo;
        }

        //Funciones de botones --start
        private void quick_Click(object sender, EventArgs e)
        {
            indexButton(1);
        }

        private void bubble_Click(object sender, EventArgs e)
        {
            indexButton(2);
        }

        private void merge_Click(object sender, EventArgs e)
        {
            indexButton(3);
        }

        private void hearp_Click(object sender, EventArgs e)
        {
            indexButton(4);
        }

        private void indexButton(int op)
        {
            String beter = lista.Text;
            string[] words = beter.Split(',');
            int nword = words.Length;
            int[] numArray = new int[nword];

            for (int i = 0; i < nword; i++)
            {
                numArray[i] = Int32.Parse(words[i]);

            }

            switch (op)
            {
                case 1:
                    quickSort(numArray, 0, nword - 1);
                    printArray(numArray, nword);
                    break;
                case 2:
                    bubbleSort(numArray);
                    printArray(numArray, nword);
                    break;
                case 3:
                    MergeSort(numArray, 0, nword - 1);
                    printArray(numArray, nword);
                    break;
                case 4:
                    HeapSort(numArray);
                    printArray(numArray, nword);
                    break;
                default:
                    break;
            }
        }
        //Funciones de botones --end

        //Funciones de Quick Sort --start
        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller 
                // than or equal to pivot 
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is 
                now at right place */
                int pi = partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }
        //Funciones de Quick Sort --end

        //Funciones de Bubble sort --start
        static void bubbleSort(int[] arr)
        {
            int temp = 0;
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
        }
        //Funciones de Bubble sort --end

        //Funciones de Merge sort --start
        private void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }

        private void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                Merge(input, left, middle, right);
            }
        }
        //Funciones de Merge sort --end

        //Funciones de Hearp sort --start
        private static void MaxHeapify(int[] input, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && input[left] > input[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && input[right] > input[largest])
                largest = right;

            if (largest != index)
            {
                int temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;

                MaxHeapify(input, heapSize, largest);
            }
        }

        public static void HeapSort(int[] input)
        {
            //Build-Max-Heap
            int heapSize = input.Length;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                MaxHeapify(input, heapSize, p);

            for (int i = input.Length - 1; i > 0; i--)
            {
                //Swap
                int temp = input[i];
                input[i] = input[0];
                input[0] = temp;

                heapSize--;
                MaxHeapify(input, heapSize, 0);
            }
        }
        //Funciones de Hearp sort --end
    }
}
