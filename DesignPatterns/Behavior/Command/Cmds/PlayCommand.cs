using System;

namespace DesignPatterns.Behavior.Command.Cmds
{
    public class PlayCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("开始");
        }

        public void Undo()
        {
            Console.WriteLine("撤销开始");
        }
    }
}