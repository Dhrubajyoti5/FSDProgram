using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_1
{ 
    class Student123
    {
        // DataMember (Attribute / Instance variable)
        int studentid;
        String Studentname;
        int studentage;

        //Memeberfunction
        public void eneterstudent()
        {
            Console.WriteLine("Eneter StudentID");
            this.studentid = int.Parse(Console.ReadLine());
            Console.WriteLine("Eneter StudentName");
            this.Studentname = Console.ReadLine();
            Console.WriteLine("Eneter StudentAge");
            this.studentage = int.Parse(Console.ReadLine());

        }
        public void displaystudent()
        {
            Console.WriteLine("Eneter StudentID" + this.studentid + "Eneter StudentName" + this.Studentname + "Eneter StudentAge" + this.studentage);
        }
    }
    
    class Marks : Student123
    {
            float SubjectiveMark;
            float ObjectiveMark;

            public void enter()
            {
                base.eneterstudent();

                Console.WriteLine("SubjectiveMark");
                this.SubjectiveMark = float.Parse(Console.ReadLine());
                Console.WriteLine("ObjectiveMark");
                this.ObjectiveMark = float.Parse(Console.ReadLine());

            }
            public void display()
            {
                base.displaystudent();
                Console.WriteLine("SubjectiveMark : " + this.SubjectiveMark + "ObjectiveMark :" + this.ObjectiveMark);
            }
        }

    //class sport : Marks
    class sport
    {
        float Score;

        public new void enter()
        {
          //  base.enter();
            Console.WriteLine("Scorek");
            this.Score = float.Parse(Console.ReadLine());
        }
        public void display1()
        {
           // base.displaystudent();
            Console.WriteLine("ScoreMark : " + this.Score);
        }
    }

    class Program6Inheritence
    {
        /*
        static void Main(string[] args)
        {
            // Student class -----> Marks class 

            //Marks MarksObject = new Marks();
            //MarksObject.enterMark();
            //MarksObject.displayMark();

            sport sportobject = new sport();
            sportobject.enter();
            sportobject.display1();

            Console.ReadKey();

        }
        
        */
      

    }
}

