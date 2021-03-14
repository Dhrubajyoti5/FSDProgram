using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array
{ 
    public class array1
    {
        int[] arr = new int[30];
        int number;
        int temp;

        public array1()
        {
            number = 0;
            temp = 0;
        }
        
        public void enter() {

            Console.Write("\nPlease enter the number:");
            number = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine("\nPlease enter the value for array");
                for (int i = 0; i < number; i++)
                {
                    Console.Write("Arrayelement - {0} : ", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception"+e);
            }
        }

        public void display() {
            try
            {
                Console.WriteLine("\ndisplay the value in the Array:");
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine("\n Array value :" + arr[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e);
            }
        }

        public void LSearch() 
        {
            int SNo;
            try {
                Console.WriteLine("\n\n Please search the emement that want to search:");
                SNo = Int32.Parse(Console.ReadLine());

                for (int i = 0, j =0; i < number; i++)
                {
                    if (arr[i] == SNo)
                    {
                        Console.WriteLine("\nLinear Search : The element has been found in the index :"+ i);
                        j++;
                    }
                    if (i == number-1 && j == 0)
                        {
                            Console.WriteLine("\nLinear Search : didnot found the element in the Array :" + SNo);
                        }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception :" + e);
            }
            Console.ReadKey();
        }

        public void BBsort()
        {
            
            try
            {
                Console.WriteLine("\n\n Bubble Sort:");
                for (int i = 0; i < number-1; i++)
                {
                    for (int j = i + 1; j < number; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }   
                Console.WriteLine("\n----------------------------\n");
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine("\n\n Bubble Sort: arr[i] :"+arr[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception :" + e);
            }
            Console.ReadKey();
        }
}
    
    class ArrayProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Program : \n\n");
            array1 arrobj = new array1();
            arrobj.enter();
            arrobj.display();
            arrobj.LSearch();
            arrobj.BBsort();
            Console.ReadKey();

            Console.WriteLine("-------------------------");

            int[] numbers = { 31, 12, 30, 14, 5 };
            // LINQ Methods:
            Console.WriteLine("\nMinimum number in Array :"+numbers.Min());
            Console.WriteLine("\nMaximum number in Array :" + numbers.Max());
            Console.WriteLine("\nsum number in Array :" + numbers.Sum());
            Console.WriteLine("\nAvg number in Array :" + numbers.Average());
            Console.WriteLine("\nlength of an Array :" + numbers.Length);
            // Array Methods:
            Console.WriteLine("\nArray Methods: Sorting");
            Array.Sort(numbers);
            Array.ForEach(numbers, num => Console.WriteLine(num));

            Console.WriteLine("\nArray Methods: reverse");
            Array.Reverse(numbers);
            Array.ForEach(numbers, num => Console.WriteLine(num));

            Console.WriteLine("-------------------------");
            string[] names = { "King", "Kochhar", "Sarah", "Bowling" };
            //Array.ForEach(names, nums => Console.WriteLine(names));

            var evenNumbers = new int[5] { 2, 4, 6, 8, 10 };
            var oddNumbers = new int[] { 1, 3, 5, 7 };
            // Access Index Elements:
            foreach (var number in oddNumbers)
                Console.WriteLine(number);

            // Declare and Initialize:
            //int[] nums = new int[10];
            //nums[0] = 10;
            //nums[1] = 20;
            // Throws run-time exception IndexOutOfRange
            // nums[10] = 100;

            Console.ReadKey();

        }
    }
}
