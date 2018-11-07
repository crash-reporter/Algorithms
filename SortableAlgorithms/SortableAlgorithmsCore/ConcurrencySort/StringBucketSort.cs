using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortableAlgorithms.ConcurrencySort
{
    public class StringBucketSort
    {
        private readonly ISortAlgorithm _sortAlgorithm;
        private const int _bucketsCount = 26;
        private const int _threadCount = 4;

        public StringBucketSort(ISortAlgorithm sortAlgorithm)
        {
            _sortAlgorithm = sortAlgorithm;
        }

        public void Sort(string[] table, CancellationToken cancellationToken)
        {
            var buckets = PrepareBuckets();
            PutToBuckets(buckets, table);
            var countPerTasks = _bucketsCount / _threadCount + 1;
            var tasks = new List<Task>();
            for (var i = 0; i< _threadCount; ++i)
            {
                var bucketsToSort = buckets.Skip(i * countPerTasks).Take(countPerTasks).Where(x => x.Any()).ToArray();
                var newTask = Task.Factory.StartNew(() => SortBuckets(bucketsToSort, cancellationToken), cancellationToken);
                tasks.Add(newTask);
            }
            Task.WaitAll(tasks.ToArray(), cancellationToken);
            var sorted = new List<string>();
            foreach(var values in buckets)
            {
                sorted.AddRange(values);
            }
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

        private void PutToBuckets(List<string>[] buckets, IEnumerable<string> records)
        {
            foreach (var str in records)
            {
                var bucket = (int)str.ToUpper()[0] - 65;
                buckets[bucket].Add(str);
            }
        }

        private void SortBuckets(IEnumerable<List<string>> buckets, CancellationToken cancellationToken)
        {
            foreach (var bucket in buckets)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (bucket.Any() == false)
                {
                    continue;
                }
                var toSort = bucket.ToArray();
                _sortAlgorithm.Sort(toSort);
                bucket.Clear();
                bucket.AddRange(toSort);
            }
        }
    }
}