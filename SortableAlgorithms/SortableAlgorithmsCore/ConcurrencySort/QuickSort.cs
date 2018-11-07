using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortableAlgorithms.ConcurrencySort
{
    public static class QuickSort 
    {

        public static async Task Sort(IComparable[] table, CancellationToken cancellationToken)
        {
            await QuickSortIntern(table, 0, table.Length - 1,2, cancellationToken);
        }

        private static async Task QuickSortIntern(IComparable[] elements, int left, int right, int splitLeft, CancellationToken cancellationToken)
        {
            if (left >= right)
            {
                return;
            }
            var onLeft = left;
            var onRight = right;
            var comparableElement = elements[(onRight + onLeft) >> 1]; // (right + left) / 2
            do
            {
                cancellationToken.ThrowIfCancellationRequested();
                while (elements[onLeft].CompareTo(comparableElement) < 0) ++onLeft;
                while (elements[onRight].CompareTo(comparableElement) > 0) --onRight;
                if (onLeft <= onRight)
                {
                    var temp = elements[onLeft];
                    elements[onLeft] = elements[onRight];
                    elements[onRight] = temp;
                    ++onLeft;
                    --onRight;
                }
            }
            while (onLeft <= onRight);
            if (splitLeft > 0)
            {
                await Task.WhenAll(QuickSortIntern(elements, onLeft, right, splitLeft - 1, cancellationToken),
                                   QuickSortIntern(elements, left, onRight, splitLeft - 1, cancellationToken));
            }
            else
            {
                await Task.WhenAll(QuickSortIntern(elements, left, onRight, 0, cancellationToken),
                                   QuickSortIntern(elements, onLeft, right, 0, cancellationToken));


            }
        }
    }
}