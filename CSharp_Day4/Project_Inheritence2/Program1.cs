using StudentLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Inheritence2
{

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

            Console.WriteLine("Student SchoolName :" + Student.schoolname);

            Console.ReadKey();
        }

    }
}
