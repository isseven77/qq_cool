using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
       
    static void Main(string[] args)
    {
        using(Mutex mutex=new Mutex(false, "MutexDemo"))
            {
                if (!mutex.WaitOne(5000,false))
                {
                    Console.WriteLine("start");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("End");
                Console.ReadKey();
            }
    }




    }
}
