using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SortableAlgorithmsCore.QuickSort;
using Xunit;

namespace UnitTestsCore
{
    public class PerformanceSortAlgorithms
    {
        [Fact]
        public async Task PerformanceTest()
        {
            var length = 5_000_000;
            var random = new Random();
            var test = new ComparableInt[length];
            for(var i = 0; i < length; ++i)
            {
                test[i] = new ComparableInt(random.Next(-100_000, 100_000));
            }
            var test1 = new ComparableInt[length];
            var test2 = new ComparableInt[length];
            var test3 = new ComparableInt[length];
            Array.Copy(test, test1, length);
            Array.Copy(test, test2, length);
            Array.Copy(test, test3, length);
            
            var sw = new Stopwatch();
            sw.Start();
            new QuickSort().Sort(test1);
            sw.Stop();
            Trace.WriteLine($"Quick Sort: {sw.Elapsed}");

            sw.Reset();
            sw.Start();
            await SortableAlgorithmsCore.ConcurrencySort.QuickSort.Sort(test2, CancellationToken.None);
            sw.Stop();
            Trace.WriteLine($"Quick Sort Async: {sw.Elapsed}");

            sw.Reset();
            sw.Start();
            Array.Sort(test3);
            sw.Stop();
            Trace.WriteLine($"Array.Sort: {sw.Elapsed}");
        }
    }
}
