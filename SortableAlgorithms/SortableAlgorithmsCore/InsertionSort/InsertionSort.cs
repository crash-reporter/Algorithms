using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableAlgorithms.InsertionSort
{
    public class InsertionSort : ISortAlgorithm
    {
        public void Sort(IComparable[] table)
        {
            var output = new List<IComparable>();
            foreach (var elementToSort in table)
            {
                var indexInSorted = 0;
                while (indexInSorted < output.Count && output[indexInSorted].CompareTo(elementToSort) <= 0)
                {
                    indexInSorted++;
                }
                output.Insert(indexInSorted, elementToSort);
            }
            for (var index = 0; index < table.Length; ++index)
            {
                table[index] = output[index];
            }
        }
    }
}