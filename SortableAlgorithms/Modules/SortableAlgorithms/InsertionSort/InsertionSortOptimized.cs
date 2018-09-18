using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableAlgorithms.InsertionSort
{
    public class InsertionSortOptimized : ISortAlgorithm
    {
        public void Sort(IComparable[] table)
        {
            List<IComparable> output = new List<IComparable>();
            foreach (IComparable elementToSort in table)
            {
                int indexInSorted = output.BinarySearch(elementToSort);
                if (indexInSorted < 0)
                {
                    indexInSorted = Math.Abs(indexInSorted) - 1;
                }
                output.Insert(indexInSorted, elementToSort);
            }
            for (int index = 0; index < table.Length; ++index)
            {
                table[index] = output[index];
            }
        }
    }
}