using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver r = new Receiver();
            Command c = new ConcreteCommand(r);
            InvokeClass i = new InvokeClass(c);

            i.ExecuteCommand();

            Console.ReadLine();
        }
    }
}
