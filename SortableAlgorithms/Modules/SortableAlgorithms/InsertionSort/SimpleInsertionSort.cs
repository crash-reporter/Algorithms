using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableAlgorithms.InsertionSort
{
    public class SimpleInsertionSort
    {
        public void Sort(int[] table)
        {
            List<int> output = new List<int>();
            foreach (int elementToSort in table)
            {
                int indexInSorted = 0;
                while (indexInSorted < output.Count && output[indexInSorted] <= elementToSort)
                {
                    indexInSorted++;
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