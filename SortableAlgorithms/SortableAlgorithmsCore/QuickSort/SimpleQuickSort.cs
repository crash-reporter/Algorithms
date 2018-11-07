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
            var output = QuickSort(table.ToList());
            for (var index = 0; index < table.Length; ++index)
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
            var pivot = table.Count / 2;
            var listLeft = new List<int>();
            var listRight = new List<int>();
            for (var i = 0; i < table.Count; ++i)
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
            var result = new List<int>();
            result.AddRange(QuickSort(listLeft));
            result.Add(table[pivot]);
            result.AddRange(QuickSort(listRight));
            return result;
        }
    }
}