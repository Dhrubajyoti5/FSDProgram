using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AbstractClass1
{
    public abstract class Animal
    {  
        public abstract void Talk();

        public Animal()
        {
            Console.WriteLine("Constructor1 :Main Animal");
        }
        public void Hear()
        {
            Console.WriteLine("All animals have ears");
        }
        public void See()
        {
            Console.WriteLine("All animals can see");
        }
    }

    public class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("Constructor2 :A cat is an animal");
        }
        public override void Talk()
        {
            Console.WriteLine("A cat purrs");
        }
    }

    public class Lion : Cat
    {
        public Lion()
        {
            Console.WriteLine("Constructor3 : A lion is a cat, which is an animal");
        }
        public override void Talk()
        {
            Console.WriteLine("A lion roars");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lion Lobj = new Lion();
            Lobj.Talk();
            Console.ReadKey();

            Cat cobj = new Cat();
            cobj.Talk();
            Console.ReadKey();
        }
    }
}
