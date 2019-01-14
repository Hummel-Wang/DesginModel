using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // 抽象牌友类
    public abstract class AbstractCardPartner
    {
        public int MoneyCount { get; set; }
        public AbstractCardPartner()
        {
            MoneyCount = 0;
        }
        public abstract void ChangeCount(int Count, AbstractMediator mediator);
    }

    /// <summary>
    /// 牌友A
    /// </summary>
    public class ParterA : AbstractCardPartner
    {
        // 依赖与抽象中介者对象
        public override void ChangeCount(int Count, AbstractMediator mediator)
        {
            mediator.AWin(Count);
        }
    }
    /// <summary>
    /// 牌友B
    /// </summary>
    public class ParterB : AbstractCardPartner
    {
        // 依赖与抽象中介者对象
        public override void ChangeCount(int Count, AbstractMediator mediator)
        {
            mediator.BWin(Count);
        }
    }
    /// <summary>
    /// 抽象中介者类
    /// </summary>
    public abstract class AbstractMediator
    {
        protected AbstractCardPartner A;
        protected AbstractCardPartner B;
             public AbstractMediator(AbstractCardPartner a, AbstractCardPartner b)
        {
            A = a;
            B = b;
        }

        public abstract void AWin(int count);
        public abstract void BWin(int count);
    }

    /// <summary>
    /// 具体中介者类
    /// </summary>
    public class MediatorPater : AbstractMediator
    {
        public MediatorPater(AbstractCardPartner a, AbstractCardPartner b) : base(a, b)
        {

        }
        public override void AWin(int count)
        {
            A.MoneyCount += count;
            B.MoneyCount -= count;
        }
        public override void BWin(int count)
        {
            B.MoneyCount += count;
            A.MoneyCount -= count;
        }
    }

}
