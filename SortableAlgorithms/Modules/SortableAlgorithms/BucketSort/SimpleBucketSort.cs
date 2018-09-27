using SortableAlgorithms.BubbleSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableAlgorithms.BucketSort
{
    public class SimpleBucketSort
    {
        private readonly int _bucketsCount;

        public SimpleBucketSort(int bucketsCount)
        {
            _bucketsCount = bucketsCount;
        }

        public void Sort(int[] table)
        {
            int min = table.Min();
            int max = table.Max();
            int pivot = (max - min) / _bucketsCount + 1;
            List<int>[] buckets = new List<int>[_bucketsCount];
            for (int i = 0; i < _bucketsCount; ++i)
            {
                buckets[i] = new List<int>();
            }
            foreach (int element in table)
            {
                int bucket = (element - min) / pivot;
                buckets[bucket].Add(element);
            }
            SimpleBubbleSort simpleBubble = new SimpleBubbleSort();
            List<int> sorted = new List<int>();
            foreach (List<int> bucket in buckets)
            {
                int[] toSort = bucket.ToArray();
                simpleBubble.Sort(toSort);
                sorted.AddRange(toSort);
            }
            for (int index = 0; index < table.Length; ++index)
            {
                table[index] = sorted[index];
            }
        }
    }
}