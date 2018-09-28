using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableAlgorithms.QuickSort
{
    public class SimpleQuickSort
    {
        public void Sort(int[] table)
        {
            List<int> output = QuickSort(table.ToList());
            for (int index = 0; index < table.Length; ++index)
            {
                table[index] = output[index];
            }
        }

        private List<int> QuickSort(List<int> table)
        {
            if (table.Count <= 1)
            {
                return table;
            }
            int pivot = table.Count / 2;
            List<int> listLeft = new List<int>();
            List<int> listRight = new List<int>();
            for (int i = 0; i < table.Count; ++i)
            {
                if (i == pivot)
                {
                    continue;
                }
                if (table[i] > table[pivot])
                {
                    listRight.Add(table[i]);
                }
                else
                {
                    listLeft.Add(table[i]);
                }
            }
            List<int> result = new List<int>();
            result.AddRange(QuickSort(listLeft));
            result.Add(table[pivot]);
            result.AddRange(QuickSort(listRight));
            return result;
        }
    }
}