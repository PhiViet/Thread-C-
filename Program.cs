using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace CreateThread
{
    class Program
    {
        static void Main()
        {
            //Thread t = new Thread(new ThreadStart(MethodA));
            //t.Start();
            //MethodB();
            //Console.ReadLine();
            Thread t = new Thread(() => 
            {
                Thread.Sleep(1000);
                Console.WriteLine("Main thread started"); 
            });
            t.Start();
            Console.WriteLine("Main thread ending . . . ");
            Console.ReadLine();


        }
        static void MethodA()
        {
            for(int i=0;i<100;i++)
            Console.Write("0");
        }
        static void MethodB()
        {
            for(int i=0;i<100;i++)
            Console.Write("1");
        }
    }
}
