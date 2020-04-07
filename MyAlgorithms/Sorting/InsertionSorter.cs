using System.Collections.Generic;

namespace MyAlgorithms.Sorting
{
    public static class InsertionSorter
    {
        public static void InsertionSort<T>(this List<T> list, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            for (var i = 1; i < list.Count; i++)
            {
                var temp = list[i];
                var j = i - 1;
                while (j >= 0 && comparer.Compare(list[j], temp) > 0)
                {
                    list[j + 1] = list[j];
                    j--;
                }

                list[j + 1] = temp;
            }
        }
    }
}