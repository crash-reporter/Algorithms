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
            List<string>[] buckets = PrepareBuckets();
            PutToBuckets(buckets, table);
            int countPerTasks = _bucketsCount / _threadCount + 1;
            IEnumerable<string>[] output = new IEnumerable<string>[_bucketsCount];
            List<Task> tasks = new List<Task>();
            for (int i = 0; i< _threadCount; ++i)
            {
                List<string>[] bucketsToSort = buckets.Skip(i * countPerTasks).Take(countPerTasks).Where(x => x.Any()).ToArray();
                Task newTask = Task.Factory.StartNew(() => SortBuckets(bucketsToSort, cancellationToken), cancellationToken);
                tasks.Add(newTask);
            }
            Task.WaitAll(tasks.ToArray(), cancellationToken);
            List<string> sorted = new List<string>();
            foreach(var values in buckets)
            {
                sorted.AddRange(values);
            }
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

        private void PutToBuckets(List<string>[] buckets, IEnumerable<string> records)
        {
            foreach (string str in records)
            {
                int bucket = (int)str.ToUpper()[0] - 65;
                buckets[bucket].Add(str);
            }
        }

        private void SortBuckets(IEnumerable<List<string>> buckets, CancellationToken cancellationToken)
        {
            foreach (List<string> bucket in buckets)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (bucket.Any() == false)
                {
                    continue;
                }
                string[] toSort = bucket.ToArray();
                _sortAlgorithm.Sort(toSort);
                bucket.Clear();
                bucket.AddRange(toSort);
            }
        }
    }
}