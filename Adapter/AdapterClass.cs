using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 类的适配器模式定义
/// 在这里以生活中的一个例子来进行演示适配器模式的实现，具体场景是: 
/// 在生活中，我们买的电器插头是2个孔的，但是我们买的插座只有三个孔的，
/// 此时我们就希望电器的插头可以转换为三个孔的就好，这样我们就可以直接把它插在插座上，
/// 此时三个孔插头就是客户端期待的另一种接口，自然两个孔的插头就是现有的接口，适配器模式就是用来完成这种转换的
/// </summary>
namespace Adapter
{

    /// <summary>
    /// 三个孔的插头，也就是适配器模式中的目标角色
    /// </summary>
    public interface IThreeHole
    {
        void Request();
    }

    /// <summary>
    /// 两个孔的插头，源角色——需要适配的类
    /// </summary>
    public abstract class TwoHole
    {
        public void SpecificRequest()
        {
            Console.WriteLine("我是两个孔的插头");
        }
    }

    /// <summary>
    /// 适配器类，接口要放在类的后面
    /// 适配器类提供了三个孔插头的行为，但其本质是调用两个孔插头的方法
    /// </summary>
    public class PowerAdapter : TwoHole, IThreeHole
    {
        /// <summary>
        /// 实现三个孔插头接口方法
        /// </summary>
        public void Request()
        {
            // 调用两个孔插头方法
            this.SpecificRequest();
        }
    }
}
