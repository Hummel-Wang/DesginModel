using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 抽象工厂类：提供创建不同品牌的手机屏幕和手机主板
    /// </summary>
    public abstract class AbstractFactory
    {
        //工厂生产屏幕
        public abstract Screen CreateScreen();
        //工厂生产主板
        public abstract MotherBoard CreateMotherBoard();
    }

    /// <summary>
    /// 屏幕抽象类：提供每一品牌的屏幕的继承
    /// </summary>
    public abstract class Screen
    {
        public abstract void print();
    }

    /// <summary>
    /// 主板抽象类：提供每一品牌的主板的继承
    /// </summary>
    public abstract class MotherBoard
    {
        public abstract void print();
    }

    /// <summary>
    /// 苹果手机屏幕
    /// </summary>
    public class AppleScreen : Screen
    {
        public override void print()
        {
            Console.WriteLine("苹果手机屏幕！");
        }
    }

    /// <summary>
    /// 苹果手机主板
    /// </summary>
    public class AppleMotherBoard : MotherBoard
    {
        public override void print()
        {
            Console.WriteLine("苹果手机主板！");
        }
    }

    /// <summary>
    /// 小米手机屏幕
    /// </summary>
    public class XiaoMiScreen : Screen
    {
        public override void print()
        {
            Console.WriteLine("小米手机屏幕！");
        }
    }

    /// <summary>
    /// 小米手机主板
    /// </summary>
    public class XiaoMiMotherBoard : MotherBoard
    {
        public override void print()
        {
            Console.WriteLine("小米手机主板！");
        }
    }

    /// <summary>
    /// 苹果手机工厂
    /// </summary>
    public class AppleFactory : AbstractFactory
    {
        /// <summary>
        /// 生产苹果手机屏幕
        /// </summary>
        /// <returns></returns>
        public override Screen CreateScreen()
        {
            return new AppleScreen();
        }

        /// <summary>
        /// 生产苹果手机主板
        /// </summary>
        /// <returns></returns>
        public override MotherBoard CreateMotherBoard()
        {
            return new AppleMotherBoard();
        }
    }

    /// <summary>
    /// 小米手机工厂
    /// </summary>
    public class XiaoMiFactory : AbstractFactory
    {
        /// <summary>
        /// 生产小米手机屏幕
        /// </summary>
        /// <returns></returns>
        public override Screen CreateScreen()
        {
            return new XiaoMiScreen();
        }

        /// <summary>
        /// 生产小米手机主板
        /// </summary>
        /// <returns></returns>
        public override MotherBoard CreateMotherBoard()
        {
            return new XiaoMiMotherBoard();
        }
    }

}
