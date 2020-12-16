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

        public abstract void Shout();
        public Action MouseAction;
    }

    public class CoffeeCat : Cat
    {
        public CoffeeCat(string name) : base(name)
        {
        }

        public override void Shout()
        {
            Console.WriteLine($"{Name} shouting...");
            OnMouseAction();
        }

        public virtual void OnMouseAction()
        {
            MouseAction?.Invoke();
        }

        //public override event Action CatAction;
    }

    public class BoolCat : Cat
    {
        public BoolCat(string name) : base(name)
        {
        }

        public override void Shout()
        {
            Console.WriteLine($"{Name} shouting...");
            OnMouseAction();
        }

        public virtual void OnMouseAction()
        {
            MouseAction?.Invoke();
        }

        //public override event Action CatAction;
    }
}