using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation1
{
    class ProgramBigO1
    {
        class BigONotation
        {
            public void log1(int[] numbers)
            {
                Console.WriteLine("\n1st Method --------------------\n");
                Console.WriteLine(numbers[0]);
                Console.WriteLine(numbers[0]);
                Console.WriteLine("Complexcity : O(1) + O(1)-> O(2)->O(1)--------------------Constant time\n");
            }

            public void log11(int[] numbers)
            {
                Console.WriteLine("\n1st A Method --------------------\n");

                Console.WriteLine("");
                Console.WriteLine("");
                for (int i = 0; i < numbers.Length; i++)
                    Console.WriteLine(numbers[i]);

                Console.WriteLine("Complexcity : O(1+1) + O(n) ->O(n) --------------------Linear\n");
            }

            public void log2(int[] numbers)
            {
                Console.WriteLine("\n2nd Method --------------------\n");
                
                for (int i = 0; i < numbers.Length; i++)       
                    Console.WriteLine(numbers[i]);

                Console.WriteLine("\n");
                foreach (var number in numbers)                 
                    Console.WriteLine(number);
                
                Console.WriteLine("Comlexcity : O(n)+O(n)->O(n+n)->O(2n)--->O(n)--------------------Linear\n");
            }

            public void log3(int[] numbers, string[] names)
            {
                Console.WriteLine("\n3rd Method --------------------\n");
                foreach (var number in numbers)    
                    Console.WriteLine(number);
                
                Console.WriteLine("\n");
                foreach (var name in names)         
                    Console.WriteLine(name);

                Console.WriteLine("Comlexcity : O(n)+O(m)->O(m+n)->O(n)--------------------Linear\n");
            }


            public void log4(int[] numbers)
            {
                Console.WriteLine("\n4th Method --------------------\n");
                
                foreach (var first in numbers)  
                {
                    foreach (var second in numbers) 
                    {
                        Console.WriteLine(first + " : " + second);
                    }
                }
                Console.WriteLine("Comlexcity : O(n)* O(n)--> O(n2)--------------------Quadratic \n");

                foreach (var number in numbers)     
                    Console.WriteLine(number);
                Console.WriteLine("Comlexcity : O(n)--------------------Linear\n");

                foreach (var first in numbers)      
                    foreach (var second in numbers) 
                        Console.WriteLine(first + " : " + second);
                Console.WriteLine("Comlexcity : O(n)* O(n)--> O(n2)--------------------Quadratic\n");

                Console.WriteLine("Total Comlexcity : O(n2)+ O(n)+ O(n2)--> O(n2)--------------------Quadratic\n");
            }
        }

        static void Main(string[] args)
        {
            BigONotation bigONotation = new BigONotation();
            int[] nums = { 1, 2, 3, 4, 5 };
            string[] names = { "King", "Kochhar", "John" };

            bigONotation.log1(nums);
            bigONotation.log2(nums);
            bigONotation.log3(nums, names);
            bigONotation.log4(nums);
            Console.ReadKey();
        }
    }
}
