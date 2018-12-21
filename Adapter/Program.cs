using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 适配器模式有2种：类的适配器模式，对象的适配器模式
/// </summary>
namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 现在客户端可以通过电适配要使用2个孔的插头了【类的适配器模式】
            IThreeHole threeholeClass = new PowerAdapter();
            threeholeClass.Request();


            // 现在客户端可以通过电适配要使用2个孔的插头了【对象的适配器模式】
            ThreeHole threeholeObject = new PowerAdapterObject();
            threeholeObject.Request();


            Console.ReadLine();

        }
    }
}
