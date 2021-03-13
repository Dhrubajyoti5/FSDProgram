using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary2
{
    public class Marks : Student
    {
        float subMaks, objMarks;

        new public void accpetdetails()
        {

            try
            {
                base.accpetdetails();
                Console.WriteLine("Adv.2 derived Class 1- MArk class - Accept Mathod");
                Console.WriteLine("Enter the Subjective marks:");
                this.subMaks = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the objective marks:");
                this.objMarks = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e);
            }
            Console.WriteLine("---------------------------------\n\n");

        }

        new public void displaydetails()
        {
            try
            {
                base.displaydetails();
                Console.WriteLine("derived class - MArks class - display Method");
                Console.WriteLine("Student ID:" + this.subMaks);
                Console.WriteLine("Student Name:" + this.objMarks);
                Console.ReadKey();
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception" + e);
            }
            Console.WriteLine("---------------------------------\n\n");
        }

    }
}
