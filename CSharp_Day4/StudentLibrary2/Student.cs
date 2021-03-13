using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary2
{
    public class Student
    {
        int stdid;
        string stdname;
        public static string schoolname;
        
        //Static Constructor 
        static Student()
        {
            Student.schoolname = "Gordon School";
        }
        //default Constructor
        public Student()
        {
            stdid = 0;
            stdname = "NA";
        }

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
                Console.WriteLine("Student SchoolName :" + Student.schoolname);
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
