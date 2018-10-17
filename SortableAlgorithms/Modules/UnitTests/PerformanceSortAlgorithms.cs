using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class PerformanceSortAlgorithms
    {
        [TestMethod]
        public void PerformanceTest()
        {
            int length = 5000000;
            Random random = new Random();
            ComparableInt[] test = new ComparableInt[length];
            for(int i = 0; i < length; ++i)
            {
                test[i] = new ComparableInt(random.Next(-100000, 100000));
            }
            ComparableInt[] test1 = new ComparableInt[length];
            ComparableInt[] test2 = new ComparableInt[length];
            ComparableInt[] test3 = new ComparableInt[length];
            Array.Copy(test, test1, length);
            Array.Copy(test, test2, length);
            Array.Copy(test, test3, length);
            
            TimeSpan quickSort;
            TimeSpan quickSortAsync;
            TimeSpan main;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            new SortableAlgorithms.QuickSort.QuickSort().Sort(test1);
            sw.Stop();
            quickSort = sw.Elapsed;
            Trace.WriteLine($"Quick Sort: {sw.Elapsed}");

            sw.Reset();
            sw.Start();
            new SortableAlgorithms.ConcurrencySort.QuickSort().Sort(test2, CancellationToken.None);
            sw.Stop();
            quickSortAsync = sw.Elapsed;
            Trace.WriteLine($"Quick Sort Async: {sw.Elapsed}");

            sw.Reset();
            sw.Start();
            Array.Sort(test3);
            sw.Stop();
            main = sw.Elapsed;
            Trace.WriteLine($"Array.Sort: {sw.Elapsed}");
        }
    }
}
