using System;

namespace SortableAlgorithms.BubbleSort
{
    public class BubbleSort : ISortAlgorithm
    {
        public void Sort(IComparable[] table)
        {
            bool swapped = false;
            for (int loop = 0; loop < table.Length - 1; ++loop)
            {
                for (int index = 0; index < table.Length - 1; ++index)
                {
                    if (table[index].CompareTo(table[index + 1]) > 0)
                    {
                        IComparable temp = table[index];
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