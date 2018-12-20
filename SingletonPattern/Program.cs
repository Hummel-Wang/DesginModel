using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{

    #region 单线程Singleton实现
    class SingleThread_Singleton
    {
        private static SingleThread_Singleton instance = null;
        private SingleThread_Singleton() { }
        public static SingleThread_Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingleThread_Singleton();
                }
                return instance;
            }
        }
    }
    #endregion

    #region 多线程Singleton实现
    class MultiThread_Singleton
    {
        private static volatile MultiThread_Singleton instance = null;
        private static object lockHelper = new object();
        private MultiThread_Singleton() { }
        public static MultiThread_Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new MultiThread_Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
    #endregion

    #region 静态Singleton实现
    class Static_Singleton
    {
        public static readonly Static_Singleton instance = new Static_Singleton();
        private Static_Singleton() { }
    }
    #endregion


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
