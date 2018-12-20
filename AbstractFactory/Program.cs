using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    class Program
    {
        static void Main(string[] args)
        {
            //小米工厂生产小米手机的屏幕和主板
            AbstractFactory xiaomiFactory = new XiaoMiFactory();
            Screen xiaomiScreen = xiaomiFactory.CreateScreen();
            xiaomiScreen.print();
            MotherBoard xiaomiMotherBoard = xiaomiFactory.CreateMotherBoard();
            xiaomiMotherBoard.print();

            //苹果工厂生产苹果手机屏幕和主板
            AbstractFactory appleFactory = new AppleFactory();
            Screen appleScreen = appleFactory.CreateScreen();
            appleScreen.print();
            MotherBoard appleMotherBoard = appleFactory.CreateMotherBoard();
            appleMotherBoard.print();

            Console.Read();
        }
    }
}
