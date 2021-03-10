using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_1
{
    public class Program4Student : Object
    {
        // DataMember (Attribute / Instance variable)
        int studentid;
        String Studentname;
        int studentage;

        // Static datamemeber (Non Instance variables)
        static String School1;

        //Default Constructor
        public Program4Student()
        {
            studentid = 0;
            Studentname = "NA";
            studentage = 0;
            Console.WriteLine("Default Constructor: \n "+ "Eneter StudentID: "+ this.studentid + ",Eneter StudentName :" + this.Studentname + " ,Eneter StudentAge:" + this.studentage );
            Console.WriteLine("\n-----------------------------------------------------\n");
        }

        // Static constructor
        static Program4Student()
        {
            School1 = "Dell";
            Console.WriteLine("Static constructor: \n" + School1 );
            Console.WriteLine("\n-----------------------------------------------------\n");
        }

        //papameterlized Constructor 
        public Program4Student(int studentid, string Studentname, int studentage)
        {
            this.studentid = studentid;
            this.Studentname = Studentname;
            this.studentage = studentage;
            Console.WriteLine("papameterlized Constructor: \n" + " ,Eneter StudentID" + this.studentid + ",Eneter StudentName" + this.Studentname + ",Eneter StudentAge" + this.studentage);
            Console.WriteLine("\n-----------------------------------------------------\n");
        }

        //Copy Constructor 
        public Program4Student(Program4Student stu)
        {
            this.studentid = stu.studentid;
            this.Studentname = stu.Studentname;
            this.studentage = stu.studentage;
            Console.WriteLine("Copy Constructor: \n" + ",Eneter StudentID" + this.studentid + ",Eneter StudentName" + this.Studentname + ",Eneter StudentAge" + this.studentage);
            Console.WriteLine("\n-----------------------------------------------------\n");
        }

        // Cloning 
        public object clone()
        {
            return this.MemberwiseClone();
        }

        //Memeberfunction
        public void eneterstudentdetails()
        {
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Eneter StudentID");
                    this.studentid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Eneter StudentName");
                    this.Studentname = Console.ReadLine();
                    Console.WriteLine("Eneter StudentAge");
                    this.studentage = int.Parse(Console.ReadLine());

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception"+ e);
            }
            Console.WriteLine("\n-----------------------------------------------------\n");
        }

        //public static void displaystudentdetails()
            public  void displaystudentdetails()
            {
            try { 

                Console.WriteLine("Student Information");
                for (int i = 0; i < 2; i++)
                {
                Console.WriteLine("Eneter StudentID"+ this.studentid + "Eneter StudentName" + this.Studentname + "Eneter StudentAge" + this.studentage);
                // Console.WriteLine("ID : {0}, Name : {1} , Age : {3}", this.studentid , this.Studentname, this.studentage);
                }

                Console.WriteLine("Student Company :" + Program4Student.School1);
                }

            catch (Exception e)
                {
                    Console.WriteLine("Exception"+e);
                }
                Console.WriteLine("\n-----------------------------------------------------\n");
            }

        void displayMarks()
        { }

        void classSection()
        { }

        void attendence()
        { }
    }

class Employee { }

class Teacher { }

class School
{

    /*
    static void Main(String[] args)
    {
            Program4Student Obj1 = new Program4Student();
            Obj1.eneterstudentdetails();
            Obj1.displaystudentdetails();

            Program4Student Obj2 = new Program4Student(1,"Null",1);
            Obj2.eneterstudentdetails();
            Obj2.displaystudentdetails();

            Program4Student Obj3 = new Program4Student(Obj2);
            //Obj2.eneterstudentdetails();
            Obj2.displaystudentdetails();

            Program4Student Obj4 = Obj2.clone() as Program4Student;
            Obj4.displaystudentdetails();

            //Program3Student.displaystudentdetails();
            Console.ReadKey();
    }
    */


}
}
