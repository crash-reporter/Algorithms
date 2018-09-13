using System;

namespace SortableAlgorithms
{
    public interface ISortAlgorithm
    {
        void Sort(IComparable[] table);
    }
}