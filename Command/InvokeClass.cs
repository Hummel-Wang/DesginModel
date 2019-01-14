using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // 命令抽象类
    public abstract class Command
    {
        protected Receiver _receiver;
        public Command(Receiver receiver)
        {
            this._receiver = receiver;
        }
        // 命令执行方法
        public abstract void Action();

    }

    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver):base(receiver)
        {

        }
        public override void Action()
        {
            // 调用接收的方法，因为执行命令的是学生
            _receiver.Run1000Meters();
        }
    }

    public class Receiver
    {
        public void Run1000Meters()
        {
            Console.WriteLine("跑1000米");
        }
    }



    // 教官，负责调用命令对象执行请求
    public class InvokeClass
    {
        public Command _command;
        public InvokeClass(Command command)
        {
            this._command = command;
        }
        public void ExecuteCommand()
        {
            _command.Action();
        }
    }
}
