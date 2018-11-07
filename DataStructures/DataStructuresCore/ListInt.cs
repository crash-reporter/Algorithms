using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresCore
{
    public class ListInt : IEnumerable<int>
    {
        private int[] _values;

        public int Count { get; private set; }
        private int _capacity;

        public ListInt()
        {
            _capacity = 64;
            _values = new int[_capacity];
            Count = 0;
        }

        public ListInt(IReadOnlyCollection<int> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }
            _capacity = values.Count() * 2;
            _values = new int[_capacity];
            (values as int[])?.CopyTo(_values, 0);
            Count = values.Count;
        }

        public void Add(int value)
        {
            EnsureSize(Count + 1);
            _values[Count] = value;
            Count++;
        }

        public void Insert(int value, int index)
        {
            EnsureSize(Count + 1);
            if (index < Count)
            {
                Array.Copy(_values, index, _values, index + 1, Count - index);
            }
            _values[index] = value;
            Count++;
        }

        public bool Contains(int value)
        {
            for (var i = 0; i < Count; ++i)
            {
                if (_values[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(int value)
        {
            for (var i = 0; i < Count; ++i)
            {
                if (_values[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Remove(int value)
        {
            var index = IndexOf(value);
            if (index >= 0)
            {
                RemoveAt(index);
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            Count--;
            if (index < Count)
            {
                Array.Copy(_values, index + 1, _values, index, Count - index);
            }
            _values[Count] = 0;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= _capacity)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _values[index];
            }
            set
            {
                if (index < 0 || index >= _capacity)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _values[index] = value;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return (_values as IEnumerable<int>).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        private void EnsureSize(int size)
        {
            if (_capacity >= size)
            {
                return;
            }
            _capacity *= 2;
            var old = _values;
            _values = new int[_capacity];
            old.CopyTo(_values, 0);
        }
    }
}