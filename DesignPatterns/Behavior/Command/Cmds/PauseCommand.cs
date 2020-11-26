using System;

namespace DesignPatterns.Behavior.Command.Cmds
{
    public class PauseCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("暂停");
        }

        public void Undo()
        {
            Console.WriteLine("取消暂停");
        }
    }
}