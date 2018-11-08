using System;

namespace SortableAlgorithmsCore.BubbleSort
{
    public class BubbleSort : ISortAlgorithm
    {
        public void Sort(IComparable[] table)
        {
            var swapped = false;
            for (var loop = 0; loop < table.Length - 1; ++loop)
            {
                for (var index = 0; index < table.Length - 1; ++index)
                {
                    if (table[index].CompareTo(table[index + 1]) > 0)
                    {
                        var temp = table[index];
                        table[index] = table[index + 1];
                        table[index + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break;
                }
            }
        }
    }
}