using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string arg = Console.ReadLine();
            Factorry fa = new Factorry();
            Product pr= fa.Test(arg);
            pr.Show();
        }

    }
    public class Factorry
    {
        public Product Test(string n)
        {
            if (n == "A")
            {
                return new A();
            }
            else
            {
                return new B();
            }
        }
    }
    public class B : Product
    {
        public override void Show()
        {
            Console.WriteLine("TestB");
        }
    }
    public class A:Product
    {
        public override void Show()
        {
            Console.WriteLine("TestA");
        }
    }
    public abstract class Product
    {
        public virtual void Show()
        {
            Console.WriteLine("AB");
        }
        
    }
}
