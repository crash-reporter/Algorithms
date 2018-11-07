using System;

namespace UnitTestsCore
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
            var other = obj as ComparableInt;
            return Value.CompareTo(other.Value);
        }
    }
}