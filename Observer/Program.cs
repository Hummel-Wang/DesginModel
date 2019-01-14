using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            TengXun tenXun = new TengXunGame("TenXun Game", "Have a new game published ....");
            // 添加订阅者
            tenXun.AddObserver(new Subscriber("Learning Hard"));
            tenXun.AddObserver(new Subscriber("Tom"));
            tenXun.Update();
            Console.ReadLine();
        }
    }
}
