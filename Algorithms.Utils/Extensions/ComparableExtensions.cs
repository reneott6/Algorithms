using System;

namespace Algorithms.Utils.Extensions
{
    public static class ComparableExtensions
    {
        public static bool GreaterThan<T>(this IComparable<T> fst, T snd)
        {
            return fst.CompareTo(snd) > 0;
        }

        public static bool GreaterOrEqualThan<T>(this IComparable<T> fst, T snd)
        {
            return fst.CompareTo(snd) >= 0;
        }

        public static bool LesserThan<T>(this IComparable<T> fst, T snd)
        {
            return fst.CompareTo(snd) < 0;
        }

        public static bool LesserOrEqualThan<T>(this IComparable<T> fst, T snd)
        {
            return fst.CompareTo(snd) <= 0;
        }
    }
}
