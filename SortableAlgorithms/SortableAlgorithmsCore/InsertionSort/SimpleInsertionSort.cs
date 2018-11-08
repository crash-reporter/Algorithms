using System.Collections.Generic;

namespace SortableAlgorithmsCore.InsertionSort
{
    public class SimpleInsertionSort
    {
        public void Sort(int[] table)
        {
            var output = new List<int>();
            foreach (var elementToSort in table)
            {
                var indexInSorted = 0;
                while (indexInSorted < output.Count && output[indexInSorted] <= elementToSort)
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