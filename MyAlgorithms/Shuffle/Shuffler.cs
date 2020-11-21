using System;
using MyAlgorithms.Common;

namespace MyAlgorithms.Shuffle
{
    public static class Shuffler
    {
        public static void Shuffle(int[] cards)
        {
            for (var i = cards.Length - 1; i >= 0; i--)
            {
                var index = new Random().Next(100);
                cards.Swap(i, index % (i + 1));
            }
        }
    }
}