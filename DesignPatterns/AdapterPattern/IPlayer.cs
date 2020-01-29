using System;

namespace DesignPatterns.AdapterPattern
{
    public interface IPlayer
    {
        string Name { get; set; }
        void Attack();
        void Defense();
    }

    public class NbaPlayer : IPlayer
    {
        public string Name { get; set; }

        public void Attack()
        {
            Console.WriteLine($"{Name} attack");
        }

        public void Defense()
        {
            Console.WriteLine($"{Name} defense");
        }
    }

    // adaptee
    public class CbaPlayer
    {
        public string Name { get; set; }

        public string Attack()
        {
            return $"{Name} 发起进攻";
        }

        public string Defense()
        {
            return $"{Name} 开始防守";
        }
    }

    public class Translator : IPlayer
    {
        private readonly CbaPlayer _cbaPlayer;

        public Translator(CbaPlayer cbaPlayer)
        {
            _cbaPlayer = cbaPlayer;
            Name = _cbaPlayer.Name;
        }

        public string Name { get; set; }

        public void Attack()
        {
            _cbaPlayer?.Attack();
        }

        public void Defense()
        {
            _cbaPlayer?.Defense();
        }
    }
}