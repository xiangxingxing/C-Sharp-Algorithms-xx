using System;

namespace DesignPatterns.ObservablePattern
{
    public abstract class Cat
    {
        public string Name { get; set; }

        protected Cat(string name)
        {
            Name = name;
        }

        public abstract void OnCatAction();
        public abstract event Action CatAction;
    }

    public class CoffeeCat : Cat
    {
        public CoffeeCat(string name) : base(name)
        {
        }

        public override void OnCatAction()
        {
            Console.WriteLine($"{Name} start shouting...");
            CatAction?.Invoke();
        }

        public override event Action CatAction;
    }

    public class BoolCat : Cat
    {
        public BoolCat(string name) : base(name)
        {
        }

        public override void OnCatAction()
        {
            Console.WriteLine($"{Name} start playing...");
            CatAction?.Invoke();
        }

        public override event Action CatAction;
    }
}