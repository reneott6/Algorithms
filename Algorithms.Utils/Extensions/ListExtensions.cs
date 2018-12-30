using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Utils.Extensions
{
    public static class ListExtensions
    {
        public static string ToLogString<T>(this IList<T> src)
        {
            return $"[{string.Join(",", src.Select(x => x.ToString()))}]";
        }
    }
}
