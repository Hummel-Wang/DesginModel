using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory bwmFactory = new BWMCarFactory();
            CarFactory audiFactory = new AudiCarFactory();

            Car bwm = bwmFactory.CarCreate();
            bwm.StartUp();
            Thread.Sleep(1000);
            bwm.Run();
            Thread.Sleep(1000);
            bwm.Stop();
            Thread.Sleep(1000);

            Car audi = audiFactory.CarCreate();
            audi.StartUp();
            Thread.Sleep(1000);
            audi.Run();
            Thread.Sleep(1000);
            audi.Stop();

            Console.WriteLine("\n");
            Console.WriteLine("**********Output was done**********");
            Console.ReadLine();

        }
    }
}
