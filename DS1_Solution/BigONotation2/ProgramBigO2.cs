using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation2
{
    class Notations
    {
       
        public void printFirstElementofArray(int[] numbers)
        {
            Console.WriteLine("\n1st Method Complexcity: O(1)");
            Console.WriteLine(numbers[0]);
           
        }
      
        public void printAllElementsOfArray(int[] numbers)
        {
            Console.WriteLine("\n2nd Method Complexcity: O(n) ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void printAllPossibleOrderedPairs(int[] numbers, int size)
        {
            Console.WriteLine("\n3rd Method Complexcity: O(n)*O(n)--->O(n2)");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine(numbers[i] + " : " + numbers[j]);
                }
            }
        }

        public int fibonacci(int num)
        {
            Console.WriteLine("\n4th Method Complexcity: 2n2 : "+num);

            if (num <= 1) return num;

            return 
                fibonacci(num - 2) + fibonacci(num - 1);
        }

        public void printAllItemsTwice(int[] numbers, int size)
        {
            Console.WriteLine("\nComplexcity: O(n)");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("\nComplexcity: O(n)");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("\n5th Method Total Complexcity: O(n)+O(n)-->O(2n)-->O(n) ");
        }

        public void printFirstItemThenFirstHalfThenSayHi100Times(int[] numbers, int size)
        {
            Console.WriteLine("\nComplexcity: O(1)");
            Console.WriteLine(numbers[0]);

            Console.WriteLine("\nComplexcity: O(n/2) ->O(n)");
            for (int i = 0; i < size / 2; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("\nComplexcity: O(100)->O(n)");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Hi");
            }
            Console.WriteLine("\n6th Method Total Complexcity: O(1)+O(n/2)+O(100) ");
        }

    }
    class BigONotationPractice
    {
        static void Main(string[] args)
        {
            Notations notation = new Notations();
            int[] numbers = { 1, 2, 3, 4, 5 };

            notation.printFirstElementofArray(numbers);
            Console.WriteLine("------------------");
            notation.printAllElementsOfArray(numbers);
            Console.WriteLine("------------------");
            notation.printAllPossibleOrderedPairs(numbers, numbers.Length);
            Console.WriteLine("------------------");
            Console.WriteLine(notation.fibonacci(5));
            Console.WriteLine("------------------");
            notation.printAllItemsTwice(numbers, numbers.Length);
            Console.WriteLine("------------------");
            notation.printFirstItemThenFirstHalfThenSayHi100Times(numbers, numbers.Length);
            Console.ReadKey();
        }
    }
}
