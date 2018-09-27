using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableAlgorithms.BucketSort
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
            List<string>[] buckets = PrepareBuckets();
            PutToBuckets(buckets, table);
            List<string> sorted = SortBuckets(buckets);
            for (int index = 0; index < table.Length; ++index)
            {
                table[index] = sorted[index];
            }
        }

        private List<string>[] PrepareBuckets()
        {
            List<string>[] buckets = new List<string>[_bucketsCount];
            for (int i = 0; i < _bucketsCount; ++i)
            {
                buckets[i] = new List<string>();
            }
            return buckets;
        }

        private void PutToBuckets(List<string>[] buckets, string[] table)
        {
            foreach (string str in table)
            {
                int bucket = (int)str.ToUpper()[0] - 65;
                buckets[bucket].Add(str);
            }
        }

        private List<string> SortBuckets(List<string>[] buckets)
        {
            List<string> sorted = new List<string>();
            foreach (List<string> bucket in buckets)
            {
                string[] toSort = bucket.ToArray();
                _sortAlgorithm.Sort(toSort);
                sorted.AddRange(toSort);
            }
            return sorted;
        }
    }
}