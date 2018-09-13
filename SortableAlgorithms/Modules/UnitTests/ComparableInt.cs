using System;

namespace UnitTests
{
    public class ComparableInt : IComparable
    {
        public int Value { get; private set; }

        public ComparableInt(int value)
        {
            Value = value;
        }

        public int CompareTo(object obj)
        {
            ComparableInt other = obj as ComparableInt;
            return Value.CompareTo(other.Value);
        }
    }
}