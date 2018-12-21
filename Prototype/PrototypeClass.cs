using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// 原型抽象基类
    /// </summary>
   public abstract class PrototypeClass
    {
        public abstract PrototypeClass clone();
    }

    /// <summary>
    /// 具体实现类
    /// </summary>
    public class NormalActorA : PrototypeClass
    {
        public override PrototypeClass clone()
        {
            Console.WriteLine("NormalActorA is call");
            return (PrototypeClass) this.MemberwiseClone();
        }
    }

    /// <summary>
    /// 行为
    /// </summary>
    public class GameSystem
    {
        public void Run(PrototypeClass normalActor, FlyActor flyActor)
        {
            PrototypeClass normalActor1 = normalActor.clone();
            PrototypeClass normalActor2 = normalActor.clone();
            PrototypeClass normalActor3 = normalActor.clone();
            PrototypeClass normalActor4 = normalActor.clone();
            PrototypeClass normalActor5 = normalActor.clone();

            FlyActor flyActor1 = flyActor.clone();
            FlyActor flyActor2 = flyActor.clone();
            FlyActor flyActor3 = flyActor.clone();
            FlyActor flyActor4 = flyActor.clone();
            FlyActor flyActor5 = flyActor.clone();
        }
    }

    /// <summary>
    /// 扩展【飞行类】
    /// </summary>
    public abstract class FlyActor
    {
        public abstract FlyActor clone();
    }

    /// <summary>
    /// 飞行具体实现类
    /// </summary>
    public class FlyActorB : FlyActor
    {
        /// <summary>
        /// 浅拷贝，如果用深拷贝，可使用序列化
        /// </summary>
        /// <returns></returns>
        public override FlyActor clone()
        {
            Console.WriteLine("FlyActor is called...");
            return (FlyActor)this.MemberwiseClone();
        }
    }

}
