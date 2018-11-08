using System;

namespace SortableAlgorithmsCore
{
    public interface ISortAlgorithm
    {
        void Sort(IComparable[] table);
    }
}