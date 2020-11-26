using System.Collections.Generic;
using System.Linq;
using DesignPatterns.SingletonPattern;

namespace DesignPatterns.Behavior.Command
{
    public class CommandManager : Singleton<CommandManager>
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        public void AddCommand(ICommand cmd)
        {
            _commands.Add(cmd);
        }
        
        public void AddCommands(IEnumerable<ICommand> cmds)
        {
            _commands.AddRange(cmds);
        }

        public void Operate()
        {
            _commands.ForEach(c => c.Execute());
        }

        public void Undo()
        {
            var commands = Enumerable.Reverse(_commands);
            foreach (var command in commands)
            {
                command.Undo();
            }
        }
    }
}