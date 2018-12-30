using System;
using System.Collections.Generic;

namespace Algorithms.Utils.Models
{
    public class SortValue<T> : IComparable<SortValue<T>>
        where T: IComparable<T>
    {
        private T Value { get;  }
        private int? Position { get; }

        public SortValue(T value, int? position = null)
        {
            Value = value;
            Position = position;
        }

        public int CompareTo(SortValue<T> other)
        {
            return Value.CompareTo(other.Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static bool operator > (SortValue<T> a, SortValue<T> b) => a.CompareTo(b) > 0;
        public static bool operator < (SortValue<T> a, SortValue<T> b) => a.CompareTo(b) < 0;

        public static bool operator >= (SortValue<T> a, SortValue<T> b) => a.CompareTo(b) >= 0;
        public static bool operator <= (SortValue<T> a, SortValue<T> b) => a.CompareTo(b) <= 0;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != GetType())
                return false;

            var sortValue = (SortValue<T>)obj;

            return EqualityComparer<T>.Default.Equals(Value, sortValue.Value) && Position == sortValue.Position;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (EqualityComparer<T>.Default.GetHashCode(Value) * 397) ^ Position.GetHashCode();
            }
        }
    }
}
