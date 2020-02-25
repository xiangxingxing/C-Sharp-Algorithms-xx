using System;

namespace DesignPatterns.ObservablePattern
{
    public abstract class Mouse
    {
        public string Name { get; set; }

        protected Mouse(string name, Cat cat)
        {
            Name = name;
            cat.CatAction += MouseOnCatAction;
        }

        protected abstract void MouseOnCatAction();
    }

    public class MikeyMouse : Mouse
    {
        private readonly string _catName;

        public MikeyMouse(string name, Cat cat) : base(name, cat)
        {
            _catName = cat.Name;
        }

        protected override void MouseOnCatAction()
        {
            Console.WriteLine($"{Name} mouse runs away when hearing {_catName}'s shouting.");
        }
    }

    public class WhiteMouse : Mouse
    {
        private readonly string _catName;

        public WhiteMouse(string name, Cat cat) : base(name, cat)
        {
            _catName = cat.Name;
        }

        protected override void MouseOnCatAction()
        {
            Console.WriteLine($"{Name} mouse goes fighting when hearing {_catName}'s shouting.");
        }
    }

    public class BoolMouse : Mouse
    {
        private readonly string _catName;

        public BoolMouse(string name, Cat cat) : base(name, cat)
        {
            _catName = cat.Name;
        }

        protected override void MouseOnCatAction()
        {
            Console.WriteLine($"{Name} mouse finds {_catName} cat to play together.");
        }
    }
}