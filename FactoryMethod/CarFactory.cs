using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 汽车工厂类
    /// 定义汽车实例的生产
    /// </summary>
    public abstract class CarFactory
    {
        //创建汽车实例
        public abstract Car CarCreate();
    }

    /// <summary>
    /// 汽车抽象类
    /// 定义汽车的行为
    /// </summary>
    public abstract class Car
    {
        public abstract void StartUp();
        public abstract void Run();
        public abstract void Stop();
    }

    /// <summary>
    /// 宝马汽车工厂类
    /// </summary>
    public  class BWMCarFactory : CarFactory
    {
        public override Car CarCreate()
        {
            return new BWMCar();
        }
    }

    /// <summary>
    /// 奥迪汽车工厂类
    /// </summary>
    public  class AudiCarFactory : CarFactory
    {
        public override Car CarCreate()
        {
            return new AudiCar();
        }
    }

    /// <summary>
    /// 宝马汽车类，行为的具体实现
    /// </summary>
    public class BWMCar : Car
    {
        public override void StartUp()
        {
            Console.WriteLine("Test BWMCar start-up speed!");
        }
        public override void Run()
        {
            Console.WriteLine("The BWMCar run is very quickly!");
        }
        public override void Stop()
        {
            Console.WriteLine("The slow stop time is 3 second, BWMCar");
        }

    }
    /// <summary>
    /// 奥迪汽车类，行为的具体实现
    /// </summary>
    public class AudiCar : Car
    {
        public override void StartUp()
        {
            Console.WriteLine("Test AudiCar start-up speed!");
        }
        public override void Run()
        {
            Console.WriteLine("The AudiCar run is very quickly!");
        }
        public override void Stop()
        {
            Console.WriteLine("The slow stop time is 3 second ,AudiCar");
        }

    }


}
