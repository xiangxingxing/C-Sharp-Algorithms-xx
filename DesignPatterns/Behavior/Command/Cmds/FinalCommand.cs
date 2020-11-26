using System;

namespace DesignPatterns.Behavior.Command.Cmds
{
    public class FinalCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("结束");
        }

        public void Undo()
        {
            Console.WriteLine("撤销结束");
        }
    }
}