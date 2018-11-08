using System.Collections.Generic;
using System.Linq;
using SortableAlgorithmsCore.BubbleSort;

namespace SortableAlgorithmsCore.BucketSort
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
            var min = table.Min();
            var max = table.Max();
            var pivot = (max - min) / _bucketsCount + 1;
            var buckets = new List<int>[_bucketsCount];
            for (var i = 0; i < _bucketsCount; ++i)
            {
                buckets[i] = new List<int>();
            }
            foreach (var element in table)
            {
                var bucket = (element - min) / pivot;
                buckets[bucket].Add(element);
            }
            var simpleBubble = new SimpleBubbleSort();
            var sorted = new List<int>();
            foreach (var bucket in buckets)
            {
                var toSort = bucket.ToArray();
                simpleBubble.Sort(toSort);
                sorted.AddRange(toSort);
            }
            for (var index = 0; index < table.Length; ++index)
            {
                table[index] = sorted[index];
            }
        }
    }
}