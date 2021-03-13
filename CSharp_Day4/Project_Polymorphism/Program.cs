using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Polymorphism
{
    class MethodOverload
    {
        public int add (int x)
        {
            x = 0 + x;
            return x;
        }
        public int add (int x, int y)
        {
            x = x + y;
            return x;
        }
        public int add (int x, int y, int z)
        {
            x = x + y + z;
            return x;
        }
    }

    class bassclass_Phone
    {
        public virtual void ringdisplay()
        {
            Console.WriteLine("its a base/parent class: Hellow "); 
        }
    }

    class Mobile_derivedclass1 : bassclass_Phone
    {
        public override void ringdisplay()
        {
            Console.WriteLine("its a derieved class 1 : Hellow");
        }
    }

    class Landline_derivedclass2 : Mobile_derivedclass1
    {
        public override void ringdisplay()
        {
            Console.WriteLine("its a derieved class 2 : Hellow");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select option : \n 1. Method Over Load \n 2. Method Overridden \n 3. Abstract class \n");
            int option = int.Parse(Console.ReadLine());

            MethodOverload mobj = new MethodOverload();
            

            switch (option)
            {
                case 1:
                    {
                        try
                        {
                            Console.WriteLine("Method overload :\n");
                            Console.WriteLine("\nMethod overload : 1 parameter -> totaladdtion : add (int x) :" + mobj.add(9));
                            Console.WriteLine("\nMethod overload : 2 parameter -> totaladdtion : add (int x, int y) :" + mobj.add(9,8));
                            Console.WriteLine("\nMethod overload : 3 parameter -> totaladdtion : add(int x, int y, int z) :" + mobj.add(5,6,7));
                        }
                       
                        catch(Exception e)
                        {
                            Console.WriteLine("Exception"+ e);
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Method overidden:\n");

                        Landline_derivedclass2 dobj = new Landline_derivedclass2();
                        Console.WriteLine("\nMethod overidden: Print the Drieved class2 Message :");
                        dobj.ringdisplay();

                        Console.WriteLine("\nMethod overidden: print the derived class1 Message :");
                        bassclass_Phone bbobj = new Mobile_derivedclass1();
                        bbobj.ringdisplay();

                        Console.WriteLine("\nMethod overidden: print the base class : \n");
                        bassclass_Phone bbobj2 = new bassclass_Phone();
                        bbobj2.ringdisplay();

                        Console.ReadKey();
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Abstract class");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
