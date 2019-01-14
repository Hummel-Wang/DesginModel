using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class TengXun
    {
        private List<IObserver> observers = new List<IObserver>();

        public string Symbol { get; set; }
        public string Info { get; set; }
        public TengXun(string symbol, string info)
        {
            this.Symbol = symbol;
            this.Info = info;
        }
        #region 新增对订阅号列表的维护操作
        public void AddObserver(IObserver ob)
        {
            observers.Add(ob);
        }
        public void RemoveObserver(IObserver ob)
        {
            observers.Remove(ob);
        }
        #endregion
        public void Update()
        {
            // 遍历订阅者列表进行通知
            foreach (IObserver ob in observers)
            {
                if (ob != null)
                {
                    ob.ReceiveAndPrint(this);
                }
            }
        }
    }

    /// <summary>
    /// 具体订阅号类
    /// </summary>
    public class TengXunGame : TengXun
    {
        public TengXunGame(string symbol, string info):base(symbol,info)
        {

        }
    }

    /// <summary>
    /// 订阅接口
    /// </summary>
    public interface IObserver
    {
        void ReceiveAndPrint(TengXun tenxun);
    }

    /// <summary>
    /// 具体的订阅者类
    /// </summary>
    public class Subscriber : IObserver
    {
        public string Name { get; set; }
        public Subscriber(string name)
        {
            this.Name = name;
        }
        public void ReceiveAndPrint(TengXun tenxun)
        {
            Console.WriteLine("Notified {0} of {1}'s" + " Info is: {2}", Name, tenxun.Symbol, tenxun.Info);
        }
    }

}
