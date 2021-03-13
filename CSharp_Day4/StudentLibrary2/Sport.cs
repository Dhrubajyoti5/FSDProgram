using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary2
{
    public class sport : Marks
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
}
