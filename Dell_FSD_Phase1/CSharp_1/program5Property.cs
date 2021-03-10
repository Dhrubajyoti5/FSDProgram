using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_1
{
    class Student
    {
        private int _studentid;
        private string _studentname;
        private int _sAge;

        //Constructore
        public Student()
        {
            this._studentid = 1;
            this._studentname = "Student";
            this._sAge = 20;
        }

        //Read-Write Property
        public int StudentIDD
        {
            get { return _studentid; }
            set
            {
                try
                {
                    if (value < 0 | value > 10)
                    {
                        Console.WriteLine("Exception : ID should be greater than zero or less than 10");
                        throw new Exception("Exception : ID should be greater than zero or less than 10");

                    }

                    else
                        _studentid = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception" + e);
                }
            }
        }
        //Read-Write Property
        public String SName
        {
            get { return _studentname; }

            set {
                _studentname = value;
            }
        }

        //Read properties
        public int StudentAge
        {
            get { return _sAge; }

        }
    }

    class Employee23
    { 
        //Auto implement Propeteries 
        public int EmpID { get; set; }
        public String Empname { get;  }
        
    }
     
    class program5Property
    {
        /*
        static void Main(string[] args)
        {
            Student SObj = new Student();

            Console.WriteLine("SID : " + SObj.StudentIDD);
            Console.WriteLine("SName : " + SObj.SName);
            Console.WriteLine("SName : " + SObj.StudentAge);

            SObj.StudentIDD = 1002;
            SObj.SName = "Dhurba";
            Console.WriteLine("SID : " + SObj.StudentIDD);
            Console.WriteLine("Sname : " + SObj.SName);
            Console.WriteLine("SName : " + SObj.StudentAge);

            Console.ReadKey();
        */
        }
    }

