﻿using System;

namespace SortableAlgorithmsCore.QuickSort
{
    public class QuickSort : ISortAlgorithm
    {
        public void Sort(IComparable[] table)
        {
            QuickSortIntern(table, 0, table.Length - 1);
        }

        private void QuickSortIntern(IComparable[] elements, int left, int right)
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
            QuickSortIntern(elements, left, onRight);
            QuickSortIntern(elements, onLeft, right);
        }
    }
}