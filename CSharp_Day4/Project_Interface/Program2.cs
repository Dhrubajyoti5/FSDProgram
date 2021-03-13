using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Inheritence1
{
    class Student
    {
        int stdid;
        string stdname;

        public void accpetdetails()
        {
            try
            {
                Console.WriteLine("Adv.2 Base class - Parent class - Accept Mathod");
                Console.WriteLine("Enter the Student ID:");
                this.stdid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Student Name:");
                this.stdname = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e);
            }
            Console.WriteLine("---------------------------------\n\n");
        }

        public void displaydetails()
        {
            try
            {
                Console.WriteLine("Adv.2 Base class - Parent class - display Method");
                Console.WriteLine("Student ID:" + this.stdid);
                Console.WriteLine("Student Name:" + this.stdname);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e);
            }
            Console.WriteLine("---------------------------------\n\n");

        }

    }

    class Marks : Student
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

    class sport : Marks
    {
        float score;

        new public void accpetdetails()
        {
            try
            {
                base.accpetdetails();
                Console.WriteLine("Adv.2 derived class 2: - Sport - Accept Mathod ");
                Console.WriteLine("Please enter the Student Score:");
                this.score = float.Parse(Console.ReadLine());
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
                Console.WriteLine("Adv.2 derived class - sport class - display Method");
                Console.WriteLine("Student Score:" + this.score);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e);
            }
            Console.WriteLine("---------------------------------\n\n");
        }

    }

    class Program_Inheri2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritence program---- Adv.2 \n\n\n");

            sport newsportobj = new sport();

            Console.WriteLine("Adv.2 Calling the 1st Object : 1st Method\n");
            newsportobj.accpetdetails();
            Console.WriteLine("Adv.2 Calling the 1st Object : 2nd Method\n");
            newsportobj.displaydetails();

            Console.ReadKey();
        }
    }

}
