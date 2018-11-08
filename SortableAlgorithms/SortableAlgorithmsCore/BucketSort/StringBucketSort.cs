using System.Collections.Generic;

namespace SortableAlgorithmsCore.BucketSort
{
    public class StringBucketSort
    {
        private readonly ISortAlgorithm _sortAlgorithm;
        private const int _bucketsCount = 26;

        public StringBucketSort(ISortAlgorithm sortAlgorithm)
        {
            _sortAlgorithm = sortAlgorithm;
        }

        public void Sort(string[] table)
        {
            var buckets = PrepareBuckets();
            PutToBuckets(buckets, table);
            var sorted = SortBuckets(buckets);
            for (var index = 0; index < table.Length; ++index)
            {
                table[index] = sorted[index];
            }
        }

        private List<string>[] PrepareBuckets()
        {
            var buckets = new List<string>[_bucketsCount];
            for (var i = 0; i < _bucketsCount; ++i)
            {
                buckets[i] = new List<string>();
            }
            return buckets;
        }

        private void PutToBuckets(List<string>[] buckets, string[] table)
        {
            foreach (var str in table)
            {
                var bucket = (int)str.ToUpper()[0] - 65;
                buckets[bucket].Add(str);
            }
        }

        private List<string> SortBuckets(List<string>[] buckets)
        {
            var sorted = new List<string>();
            foreach (var bucket in buckets)
            {
                var toSort = bucket.ToArray();
                _sortAlgorithm.Sort(toSort);
                sorted.AddRange(toSort);
            }
            return sorted;
        }
    }
}